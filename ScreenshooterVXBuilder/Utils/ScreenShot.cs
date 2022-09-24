using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace ScreenshooterVXBuilder.Utils
{
    internal class ScreenShot
    {
        const int TIMEOUT = 10;

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
            if (SetForegroundWindow(pHandle))
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
            StringBuilder uiTitle = new StringBuilder();

            pProcess.Refresh();

            Dictionary<String, Bitmap> captures = new();
            List<IntPtr> handles = GetProcessWindows(pProcess.Id);
            foreach (IntPtr handle in handles)
            {
                Bitmap bitmap = CaptureFromHandle(handle);
                if (bitmap != null && GetWindowText(handle, uiTitle, 256) > 0)
                {
                    captures.Add(uiTitle.ToString(), bitmap);
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
            Console.WriteLine("attente d'une UI...");
            while (process.MainWindowHandle.ToInt32() == 0)
            {
                Thread.Sleep(1000);
                process.Refresh();
                counter++;
                if (counter == TIMEOUT) return false;
            }
            return true;
        }
    }
}
