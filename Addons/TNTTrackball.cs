using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace CrossHair
{
    public class TNTTrackball : Control
    {
        // Fields
        private int ballRadius = 15;
        private int progress = 0;
        private Color progressColor = Color.MediumSlateBlue;
        private Color trackColor = Color.LightGray;
        private int trackHeight = 10;
        private int leftPadding = 10;
        private int rightPadding = 10;
        private int maxValue = 100;

        // New properties for text customization
        private Color textColor = Color.White;  // Default text color
        private Font textFont = new Font("Arial", 10, FontStyle.Bold); // Default font for the text

        // Event for click on the ball
        public event EventHandler BallClicked;

        // Properties
        [Category("TNT Code Advance")]
        public int BallRadius
        {
            get { return ballRadius; }
            set
            {
                ballRadius = value;
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public int Progress
        {
            get { return progress; }
            set
            {
                progress = Math.Max(0, Math.Min(maxValue, value));
                this.Invalidate();
                ProgressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Category("TNT Code Advance")]
        public Color ProgressColor
        {
            get { return progressColor; }
            set
            {
                progressColor = value;
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public Color TrackColor
        {
            get { return trackColor; }
            set
            {
                trackColor = value;
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public int TrackHeight
        {
            get { return trackHeight; }
            set
            {
                trackHeight = Math.Max(5, Math.Min(value, this.Height / 2));
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public int LeftPadding
        {
            get { return leftPadding; }
            set
            {
                leftPadding = Math.Max(0, value);
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public int RightPadding
        {
            get { return rightPadding; }
            set
            {
                rightPadding = Math.Max(0, value);
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public int MaxValue
        {
            get { return maxValue; }
            set
            {
                maxValue = Math.Max(1, value);
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public int MinHeight
        {
            get { return this.Height; }
            set
            {
                this.Height = Math.Max(value, 2 * BallRadius);
            }
        }

        // New properties for text customization
        [Category("TNT Code Advance")]
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        [Category("TNT Code Advance")]
        public Font TextFont
        {
            get { return textFont; }
            set
            {
                textFont = value;
                this.Invalidate();
            }
        }

        // Events
        public event EventHandler ProgressChanged;

        // Constructor
        public TNTTrackball()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(300, 50);
        }

        // Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Ensure the height is large enough to accommodate the ball
            if (this.Height < 2 * BallRadius)
            {
                this.Height = 2 * BallRadius; // Set minimum height for control
            }

            // Track height and position
            int trackY = (this.Height - trackHeight) / 2;

            // Draw the track
            Rectangle trackRect = new Rectangle(leftPadding, trackY, this.Width - leftPadding - rightPadding, trackHeight);
            using (Brush trackBrush = new SolidBrush(TrackColor))
            {
                g.FillRectangle(trackBrush, trackRect);
            }

            // Draw the progress based on MaxValue
            Rectangle progressRect = new Rectangle(leftPadding, trackY, (int)((this.Width - leftPadding - rightPadding) * (Progress / (float)maxValue)), trackHeight);
            using (Brush progressBrush = new SolidBrush(ProgressColor))
            {
                g.FillRectangle(progressBrush, progressRect);
            }

            // Draw the ball (circle)
            int ballX = leftPadding + (int)((this.Width - leftPadding - rightPadding) * (Progress / (float)maxValue)) - BallRadius;
            int ballY = (this.Height - 2 * BallRadius) / 2;
            Rectangle ballRect = new Rectangle(ballX, ballY, BallRadius * 2, BallRadius * 2);

            using (Brush ballBrush = new SolidBrush(ProgressColor))
            {
                g.FillEllipse(ballBrush, ballRect);
            }

            // Draw the progress value inside the ball
            string progressText = Progress.ToString();
            using (Brush textBrush = new SolidBrush(TextColor))
            {
                // Calculate text size and position to center it in the ball
                SizeF textSize = g.MeasureString(progressText, TextFont);
                float textX = ballX + (BallRadius * 2 - textSize.Width) / 2;
                float textY = ballY + (BallRadius * 2 - textSize.Height) / 2;

                g.DrawString(progressText, TextFont, textBrush, textX, textY);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            UpdateProgress(e.X); // Update progress when mouse is pressed
            BallClicked?.Invoke(this, EventArgs.Empty); // Trigger event when clicking on the ball
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                UpdateProgress(e.X); // Continuously update progress while moving
                BallClicked?.Invoke(this, EventArgs.Empty); // Trigger event while moving the ball
            }
        }

        private void UpdateProgress(int mouseX)
        {
            // Calculate progress based on mouse position, considering the paddings and MaxValue
            int paddedX = Math.Max(leftPadding, Math.Min(this.Width - rightPadding, mouseX));
            Progress = (int)((paddedX - leftPadding) / (float)(this.Width - leftPadding - rightPadding) * maxValue);
        }
    }
}
