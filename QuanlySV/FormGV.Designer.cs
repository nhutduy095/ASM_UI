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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lịchDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchDạyToolStripMenuItem,
            this.bảngĐiểmToolStripMenuItem,
            this.điểmDanhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(692, 63);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lịchDạyToolStripMenuItem
            // 
            this.lịchDạyToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lịchDạyToolStripMenuItem.Name = "lịchDạyToolStripMenuItem";
            this.lịchDạyToolStripMenuItem.Size = new System.Drawing.Size(152, 53);
            this.lịchDạyToolStripMenuItem.Text = "Lịch dạy";
            // 
            // bảngĐiểmToolStripMenuItem
            // 
            this.bảngĐiểmToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bảngĐiểmToolStripMenuItem.Name = "bảngĐiểmToolStripMenuItem";
            this.bảngĐiểmToolStripMenuItem.Size = new System.Drawing.Size(185, 53);
            this.bảngĐiểmToolStripMenuItem.Text = "Bảng điểm";
            // 
            // điểmDanhToolStripMenuItem
            // 
            this.điểmDanhToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.điểmDanhToolStripMenuItem.Name = "điểmDanhToolStripMenuItem";
            this.điểmDanhToolStripMenuItem.Size = new System.Drawing.Size(188, 53);
            this.điểmDanhToolStripMenuItem.Text = "Điểm danh";
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 499);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormGV";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lịchDạyToolStripMenuItem;
        private ToolStripMenuItem bảngĐiểmToolStripMenuItem;
        private ToolStripMenuItem điểmDanhToolStripMenuItem;
    }
}