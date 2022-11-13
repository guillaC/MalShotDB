using Screenshooter.GUI.Utils;
using Screenshooter.GUI.Models;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Collections.Generic;

namespace Screenshooter.GUI
{
    public partial class frmMain : Form
    {
        List<Malware> Malwares = new List<Malware>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            updateListView();
            if (!Analyzer.checkIfManalyzeExist())
            {
                MessageBox.Show("Manalyze not found ! please read the documentation.");
                runTakeScreenshotAndAnalyzeItToolStripMenuItem.Enabled = false;
            }

            int Counter = 0;
            List<String> Paths = new List<String>();
            Malwares = Saver.LoadData();
        }

        private void toolStripMenuReload_Click(object sender, EventArgs e)
        {
            updateListView();
        }

        private void updateListView()
        {
            List<String> Paths = new List<String>();

            try
            {
                Paths = Directory.GetFiles("./Malwares", "*.EXE", SearchOption.AllDirectories).Select(fileName => Path.GetFullPath(fileName)).ToList();
                Malwares = Saver.LoadData();
                lvFiles.Items.Clear();
                foreach (String Path in Paths)
                {
                    // Static & Informations
                    PeInformations PeInformations = Analyzer.GetPEInfo(Path);

                    if (PeInformations != null)
                    {
                        bool exist = false;
                        icons.Images.Add(PeInformations.ExeName, Analyzer.GetPEIcon(Path));

                        foreach (Malware malware in Malwares)
                        {
                            if (malware.PeInformations.Sha1 == PeInformations.Sha1)
                            {
                                exist = true;
                                continue;
                            }
                        }

                        string[] row = { PeInformations.ExeName, PeInformations.ProductName, PeInformations.VersionNumber, PeInformations.Description, PeInformations.CompanyName, PeInformations.LegalCopyright, PeInformations.LegalTrademarks, PeInformations.Size, PeInformations.Language, PeInformations.Sha1, exist ? "X" : "" };
                        var listViewItem = new ListViewItem(row, PeInformations.ExeName);
                        listViewItem.Tag = Path;
                        lvFiles.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchInListView(string term)
        {
            List<ListViewItem> lvItems = new List<ListViewItem>();
            foreach (ListViewItem lvItem in lvFiles.Items)
            {
                if (lvItem.Text.ToLower().Contains(term.ToLower()) || lvItem.SubItems[0].Text.ToLower().Contains(term.ToLower()) || lvItem.SubItems[0].Text.ToLower().Contains(term.ToLower()) || lvItem.SubItems[1].Text.ToLower().Contains(term.ToLower()) 
                    || lvItem.SubItems[2].Text.ToLower().Contains(term.ToLower()) || lvItem.SubItems[3].Text.ToLower().Contains(term.ToLower()) || lvItem.SubItems[4].Text.ToLower().Contains(term.ToLower()) || lvItem.SubItems[5].Text.ToLower().Contains(term.ToLower()) 
                    || lvItem.SubItems[6].Text.ToLower().Contains(term.ToLower()) || lvItem.SubItems[7].Text.ToLower().Contains(term.ToLower())) lvItems.Add(lvItem);
            }
            lvFiles.Items.Clear();
            lvFiles.Items.AddRange(lvItems.ToArray());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchInListView(Interaction.InputBox("String Search", "String Search", "Client"));
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count == 0) return;

            foreach (ListViewItem lvI in lvFiles.SelectedItems)
            {
                Process.Start(new ProcessStartInfo($"https://www.virustotal.com/gui/search/{lvI.SubItems[9].Text}") { UseShellExecute = true });
            }
        }

        private void runTakeScreenshotAndAnalyzeItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            if (lvFiles.SelectedItems.Count == 0) return;
            List<ListViewItem> lvItems = new List<ListViewItem>();
            foreach (ListViewItem item in lvFiles.SelectedItems) lvItems.Add((ListViewItem)item);

            lvFiles.Visible = false;
            tbLogs.Visible = true;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                foreach (ListViewItem lvI in lvItems)
                {
                    Counter++;
                    string Path = (string)lvI.Tag;
                    Malware malware = new Malware(Path, DateTime.Now.ToString());
                    tbLogs.BeginInvoke(() => tbLogs.AppendText($"Processing {Counter}/{lvItems.Count}{Environment.NewLine}"));
                    // Static & Informations
                    malware.PeInformations = Analyzer.GetPEInfo(Path);
                    malware.StaticAnalysis = Analyzer.Analysis(Path);

                    if (Malwares.Where(m => m.PeInformations.Sha1.Equals(malware.PeInformations.Sha1)).Count() > 0)// Check si unique dans le JSON
                    {
                        tbLogs.BeginInvoke(() => tbLogs.AppendText($"{malware.PeInformations.Sha1} entry already existing{Environment.NewLine}"));
                        continue;
                    }
                    else if (malware.StaticAnalysis.Manalyze != null && malware.StaticAnalysis.Manalyze.Contains("WINDOWS_GUI"))
                    {
                        List<UI> screenshots = ScreenShot.TakeScreenshot(Path);
                        if (screenshots.Count > 0) //save
                        {
                            malware.Screenshots = screenshots;
                            Malwares.Add(malware);
                            Saver.SaveData(Malwares);
                        }
                    } else if (malware.StaticAnalysis.Manalyze.Contains("WINDOWS_GUI"))
                    {
                        tbLogs.BeginInvoke(() => tbLogs.AppendText($"No GUI"));
                    }
                }

                lvFiles.BeginInvoke(() => lvFiles.Visible = true);
                tbLogs.BeginInvoke(() => tbLogs.Visible = false);
            }).Start();
        }
    }
}