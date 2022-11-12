using Screenshooter.GUI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Screenshooter.GUI.Utils
{
    public class ScreenShot
    {
        const int TIMEOUT = 5;

        #region IMPORTS
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr parentWindow, IntPtr previousChildWindow, string windowClass, string windowTitle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr window, out int process);

        public delegate bool EnumedWindow(IntPtr handleWindow, ArrayList handles);
        #endregion

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static Bitmap CaptureFromHandle(IntPtr pHandle)
        {
            Bitmap bitmap = null;
            if (SetForegroundWindow(pHandle) && IsWindowVisible(pHandle))
            {
                RECT rect = new RECT();

                if (GetWindowRect(pHandle, ref rect))
                {
                    int width = rect.Right - rect.Left;
                    int height = rect.Bottom - rect.Top;

                    if (width > 0 && height > 0)
                    {
                        bitmap = new Bitmap(width, height);
                        using (var g = Graphics.FromImage(bitmap))
                        {
                            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
                        }
                    }
                    return bitmap;
                }
            }
            return bitmap;
        }

        public static Dictionary<String, Bitmap> CaptureFromProcess(Process pProcess)
        {
            Console.WriteLine($"Capture from Process : {pProcess.ProcessName}");
            StringBuilder uiTitle = new StringBuilder();
            pProcess.Refresh();

            Dictionary<String, Bitmap> captures = new();
            List<IntPtr> handles = GetProcessWindows(pProcess.Id);
            foreach (IntPtr handle in handles)
            {
                try
                {
                    Bitmap bitmap = CaptureFromHandle(handle);
                    if (bitmap != null && GetWindowText(handle, uiTitle, 256) > 0)
                    {
                        Console.WriteLine($"Handle : {handle} - {uiTitle.ToString()}");
                        captures.Add(uiTitle.ToString(), bitmap);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            return captures;
        }

        private static List<IntPtr> GetProcessWindows(int pProcess)
        {
            List<IntPtr> handles = new();
            IntPtr pLast = IntPtr.Zero;
            do
            {
                pLast = FindWindowEx(IntPtr.Zero, pLast, null, null);
                int iProcess_;
                GetWindowThreadProcessId(pLast, out iProcess_);
                if (iProcess_ == pProcess) handles.Add(pLast);
            } while (pLast != IntPtr.Zero);
            return handles;
        }

        public static bool WaitUI(Process process)
        {
            int counter = 0;
            Console.WriteLine("Waiting for UI...");
            while (process.MainWindowHandle.ToInt32() == 0)
            {
                Thread.Sleep(1000);
                process.Refresh();
                counter++;
                if (counter == TIMEOUT) return false;
            }
            return true;
        }

        public static List<UI> TakeScreenshot(String Path)
        {
            List<UI> uIs = new List<UI>();
            List<Process> allProcessOne = Process.GetProcesses().ToList();

            try
            {
                Process newProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Path,
                        UseShellExecute = true
                    }
                };

                Console.WriteLine($"Running {Path}");
                newProcess.Start();
                Console.WriteLine($"Waiting 10 seconds");
                Thread.Sleep(10000);

                List<Process> allProcessTwo = Process.GetProcesses().ToList();
                List<Process> allProcessDifOneTwo = new List<Process>();

                foreach (Process process in allProcessTwo)
                {
                    try
                    {
                        if (allProcessOne.Where(p => p.Id == process.Id && p.ProcessName == process.ProcessName).Count() == 0)
                        {
                            allProcessDifOneTwo.Add(process);
                        }
                    }
                    catch { }
                }

                foreach (Process process in allProcessDifOneTwo)
                {
                    if (process is null) continue;

                    if (ScreenShot.WaitUI(process))
                    {
                        Dictionary<String, Bitmap> screenshots = ScreenShot.CaptureFromProcess(process);
                        foreach (KeyValuePair<String, Bitmap> screenshot in screenshots)
                        {
                            string randomStr = Guid.NewGuid().ToString("n");
                            var MainWindowTitleWithoutSpclCharac = Regex.Replace(process.MainWindowTitle, @"[^0-9a-zA-Z\._]", "");
                            if (MainWindowTitleWithoutSpclCharac.Length > 8) MainWindowTitleWithoutSpclCharac = MainWindowTitleWithoutSpclCharac.Substring(0, 8);

                            string filename = $"./Screenshots/{MainWindowTitleWithoutSpclCharac}_{screenshot.Key}_{randomStr}.png";
                            screenshot.Value.Save(filename);
                            uIs.Add(new UI(screenshot.Key, filename));
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Unable to retrieve handle..");
                    }
                }

                foreach (Process process in allProcessDifOneTwo)
                {
                    process.CloseMainWindow();
                    process.Kill(true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return uIs;
        }

    }
}
