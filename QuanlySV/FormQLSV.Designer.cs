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
            tsManageSys = new ToolStripMenuItem();
            tsLstStudents = new ToolStripMenuItem();
            tsLstSubjects = new ToolStripMenuItem();
            tsServiceManage = new ToolStripMenuItem();
            tsLstService = new ToolStripMenuItem();
            tsServiceConfirm = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsManageSys, tsServiceManage });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsManageSys
            // 
            tsManageSys.BackColor = Color.FromArgb(255, 128, 0);
            tsManageSys.DropDownItems.AddRange(new ToolStripItem[] { tsLstStudents, tsLstSubjects });
            tsManageSys.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tsManageSys.Name = "tsManageSys";
            tsManageSys.Size = new Size(296, 52);
            tsManageSys.Text = " Manage System";
            // 
            // tsLstStudents
            // 
            tsLstStudents.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tsLstStudents.Name = "tsLstStudents";
            tsLstStudents.Size = new Size(404, 54);
            tsLstStudents.Text = "Danh Sách Sinh Viên";
            // 
            // tsLstSubjects
            // 
            tsLstSubjects.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tsLstSubjects.Name = "tsLstSubjects";
            tsLstSubjects.Size = new Size(404, 54);
            tsLstSubjects.Text = "Danh Sách Môn Học";
            // 
            // tsServiceManage
            // 
            tsServiceManage.BackColor = Color.FromArgb(255, 128, 0);
            tsServiceManage.DropDownItems.AddRange(new ToolStripItem[] { tsLstService, tsServiceConfirm });
            tsServiceManage.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tsServiceManage.Name = "tsServiceManage";
            tsServiceManage.Size = new Size(291, 52);
            tsServiceManage.Text = "Service Manage";
            // 
            // tsLstService
            // 
            tsLstService.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tsLstService.Name = "tsLstService";
            tsLstService.Size = new Size(401, 54);
            tsLstService.Text = "Quản Lý Các Dịch Vụ";
            // 
            // tsServiceConfirm
            // 
            tsServiceConfirm.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tsServiceConfirm.Name = "tsServiceConfirm";
            tsServiceConfirm.Size = new Size(401, 54);
            tsServiceConfirm.Text = "Xác Nhận Dịch Vụ";
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
        private ToolStripMenuItem tsManageSys;
        private ToolStripMenuItem tsServiceManage;
        private ToolStripMenuItem tsLstStudents;
        private ToolStripMenuItem tsLstSubjects;
        private ToolStripMenuItem tsLstService;
        private ToolStripMenuItem tsServiceConfirm;
    }
}