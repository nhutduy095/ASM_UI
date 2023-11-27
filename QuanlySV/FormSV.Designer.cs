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
            button10 = new Button();
            menuStrip1 = new MenuStrip();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            PointToolStripMenuItem = new ToolStripMenuItem();
            regServiceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button10
            // 
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(819, 1);
            button10.Name = "button10";
            button10.Size = new Size(70, 60);
            button10.TabIndex = 29;
            button10.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Sitka Banner", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { scheduleToolStripMenuItem, PointToolStripMenuItem, regServiceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(889, 59);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(155, 53);
            scheduleToolStripMenuItem.Text = "Lịch Học";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // PointToolStripMenuItem
            // 
            PointToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            PointToolStripMenuItem.Name = "PointToolStripMenuItem";
            PointToolStripMenuItem.Size = new Size(109, 53);
            PointToolStripMenuItem.Text = "Điểm";
            PointToolStripMenuItem.Click += PointToolStripMenuItem_Click;
            // 
            // regServiceToolStripMenuItem
            // 
            regServiceToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            regServiceToolStripMenuItem.Name = "regServiceToolStripMenuItem";
            regServiceToolStripMenuItem.Size = new Size(268, 53);
            regServiceToolStripMenuItem.Text = "Đăng Ký Dịch Vụ";
            regServiceToolStripMenuItem.Click += regServiceToolStripMenuItem_Click;
            // 
            // FormSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 605);
            Controls.Add(button10);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "FormSV";
            Text = "Form4";
            Load += FormSV_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button10;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem PointToolStripMenuItem;
        private ToolStripMenuItem regServiceToolStripMenuItem;
    }
}