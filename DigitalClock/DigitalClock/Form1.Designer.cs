namespace DigitalClock
{
    partial class Form1
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
            this.HourMinuteLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WeekDayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HourMinuteLabel
            // 
            this.HourMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourMinuteLabel.ForeColor = System.Drawing.Color.White;
            this.HourMinuteLabel.Location = new System.Drawing.Point(40, 158);
            this.HourMinuteLabel.Name = "HourMinuteLabel";
            this.HourMinuteLabel.Size = new System.Drawing.Size(246, 93);
            this.HourMinuteLabel.TabIndex = 0;
            this.HourMinuteLabel.Text = "19 : 25";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.ForeColor = System.Drawing.Color.White;
            this.SecondsLabel.Location = new System.Drawing.Point(292, 158);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(246, 93);
            this.SecondsLabel.TabIndex = 1;
            this.SecondsLabel.Text = "47";
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(40, 251);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(418, 93);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Nov 11 2019";
            // 
            // WeekDayLabel
            // 
            this.WeekDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekDayLabel.ForeColor = System.Drawing.Color.White;
            this.WeekDayLabel.Location = new System.Drawing.Point(40, 344);
            this.WeekDayLabel.Name = "WeekDayLabel";
            this.WeekDayLabel.Size = new System.Drawing.Size(418, 93);
            this.WeekDayLabel.TabIndex = 4;
            this.WeekDayLabel.Text = "Wednesday";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WeekDayLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.HourMinuteLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HourMinuteLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WeekDayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

