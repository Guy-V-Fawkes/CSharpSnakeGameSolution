namespace CSharpSnakeGame
{
    partial class PlayGround
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ScoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Venus Rising", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GameOverLabel.Location = new System.Drawing.Point(12, 154);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(166, 23);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "Game Over";
            // 
            // Status
            // 
            this.Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ScoreLabel});
            this.Status.Location = new System.Drawing.Point(0, 410);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(477, 23);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 18);
            this.StatusLabel.Text = "Score";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScoreLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(32, 18);
            this.ScoreLabel.Text = "000";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 150;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PlayGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(477, 433);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.GameOverLabel);
            this.DoubleBuffered = true;
            this.Name = "PlayGround";
            this.Text = " Snake Game";
            this.Load += new System.EventHandler(this.GameTimer_Tick);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}

