namespace QuanlySV
{
    partial class MonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTinchi = new TextBox();
            txtSubjectName = new TextBox();
            txtSubjectId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtSId = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(257, 7);
            label1.Name = "label1";
            label1.Size = new Size(335, 48);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Môn Học";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTinchi);
            groupBox1.Controls.Add(txtSubjectName);
            groupBox1.Controls.Add(txtSubjectId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 94);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin môn học";
            // 
            // txtTinchi
            // 
            txtTinchi.Location = new Point(751, 38);
            txtTinchi.Multiline = true;
            txtTinchi.Name = "txtTinchi";
            txtTinchi.Size = new Size(149, 34);
            txtTinchi.TabIndex = 1;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(452, 38);
            txtSubjectName.Multiline = true;
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(173, 34);
            txtSubjectName.TabIndex = 1;
            // 
            // txtSubjectId
            // 
            txtSubjectId.Location = new Point(129, 38);
            txtSubjectId.Multiline = true;
            txtSubjectId.Name = "txtSubjectId";
            txtSubjectId.Size = new Size(173, 34);
            txtSubjectId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(646, 45);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 0;
            label4.Text = "Số Tín Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(325, 43);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên Môn Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 43);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Môn Học";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(931, 174);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(10, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(909, 89);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(806, 30);
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
            btnClear.Location = new Point(647, 30);
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
            btnDelete.Location = new Point(328, 30);
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
            btnSave.Location = new Point(491, 30);
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
            btnUpdate.Location = new Point(155, 30);
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
            btnAdd.Location = new Point(10, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSId);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(10, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(909, 97);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm môn học";
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
            // txtSId
            // 
            txtSId.Location = new Point(347, 31);
            txtSId.Multiline = true;
            txtSId.Name = "txtSId";
            txtSId.Size = new Size(235, 34);
            txtSId.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(145, 42);
            label8.Name = "label8";
            label8.Size = new Size(171, 23);
            label8.TabIndex = 9;
            label8.Text = "Nhập Mã Môn Học";
            // 
            // MonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(931, 511);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MonHoc";
            Text = "MonHoc";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtSubjectName;
        private TextBox txtSubjectId;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtSId;
        private Label label8;
        private TextBox txtTinchi;
    }
}