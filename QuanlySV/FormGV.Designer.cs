namespace QuanlySV
{
    partial class FormGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGV));
            menuStrip1 = new MenuStrip();
            lịchDạyToolStripMenuItem = new ToolStripMenuItem();
            bảngĐiểmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { lịchDạyToolStripMenuItem, bảngĐiểmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(13, 5, 0, 5);
            menuStrip1.Size = new Size(1081, 62);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lịchDạyToolStripMenuItem
            // 
            lịchDạyToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            lịchDạyToolStripMenuItem.Font = new Font("Sitka Banner", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lịchDạyToolStripMenuItem.Name = "lịchDạyToolStripMenuItem";
            lịchDạyToolStripMenuItem.Size = new Size(146, 52);
            lịchDạyToolStripMenuItem.Text = "Lịch dạy";
            lịchDạyToolStripMenuItem.Click += lịchDạyToolStripMenuItem_Click;
            // 
            // bảngĐiểmToolStripMenuItem
            // 
            bảngĐiểmToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            bảngĐiểmToolStripMenuItem.Font = new Font("Sitka Banner", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            bảngĐiểmToolStripMenuItem.Name = "bảngĐiểmToolStripMenuItem";
            bảngĐiểmToolStripMenuItem.Size = new Size(225, 52);
            bảngĐiểmToolStripMenuItem.Text = "Quản Lý Điểm";
            bảngĐiểmToolStripMenuItem.Click += bảngĐiểmToolStripMenuItem_Click;
            // 
            // FormGV
            // 
            AutoScaleDimensions = new SizeF(17F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1081, 682);
            Controls.Add(menuStrip1);
            Font = new Font("Sitka Banner", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "FormGV";
            Text = "FormGV";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lịchDạyToolStripMenuItem;
        private ToolStripMenuItem bảngĐiểmToolStripMenuItem;
    }
}