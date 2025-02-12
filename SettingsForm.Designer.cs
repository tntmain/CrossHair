using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrossHair
{
    partial class SettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ColorCrossB = new CrossHair.TNTTrackball();
            this.ColorCrossG = new CrossHair.TNTTrackball();
            this.ColorCrossR = new CrossHair.TNTTrackball();
            this.ColorDotB = new CrossHair.TNTTrackball();
            this.ColorDotG = new CrossHair.TNTTrackball();
            this.ColorDotR = new CrossHair.TNTTrackball();
            this.ButtonAp = new CrossHair.TNTButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Riffic Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.Azure;
            this.checkBox1.Location = new System.Drawing.Point(17, 554);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Точка в центре";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ColorCrossB);
            this.panel1.Controls.Add(this.ColorCrossG);
            this.panel1.Controls.Add(this.ColorCrossR);
            this.panel1.Controls.Add(this.ColorDotB);
            this.panel1.Controls.Add(this.ColorDotG);
            this.panel1.Controls.Add(this.ColorDotR);
            this.panel1.Controls.Add(this.ButtonAp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 638);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(210, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "by tnt | v 0.7";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Riffic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(96, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Цвет прицела";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Riffic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(107, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Цвет точки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Riffic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Riffic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Размер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Riffic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Отступ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown3.Font = new System.Drawing.Font("Riffic Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.Azure;
            this.numericUpDown3.Location = new System.Drawing.Point(91, 70);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(197, 23);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown2.Font = new System.Drawing.Font("Riffic Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Azure;
            this.numericUpDown2.Location = new System.Drawing.Point(91, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(197, 23);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Riffic Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Azure;
            this.numericUpDown1.Location = new System.Drawing.Point(91, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(197, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ColorCrossB
            // 
            this.ColorCrossB.BallRadius = 10;
            this.ColorCrossB.Font = new System.Drawing.Font("Riffic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCrossB.LeftPadding = 11;
            this.ColorCrossB.Location = new System.Drawing.Point(17, 477);
            this.ColorCrossB.MaxValue = 255;
            this.ColorCrossB.MinHeight = 27;
            this.ColorCrossB.Name = "ColorCrossB";
            this.ColorCrossB.Progress = 0;
            this.ColorCrossB.ProgressColor = System.Drawing.Color.Blue;
            this.ColorCrossB.RightPadding = 11;
            this.ColorCrossB.Size = new System.Drawing.Size(271, 27);
            this.ColorCrossB.TabIndex = 22;
            this.ColorCrossB.Text = "tntTrackball2";
            this.ColorCrossB.TextColor = System.Drawing.Color.White;
            this.ColorCrossB.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCrossB.TrackColor = System.Drawing.Color.LightCyan;
            this.ColorCrossB.TrackHeight = 5;
            this.ColorCrossB.BallClicked += new System.EventHandler(this.ColorCrossB_Scroll);
            // 
            // ColorCrossG
            // 
            this.ColorCrossG.BallRadius = 10;
            this.ColorCrossG.Font = new System.Drawing.Font("Riffic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCrossG.LeftPadding = 11;
            this.ColorCrossG.Location = new System.Drawing.Point(17, 432);
            this.ColorCrossG.MaxValue = 254;
            this.ColorCrossG.MinHeight = 27;
            this.ColorCrossG.Name = "ColorCrossG";
            this.ColorCrossG.Progress = 0;
            this.ColorCrossG.ProgressColor = System.Drawing.Color.Green;
            this.ColorCrossG.RightPadding = 11;
            this.ColorCrossG.Size = new System.Drawing.Size(271, 27);
            this.ColorCrossG.TabIndex = 21;
            this.ColorCrossG.Text = "tntTrackball2";
            this.ColorCrossG.TextColor = System.Drawing.Color.White;
            this.ColorCrossG.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCrossG.TrackColor = System.Drawing.Color.LightCyan;
            this.ColorCrossG.TrackHeight = 5;
            this.ColorCrossG.BallClicked += new System.EventHandler(this.ColorCrossG_Scroll);
            // 
            // ColorCrossR
            // 
            this.ColorCrossR.BallRadius = 10;
            this.ColorCrossR.Font = new System.Drawing.Font("Riffic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCrossR.LeftPadding = 11;
            this.ColorCrossR.Location = new System.Drawing.Point(17, 387);
            this.ColorCrossR.MaxValue = 255;
            this.ColorCrossR.MinHeight = 27;
            this.ColorCrossR.Name = "ColorCrossR";
            this.ColorCrossR.Progress = 0;
            this.ColorCrossR.ProgressColor = System.Drawing.Color.Red;
            this.ColorCrossR.RightPadding = 11;
            this.ColorCrossR.Size = new System.Drawing.Size(271, 27);
            this.ColorCrossR.TabIndex = 20;
            this.ColorCrossR.Text = "tntTrackball1";
            this.ColorCrossR.TextColor = System.Drawing.Color.White;
            this.ColorCrossR.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCrossR.TrackColor = System.Drawing.Color.LightCyan;
            this.ColorCrossR.TrackHeight = 5;
            this.ColorCrossR.BallClicked += new System.EventHandler(this.ColorCrossR_Scroll);
            // 
            // ColorDotB
            // 
            this.ColorDotB.BallRadius = 10;
            this.ColorDotB.Font = new System.Drawing.Font("Riffic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorDotB.LeftPadding = 11;
            this.ColorDotB.Location = new System.Drawing.Point(17, 267);
            this.ColorDotB.MaxValue = 255;
            this.ColorDotB.MinHeight = 27;
            this.ColorDotB.Name = "ColorDotB";
            this.ColorDotB.Progress = 0;
            this.ColorDotB.ProgressColor = System.Drawing.Color.Blue;
            this.ColorDotB.RightPadding = 11;
            this.ColorDotB.Size = new System.Drawing.Size(271, 27);
            this.ColorDotB.TabIndex = 19;
            this.ColorDotB.Text = "tntTrackball1";
            this.ColorDotB.TextColor = System.Drawing.Color.White;
            this.ColorDotB.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorDotB.TrackColor = System.Drawing.Color.LightCyan;
            this.ColorDotB.TrackHeight = 5;
            this.ColorDotB.BallClicked += new System.EventHandler(this.ColorDotB_Click);
            // 
            // ColorDotG
            // 
            this.ColorDotG.BallRadius = 10;
            this.ColorDotG.Font = new System.Drawing.Font("Riffic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorDotG.LeftPadding = 11;
            this.ColorDotG.Location = new System.Drawing.Point(17, 234);
            this.ColorDotG.MaxValue = 254;
            this.ColorDotG.MinHeight = 27;
            this.ColorDotG.Name = "ColorDotG";
            this.ColorDotG.Progress = 0;
            this.ColorDotG.ProgressColor = System.Drawing.Color.Green;
            this.ColorDotG.RightPadding = 11;
            this.ColorDotG.Size = new System.Drawing.Size(271, 27);
            this.ColorDotG.TabIndex = 18;
            this.ColorDotG.Text = "tntTrackball1";
            this.ColorDotG.TextColor = System.Drawing.Color.White;
            this.ColorDotG.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorDotG.TrackColor = System.Drawing.Color.LightCyan;
            this.ColorDotG.TrackHeight = 5;
            this.ColorDotG.BallClicked += new System.EventHandler(this.ColorDotG_Click);
            // 
            // ColorDotR
            // 
            this.ColorDotR.BallRadius = 10;
            this.ColorDotR.Font = new System.Drawing.Font("Riffic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorDotR.LeftPadding = 11;
            this.ColorDotR.Location = new System.Drawing.Point(17, 201);
            this.ColorDotR.MaxValue = 255;
            this.ColorDotR.MinHeight = 27;
            this.ColorDotR.Name = "ColorDotR";
            this.ColorDotR.Progress = 0;
            this.ColorDotR.ProgressColor = System.Drawing.Color.Red;
            this.ColorDotR.RightPadding = 11;
            this.ColorDotR.Size = new System.Drawing.Size(271, 27);
            this.ColorDotR.TabIndex = 17;
            this.ColorDotR.Text = "tntTrackball1";
            this.ColorDotR.TextColor = System.Drawing.Color.White;
            this.ColorDotR.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorDotR.TrackColor = System.Drawing.Color.LightCyan;
            this.ColorDotR.TrackHeight = 5;
            this.ColorDotR.BallClicked += new System.EventHandler(this.ColorDotR_Click);
            // 
            // ButtonAp
            // 
            this.ButtonAp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonAp.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonAp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAp.BorderRadius = 15;
            this.ButtonAp.BorderSize = 0;
            this.ButtonAp.FlatAppearance.BorderSize = 0;
            this.ButtonAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAp.Font = new System.Drawing.Font("Riffic Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAp.ForeColor = System.Drawing.Color.White;
            this.ButtonAp.Location = new System.Drawing.Point(12, 588);
            this.ButtonAp.Name = "ButtonAp";
            this.ButtonAp.Size = new System.Drawing.Size(276, 38);
            this.ButtonAp.TabIndex = 16;
            this.ButtonAp.Text = "Применить";
            this.ButtonAp.TextColor = System.Drawing.Color.White;
            this.ButtonAp.UseVisualStyleBackColor = false;
            this.ButtonAp.Click += new System.EventHandler(this.tntButton1_Click);
            // 
            // SettingsForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(300, 638);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private CheckBox checkBox1;
        private Panel panel1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TNTButton ButtonAp;
        private TNTTrackball ColorDotR;
        private TNTTrackball ColorDotB;
        private TNTTrackball ColorDotG;
        private TNTTrackball ColorCrossG;
        private TNTTrackball ColorCrossR;
        private TNTTrackball ColorCrossB;
        private Label label6;
    }
}
