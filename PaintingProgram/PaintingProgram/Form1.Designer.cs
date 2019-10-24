namespace PaintingProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.redBtn = new System.Windows.Forms.ToolStripButton();
            this.blueBtn = new System.Windows.Forms.ToolStripButton();
            this.greenBtn = new System.Windows.Forms.ToolStripButton();
            this.purpleBtn = new System.Windows.Forms.ToolStripButton();
            this.limeBtn = new System.Windows.Forms.ToolStripButton();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save Image As";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redBtn,
            this.blueBtn,
            this.greenBtn,
            this.purpleBtn,
            this.limeBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // redBtn
            // 
            this.redBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.redBtn.ForeColor = System.Drawing.Color.Red;
            this.redBtn.Image = ((System.Drawing.Image)(resources.GetObject("redBtn.Image")));
            this.redBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(31, 22);
            this.redBtn.Text = "Red";
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blueBtn.ForeColor = System.Drawing.Color.Blue;
            this.blueBtn.Image = ((System.Drawing.Image)(resources.GetObject("blueBtn.Image")));
            this.blueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(34, 22);
            this.blueBtn.Text = "Blue";
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.greenBtn.ForeColor = System.Drawing.Color.Green;
            this.greenBtn.Image = ((System.Drawing.Image)(resources.GetObject("greenBtn.Image")));
            this.greenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(42, 22);
            this.greenBtn.Text = "Green";
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // purpleBtn
            // 
            this.purpleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.purpleBtn.ForeColor = System.Drawing.Color.Purple;
            this.purpleBtn.Image = ((System.Drawing.Image)(resources.GetObject("purpleBtn.Image")));
            this.purpleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.purpleBtn.Name = "purpleBtn";
            this.purpleBtn.Size = new System.Drawing.Size(45, 22);
            this.purpleBtn.Text = "Purple";
            this.purpleBtn.Click += new System.EventHandler(this.purpleBtn_Click);
            // 
            // limeBtn
            // 
            this.limeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.limeBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.limeBtn.Image = ((System.Drawing.Image)(resources.GetObject("limeBtn.Image")));
            this.limeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limeBtn.Name = "limeBtn";
            this.limeBtn.Size = new System.Drawing.Size(37, 22);
            this.limeBtn.Text = "Lime";
            this.limeBtn.Click += new System.EventHandler(this.limeBtn_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Black;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 49);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(800, 401);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "My Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton redBtn;
        private System.Windows.Forms.ToolStripButton blueBtn;
        private System.Windows.Forms.ToolStripButton greenBtn;
        private System.Windows.Forms.ToolStripButton purpleBtn;
        private System.Windows.Forms.ToolStripButton limeBtn;
        private System.Windows.Forms.PictureBox Canvas;
    }
}

