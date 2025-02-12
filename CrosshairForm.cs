using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CrossHair
{
    public partial class CrosshairForm : Form
    {
        private Color crosshairColor = Color.Red;
        private Color dotColor = Color.Red;
        private int crosshairWidth = 2;
        private int crosshairHeight = 15;
        private bool showCenterDot = false;
        private int offset = 5;
        private const string SettingsFilePath = "Config.json";

        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public CrosshairForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
            this.StartPosition = FormStartPosition.Manual;
            this.ClientSize = new Size(crosshairHeight * 2, crosshairHeight * 2);
            this.ShowInTaskbar = false;

            CenterToScreen();
            EnableClickThrough();
            InitializeTrayIcon();
            LoadSettings();
        }

        private void InitializeTrayIcon()
        {
            this.FormClosing += CrosshairForm_FormClosing;
        }

        private void CrosshairForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        public void SetCrosshairSize(int width, int height)
        {
            this.crosshairWidth = width;
            this.crosshairHeight = height;

            this.ClientSize = new Size(crosshairHeight * 2, crosshairHeight * 2);
            CenterToScreen();
            this.Invalidate();
        }

        public void SetCrosshairColor(Color color)
        {
            this.crosshairColor = color;
            this.Invalidate();
        }

        public void SetDotColor(Color color)
        {
            this.dotColor = color;
            this.Invalidate();
        }

        public void ShowCenterDot(bool show)
        {
            this.showCenterDot = show;
            this.Invalidate();
        }

        public void SetOffset(int newOffset)
        {
            this.offset = newOffset;
            this.Invalidate();  
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            using (Pen pen = new Pen(crosshairColor, crosshairWidth))
            {
                int centerX = this.ClientSize.Width / 2;
                int centerY = this.ClientSize.Height / 2;

                int innerLength = offset;
                int outerLength = crosshairHeight;

                g.DrawLine(pen, centerX - innerLength, centerY, centerX - innerLength - outerLength, centerY);
                g.DrawLine(pen, centerX + innerLength, centerY, centerX + innerLength + outerLength, centerY);

                g.DrawLine(pen, centerX, centerY - innerLength, centerX, centerY - innerLength - outerLength);
                g.DrawLine(pen, centerX, centerY + innerLength, centerX, centerY + innerLength + outerLength);

                if (showCenterDot)
                {
                    using (Brush brush = new SolidBrush(dotColor))
                    {
                        int dotSize = 4;
                        if (crosshairWidth == 1)
                        {
                            dotSize = 3;
                        }
                        else
                        {
                            dotSize = 4;
                        }

                        int startX = centerX - dotSize / 2;
                        int startY = centerY - dotSize / 2;

                        for (int y = 0; y < dotSize; y++)
                        {
                            for (int x = 0; x < dotSize; x++)
                            {
                                if ((x == 0 && y == 0) || (x == 0 && y == dotSize - 1) ||
                                    (x == dotSize - 1 && y == 0) || (x == dotSize - 1 && y == dotSize - 1))
                                {
                                    continue;
                                }
                                g.FillRectangle(brush, startX + x, startY + y, 1, 1);
                            }
                        }
                    }
                }
            }
        }

        private void EnableClickThrough()
        {
            int initialStyle = GetWindowLong(this.Handle, -20);
            //SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            //SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20 | 0x80);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20 | 0x80 | 0x8000000);
        }

        private void CenterToScreen()
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Width - this.ClientSize.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.ClientSize.Height) / 2
            );
        }

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private void LoadSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                var settings = JsonConvert.DeserializeObject<CrosshairSettings>(json);

                SetCrosshairSize(settings.CrosshairWidth, settings.CrosshairHeight);
                SetOffset(settings.Offset);
                ShowCenterDot(settings.ShowCenterDot);
                SetCrosshairColor(ColorTranslator.FromHtml(settings.CrosshairColor));
                SetDotColor(ColorTranslator.FromHtml(settings.DotColor));
            }
        }

        public void SaveSettings()
        {
            var settings = new CrosshairSettings
            {
                CrosshairWidth = crosshairWidth,
                CrosshairHeight = crosshairHeight,
                Offset = offset,
                ShowCenterDot = showCenterDot,
                CrosshairColor = ColorTranslator.ToHtml(crosshairColor),
                DotColor = ColorTranslator.ToHtml(dotColor)
            };

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(SettingsFilePath, json);
        }

    }
}
