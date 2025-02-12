using CrossHair.Resources;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CrossHair
{
    public partial class SettingsForm : Form
    {
        private CrosshairForm crosshairForm;
        private const string SettingsFilePath = "Config.json";
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private bool isAppRunning = false;

        public SettingsForm()
        {
            InitializeComponent();

            crosshairForm = new CrosshairForm();
            crosshairForm.Show();

            LoadSettings();

            InitializeTrayIcon();

            isAppRunning = true;
        }

        private void InitializeTrayIcon()
        {
            if (trayIcon != null) return;

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Показать", ShowForm);
            trayMenu.MenuItems.Add("Закрыть", ExitApplication);

            trayIcon = new NotifyIcon()
            {
                Icon = Resource1.Group_8,
                ContextMenu = trayMenu,
                Text = "Прицел",
                Visible = true
            };
            trayIcon.DoubleClick += ShowForm; 
        }

        private void LoadSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                var settings = JsonConvert.DeserializeObject<CrosshairSettings>(json);

                crosshairForm.SetCrosshairSize(settings.CrosshairWidth, settings.CrosshairHeight);
                crosshairForm.SetOffset(settings.Offset);
                crosshairForm.ShowCenterDot(settings.ShowCenterDot);
                crosshairForm.SetCrosshairColor(ColorTranslator.FromHtml(settings.CrosshairColor));
                crosshairForm.SetDotColor(ColorTranslator.FromHtml(settings.DotColor));

                numericUpDown3.Value = settings.CrosshairWidth;
                numericUpDown2.Value = settings.CrosshairHeight;
                numericUpDown1.Value = settings.Offset;
                checkBox1.Checked = settings.ShowCenterDot;
                ColorCrossR.Progress = ColorTranslator.FromHtml(settings.CrosshairColor).R;
                ColorCrossG.Progress = ColorTranslator.FromHtml(settings.CrosshairColor).G;
                ColorCrossB.Progress = ColorTranslator.FromHtml(settings.CrosshairColor).B;
                ColorDotR.Progress = ColorTranslator.FromHtml(settings.DotColor).R;
                ColorDotG.Progress = ColorTranslator.FromHtml(settings.DotColor).G;
                ColorDotB.Progress = ColorTranslator.FromHtml(settings.DotColor).B;
            }
        }

        private void ShowForm(object sender, EventArgs e)
        {
            if (!isAppRunning)
                return;

            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void ColorDotR_Scroll(object sender, EventArgs e)
        {
            Color selectedDotColor = Color.FromArgb((int)ColorDotR.Progress, (int)ColorDotG.Progress, (int)ColorDotB.Progress);
            crosshairForm.SetDotColor(selectedDotColor);

            var settings = LoadSettingsFromJson();
            settings.DotColor = ColorTranslator.ToHtml(selectedDotColor);
            SaveSettingsToJson(settings);
        }

        private void ColorCross_Scroll(object sender, EventArgs e)
        {
            Color selectedCrosshairColor = Color.FromArgb((int)ColorCrossR.Progress, (int)ColorCrossG.Progress, (int)ColorCrossB.Progress);
            crosshairForm.SetCrosshairColor(selectedCrosshairColor);

            var settings = LoadSettingsFromJson();
            settings.CrosshairColor = ColorTranslator.ToHtml(selectedCrosshairColor);
            SaveSettingsToJson(settings);
        }

        private CrosshairSettings LoadSettingsFromJson()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                return JsonConvert.DeserializeObject<CrosshairSettings>(json);
            }

            return new CrosshairSettings
            {
                CrosshairWidth = 2,
                CrosshairHeight = 15,
                Offset = 5,
                ShowCenterDot = false,
                CrosshairColor = "#FF0000",
                DotColor = "#FF0000" 
            };
        }

        private void SetColorDot()
        {
            Color selectedDotColor = Color.FromArgb((int)ColorDotR.Progress, (int)ColorDotG.Progress, (int)ColorDotB.Progress);
            crosshairForm.SetDotColor(selectedDotColor);
        }

        private void SetCrosshairColor()
        {
            Color selectedCrosshairColor = Color.FromArgb((int)ColorCrossR.Progress, (int)ColorCrossG.Progress, (int)ColorCrossB.Progress);
            crosshairForm.SetCrosshairColor(selectedCrosshairColor);
        }

        private void SaveSettingsToJson(CrosshairSettings settings)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(SettingsFilePath, json);
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void ColorCrossR_Scroll(object sender, EventArgs e) { SetCrosshairColor(); }
        private void ColorCrossG_Scroll(object sender, EventArgs e) { SetCrosshairColor(); }
        private void ColorCrossB_Scroll(object sender, EventArgs e) { SetCrosshairColor(); }

        private void tntButton1_Click(object sender, EventArgs e)
        {
            Color selectedCrosshairColor = Color.FromArgb((int)ColorCrossR.Progress, (int)ColorCrossG.Progress, (int)ColorCrossB.Progress);
            Color selectedDotColor = Color.FromArgb((int)ColorDotR.Progress, (int)ColorDotG.Progress, (int)ColorDotB.Progress);

            crosshairForm.SetCrosshairSize((int)numericUpDown3.Value, (int)numericUpDown2.Value);
            crosshairForm.SetOffset((int)numericUpDown1.Value);
            crosshairForm.ShowCenterDot(checkBox1.Checked);
            crosshairForm.SetCrosshairColor(selectedCrosshairColor);
            crosshairForm.SetDotColor(selectedDotColor);

            var settings = new CrosshairSettings
            {
                CrosshairWidth = (int)numericUpDown3.Value,
                CrosshairHeight = (int)numericUpDown2.Value,
                Offset = (int)numericUpDown1.Value,
                ShowCenterDot = checkBox1.Checked,
                CrosshairColor = ColorTranslator.ToHtml(selectedCrosshairColor),
                DotColor = ColorTranslator.ToHtml(selectedDotColor)
            };

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(SettingsFilePath, json);
        }

        private void SettingsForm_Load(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            crosshairForm.ShowCenterDot(checkBox1.Checked);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            crosshairForm.SetOffset((int)numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            crosshairForm.SetCrosshairSize((int)numericUpDown3.Value, (int)numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            crosshairForm.SetCrosshairSize((int)numericUpDown3.Value, (int)numericUpDown2.Value);
        }

        private void ColorDotR_Click(object sender, EventArgs e)
        {
            SetColorDot();
        }
        private void ColorDotG_Click(object sender, EventArgs e)
        {
            SetColorDot();
        }
        private void ColorDotB_Click(object sender, EventArgs e)
        {
            SetColorDot();
        }

        private void ColorCrossB_Click(object sender, EventArgs e) { }
        private void ColorCrossG_Click(object sender, EventArgs e) { }
        private void ColorCrossR_Click(object sender, EventArgs e) { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
