namespace QuanlySV
{
    partial class FormSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSV));
            this.button10 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lịchHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(819, 1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 60);
            this.button10.TabIndex = 29;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchHọcToolStripMenuItem,
            this.điểmToolStripMenuItem,
            this.đăngKýDịchVụToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(889, 59);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lịchHọcToolStripMenuItem
            // 
            this.lịchHọcToolStripMenuItem.Name = "lịchHọcToolStripMenuItem";
            this.lịchHọcToolStripMenuItem.Size = new System.Drawing.Size(156, 53);
            this.lịchHọcToolStripMenuItem.Text = "Lịch Học";
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(109, 53);
            this.điểmToolStripMenuItem.Text = "Điểm";
            // 
            // đăngKýDịchVụToolStripMenuItem
            // 
            this.đăngKýDịchVụToolStripMenuItem.Name = "đăngKýDịchVụToolStripMenuItem";
            this.đăngKýDịchVụToolStripMenuItem.Size = new System.Drawing.Size(269, 53);
            this.đăngKýDịchVụToolStripMenuItem.Text = "Đăng Ký Dịch Vụ";
            // 
            // FormSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(889, 605);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSV";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormSV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button10;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lịchHọcToolStripMenuItem;
        private ToolStripMenuItem điểmToolStripMenuItem;
        private ToolStripMenuItem đăngKýDịchVụToolStripMenuItem;
    }
}