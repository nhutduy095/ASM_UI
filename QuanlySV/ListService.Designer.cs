namespace QuanlySV
{
    partial class ListService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListService));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSName = new TextBox();
            txtSId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtServiceId = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(269, -3);
            label1.Name = "label1";
            label1.Size = new Size(377, 48);
            label1.TabIndex = 2;
            label1.Text = "Quản Lý Các Dịch Vụ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSName);
            groupBox1.Controls.Add(txtSId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(34, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 97);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // txtSName
            // 
            txtSName.Location = new Point(552, 36);
            txtSName.Multiline = true;
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(296, 34);
            txtSName.TabIndex = 2;
            // 
            // txtSId
            // 
            txtSId.Location = new Point(129, 36);
            txtSId.Multiline = true;
            txtSId.Name = "txtSId";
            txtSId.Size = new Size(229, 34);
            txtSId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(436, 46);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 0;
            label3.Text = "Tên Dịch Vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 46);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 0;
            label2.Text = "Mã Dịch Vụ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(34, 253);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(860, 99);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(754, 36);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 38);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(607, 36);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 38);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(313, 36);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 38);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(468, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 192);
            btnUpdate.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(146, 36);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 38);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(9, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(920, 208);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtServiceId);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(34, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(860, 97);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm dịch vụ";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(599, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 41);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtServiceId
            // 
            txtServiceId.Location = new Point(347, 31);
            txtServiceId.Multiline = true;
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new Size(235, 34);
            txtServiceId.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(145, 42);
            label8.Name = "label8";
            label8.Size = new Size(157, 23);
            label8.TabIndex = 9;
            label8.Text = "Nhập Mã Dịch Vụ";
            // 
            // ListService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(920, 578);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ListService";
            Text = "ListService";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSName;
        private TextBox txtSId;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtServiceId;
        private Label label8;
    }
}