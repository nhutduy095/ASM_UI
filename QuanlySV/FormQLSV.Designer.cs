namespace QuanlySV
{
    partial class FormQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSV));
            menuStrip1 = new MenuStrip();
            studentManageToolStripMenuItem = new ToolStripMenuItem();
            danhSáchSinhViênToolStripMenuItem = new ToolStripMenuItem();
            danhSáchLớpToolStripMenuItem = new ToolStripMenuItem();
            điểmTrungBìnhSinhViênToolStripMenuItem = new ToolStripMenuItem();
            serviceManageToolStripMenuItem = new ToolStripMenuItem();
            dịchVụSinhViênĐăngKýToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentManageToolStripMenuItem, serviceManageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentManageToolStripMenuItem
            // 
            studentManageToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            studentManageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchSinhViênToolStripMenuItem, danhSáchLớpToolStripMenuItem, điểmTrungBìnhSinhViênToolStripMenuItem });
            studentManageToolStripMenuItem.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            studentManageToolStripMenuItem.Name = "studentManageToolStripMenuItem";
            studentManageToolStripMenuItem.Size = new Size(296, 52);
            studentManageToolStripMenuItem.Text = " Manage System";
            // 
            // danhSáchSinhViênToolStripMenuItem
            // 
            danhSáchSinhViênToolStripMenuItem.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
            danhSáchSinhViênToolStripMenuItem.Size = new Size(485, 54);
            danhSáchSinhViênToolStripMenuItem.Text = "Danh Sách Sinh Viên";
            // 
            // danhSáchLớpToolStripMenuItem
            // 
            danhSáchLớpToolStripMenuItem.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            danhSáchLớpToolStripMenuItem.Name = "danhSáchLớpToolStripMenuItem";
            danhSáchLớpToolStripMenuItem.Size = new Size(485, 54);
            danhSáchLớpToolStripMenuItem.Text = "Danh Sách Môn Học";
            // 
            // điểmTrungBìnhSinhViênToolStripMenuItem
            // 
            điểmTrungBìnhSinhViênToolStripMenuItem.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            điểmTrungBìnhSinhViênToolStripMenuItem.Name = "điểmTrungBìnhSinhViênToolStripMenuItem";
            điểmTrungBìnhSinhViênToolStripMenuItem.Size = new Size(485, 54);
            điểmTrungBìnhSinhViênToolStripMenuItem.Text = "Danh Sách Điểm Sinh Viên";
            // 
            // serviceManageToolStripMenuItem
            // 
            serviceManageToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            serviceManageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dịchVụSinhViênĐăngKýToolStripMenuItem });
            serviceManageToolStripMenuItem.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            serviceManageToolStripMenuItem.Name = "serviceManageToolStripMenuItem";
            serviceManageToolStripMenuItem.Size = new Size(291, 52);
            serviceManageToolStripMenuItem.Text = "Service Manage";
            // 
            // dịchVụSinhViênĐăngKýToolStripMenuItem
            // 
            dịchVụSinhViênĐăngKýToolStripMenuItem.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            dịchVụSinhViênĐăngKýToolStripMenuItem.Name = "dịchVụSinhViênĐăngKýToolStripMenuItem";
            dịchVụSinhViênĐăngKýToolStripMenuItem.Size = new Size(489, 54);
            dịchVụSinhViênĐăngKýToolStripMenuItem.Text = "Dịch Vụ Sinh Viên Đăng Ký";
            // 
            // FormQLSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1428, 772);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormQLSV";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentManageToolStripMenuItem;
        private ToolStripMenuItem serviceManageToolStripMenuItem;
        private ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private ToolStripMenuItem danhSáchLớpToolStripMenuItem;
        private ToolStripMenuItem điểmTrungBìnhSinhViênToolStripMenuItem;
        private ToolStripMenuItem dịchVụSinhViênĐăngKýToolStripMenuItem;
    }
}