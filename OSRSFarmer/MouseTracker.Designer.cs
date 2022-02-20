namespace OSRSFarmer
{
    partial class MouseTracker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.oakTreeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.willowTreeButton = new System.Windows.Forms.Button();
            this.YCoord = new System.Windows.Forms.Label();
            this.XCoord = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.oakTreeButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.timerLabel);
            this.panel1.Controls.Add(this.willowTreeButton);
            this.panel1.Controls.Add(this.YCoord);
            this.panel1.Controls.Add(this.XCoord);
            this.panel1.Controls.Add(this.YLabel);
            this.panel1.Controls.Add(this.XLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 203);
            this.panel1.TabIndex = 0;
            // 
            // oakTreeButton
            // 
            this.oakTreeButton.Location = new System.Drawing.Point(26, 167);
            this.oakTreeButton.Name = "oakTreeButton";
            this.oakTreeButton.Size = new System.Drawing.Size(75, 23);
            this.oakTreeButton.TabIndex = 10;
            this.oakTreeButton.Text = "Oak Tree";
            this.oakTreeButton.UseVisualStyleBackColor = true;
            this.oakTreeButton.Click += new System.EventHandler(this.oakTreeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(204, 27);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(71, 25);
            this.timerLabel.TabIndex = 8;
            this.timerLabel.Text = "00:00";
            // 
            // willowTreeButton
            // 
            this.willowTreeButton.Location = new System.Drawing.Point(26, 131);
            this.willowTreeButton.Name = "willowTreeButton";
            this.willowTreeButton.Size = new System.Drawing.Size(75, 23);
            this.willowTreeButton.TabIndex = 7;
            this.willowTreeButton.Text = "Willow Tree";
            this.willowTreeButton.UseVisualStyleBackColor = true;
            this.willowTreeButton.Click += new System.EventHandler(this.willowTreeButton_Click);
            // 
            // YCoord
            // 
            this.YCoord.AutoSize = true;
            this.YCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YCoord.Location = new System.Drawing.Point(102, 74);
            this.YCoord.Name = "YCoord";
            this.YCoord.Size = new System.Drawing.Size(64, 25);
            this.YCoord.TabIndex = 3;
            this.YCoord.Text = "0000";
            // 
            // XCoord
            // 
            this.XCoord.AutoSize = true;
            this.XCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCoord.Location = new System.Drawing.Point(102, 27);
            this.XCoord.Name = "XCoord";
            this.XCoord.Size = new System.Drawing.Size(64, 25);
            this.XCoord.TabIndex = 2;
            this.XCoord.Text = "0000";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.Location = new System.Drawing.Point(36, 74);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(28, 25);
            this.YLabel.TabIndex = 1;
            this.YLabel.Text = "Y";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(36, 27);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(27, 25);
            this.XLabel.TabIndex = 0;
            this.XLabel.Text = "X";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MouseTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 202);
            this.Controls.Add(this.panel1);
            this.Name = "MouseTracker";
            this.Text = "MouseTracker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MouseTracker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label YCoord;
        private System.Windows.Forms.Label XCoord;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Button willowTreeButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button oakTreeButton;
    }
}

