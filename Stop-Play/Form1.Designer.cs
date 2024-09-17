namespace Stop_Play
{
    partial class Form1
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
        private void InitializeComponent()
        {
            btnStop = new Button();
            btnPause = new Button();
            btnStart = new Button();
            lblNumber = new Label();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.IndianRed;
            btnStop.Location = new Point(542, 197);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(126, 57);
            btnStop.TabIndex = 0;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click_1;
            // 
            // btnPause
            // 
            btnPause.BackColor = SystemColors.ActiveCaption;
            btnPause.Location = new Point(337, 197);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(126, 57);
            btnPause.TabIndex = 1;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click_1;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LawnGreen;
            btnStart.Location = new Point(134, 197);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(126, 57);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click_1;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Gold;
            lblNumber.BorderStyle = BorderStyle.FixedSingle;
            lblNumber.Location = new Point(354, 93);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(96, 17);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "вывод счетчика";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumber);
            Controls.Add(btnStart);
            Controls.Add(btnPause);
            Controls.Add(btnStop);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStop;
        private Button btnPause;
        private Button btnStart;
        private Label lblNumber;
    }
}
