namespace QuanlySV
{
    partial class NhapDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapDiem));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPointBaove = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtPointASM = new TextBox();
            txtPointChuyenCan = new TextBox();
            cboSeason = new ComboBox();
            cboSubject = new ComboBox();
            textBox2 = new TextBox();
            txtUserId = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDel = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mistral", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(469, 23);
            label1.Name = "label1";
            label1.Size = new Size(385, 56);
            label1.TabIndex = 0;
            label1.Text = "Nhập Điểm Sinh Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPointBaove);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtPointASM);
            groupBox1.Controls.Add(txtPointChuyenCan);
            groupBox1.Controls.Add(cboSeason);
            groupBox1.Controls.Add(cboSubject);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(txtUserId);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(976, 191);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // txtPointBaove
            // 
            txtPointBaove.Location = new Point(685, 140);
            txtPointBaove.Name = "txtPointBaove";
            txtPointBaove.Size = new Size(133, 27);
            txtPointBaove.TabIndex = 6;
            txtPointBaove.Text = "0";
            txtPointBaove.TextChanged += textBox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(536, 143);
            label13.Name = "label13";
            label13.Size = new Size(153, 24);
            label13.TabIndex = 5;
            label13.Text = "Điểm Bảo Vệ/Thi\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(865, 100);
            label12.Name = "label12";
            label12.Size = new Size(18, 19);
            label12.TabIndex = 4;
            label12.Text = "0";
            // 
            // txtPointASM
            // 
            txtPointASM.Location = new Point(685, 92);
            txtPointASM.Name = "txtPointASM";
            txtPointASM.Size = new Size(133, 27);
            txtPointASM.TabIndex = 3;
            txtPointASM.Text = "0";
            txtPointASM.TextChanged += textBox_TextChanged;
            // 
            // txtPointChuyenCan
            // 
            txtPointChuyenCan.Location = new Point(687, 47);
            txtPointChuyenCan.Name = "txtPointChuyenCan";
            txtPointChuyenCan.Size = new Size(133, 27);
            txtPointChuyenCan.TabIndex = 3;
            txtPointChuyenCan.Text = "0";
            txtPointChuyenCan.TextChanged += textBox_TextChanged;
            // 
            // cboSeason
            // 
            cboSeason.FormattingEnabled = true;
            cboSeason.Location = new Point(375, 41);
            cboSeason.Name = "cboSeason";
            cboSeason.Size = new Size(149, 27);
            cboSeason.TabIndex = 2;
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Location = new Point(129, 139);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(149, 27);
            cboSubject.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 85);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 33);
            textBox2.TabIndex = 1;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(129, 36);
            txtUserId.Multiline = true;
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(149, 33);
            txtUserId.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(827, 48);
            label11.Name = "label11";
            label11.Size = new Size(151, 24);
            label11.TabIndex = 0;
            label11.Text = "Điểm Trung Bình";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(536, 96);
            label10.Name = "label10";
            label10.Size = new Size(100, 24);
            label10.TabIndex = 0;
            label10.Text = "Điểm ASM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(538, 45);
            label9.Name = "label9";
            label9.Size = new Size(148, 24);
            label9.TabIndex = 0;
            label9.Text = "Điểm Chuyên Cần";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(299, 43);
            label5.Name = "label5";
            label5.Size = new Size(75, 24);
            label5.TabIndex = 0;
            label5.Text = "Học Kỳ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 143);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 0;
            label4.Text = "Môn Học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 91);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 0;
            label3.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 41);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 0;
            label2.Text = "Mã Sinh Viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(995, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 291);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm sinh viên";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnSearch.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(26, 168);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 57);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(8, 123);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(196, 33);
            txtSearch.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 85);
            label8.Name = "label8";
            label8.Size = new Size(175, 24);
            label8.TabIndex = 9;
            label8.Text = "Nhập Mã Sinh Viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDel);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(14, 268);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(976, 99);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(839, 36);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 37);
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
            btnClear.Location = new Point(680, 36);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 37);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(255, 192, 192);
            btnDel.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(361, 36);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(109, 37);
            btnDel.TabIndex = 0;
            btnDel.Text = "Delete";
            btnDel.TextAlign = ContentAlignment.MiddleRight;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(523, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 37);
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
            btnUpdate.Location = new Point(187, 36);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 37);
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
            btnAdd.Location = new Point(43, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 37);
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
            dataGridView1.Location = new Point(0, 394);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1211, 373);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // NhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1211, 767);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "NhapDiem";
            Text = "NhapDiem";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox txtUserId;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboSeason;
        private ComboBox cboSubject;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label8;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnClear;
        private Button btnDel;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Label label12;
        private TextBox txtPointASM;
        private TextBox txtPointChuyenCan;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtPointBaove;
        private Label label13;
    }
}