namespace QuanlySV
{
    partial class Student_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Manage));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label8 = new Label();
            txtUId = new TextBox();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label9 = new Label();
            txtFirstName = new TextBox();
            txtUserId = new TextBox();
            txtClass = new TextBox();
            txtAdress = new TextBox();
            cboMajor = new ComboBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            dtpBirth = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtSDTPH = new TextBox();
            txtSdt = new TextBox();
            txtMail = new TextBox();
            txtLastName = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 449);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1404, 280);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(553, 16);
            label1.Name = "label1";
            label1.Size = new Size(326, 48);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Sinh Viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(41, 48);
            label8.Name = "label8";
            label8.Size = new Size(172, 23);
            label8.TabIndex = 9;
            label8.Text = "Nhập Mã Sinh Viên";
            // 
            // txtUId
            // 
            txtUId.Location = new Point(30, 84);
            txtUId.Multiline = true;
            txtUId.Name = "txtUId";
            txtUId.Size = new Size(196, 34);
            txtUId.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(53, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 41);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtUId);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1121, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 204);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm sinh viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(952, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 190);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 36);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 11;
            label2.Text = "Họ Sinh Viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(450, 76);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 10;
            label5.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 152);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 9;
            label3.Text = "Mã Sinh Viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(450, 124);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 8;
            label6.Text = "Giới Tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(450, 168);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 7;
            label7.Text = "Quê Quán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 209);
            label4.Name = "label4";
            label4.Size = new Size(41, 23);
            label4.TabIndex = 6;
            label4.Text = "Lớp";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(450, 29);
            label9.Name = "label9";
            label9.Size = new Size(64, 23);
            label9.TabIndex = 6;
            label9.Text = "Ngành";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(143, 22);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 34);
            txtFirstName.TabIndex = 15;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(143, 141);
            txtUserId.Multiline = true;
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(250, 34);
            txtUserId.TabIndex = 14;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(143, 196);
            txtClass.Multiline = true;
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(250, 34);
            txtClass.TabIndex = 13;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(604, 152);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(259, 39);
            txtAdress.TabIndex = 12;
            // 
            // cboMajor
            // 
            cboMajor.FormattingEnabled = true;
            cboMajor.Location = new Point(604, 25);
            cboMajor.Name = "cboMajor";
            cboMajor.Size = new Size(259, 27);
            cboMajor.TabIndex = 16;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdMale.Location = new Point(604, 116);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(69, 27);
            rdMale.TabIndex = 18;
            rdMale.TabStop = true;
            rdMale.Text = "Nam";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdFemale.Location = new Point(759, 116);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(54, 27);
            rdFemale.TabIndex = 17;
            rdFemale.TabStop = true;
            rdFemale.Text = "Nữ";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(604, 76);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(259, 27);
            dtpBirth.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(dtpBirth);
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Controls.Add(cboMajor);
            groupBox1.Controls.Add(txtAdress);
            groupBox1.Controls.Add(txtSDTPH);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtClass);
            groupBox1.Controls.Add(txtUserId);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 303);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // txtSDTPH
            // 
            txtSDTPH.Location = new Point(604, 255);
            txtSDTPH.Multiline = true;
            txtSDTPH.Name = "txtSDTPH";
            txtSDTPH.Size = new Size(259, 34);
            txtSDTPH.TabIndex = 13;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(143, 255);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(250, 34);
            txtSdt.TabIndex = 13;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(604, 207);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(259, 34);
            txtMail.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(143, 79);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 34);
            txtLastName.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(450, 269);
            label12.Name = "label12";
            label12.Size = new Size(143, 23);
            label12.TabIndex = 6;
            label12.Text = "SĐT Phụ Huynh";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(450, 218);
            label13.Name = "label13";
            label13.Size = new Size(57, 23);
            label13.TabIndex = 6;
            label13.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(8, 268);
            label11.Name = "label11";
            label11.Size = new Size(128, 23);
            label11.TabIndex = 6;
            label11.Text = "Số Điện Thoại";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(8, 93);
            label10.Name = "label10";
            label10.Size = new Size(126, 23);
            label10.TabIndex = 11;
            label10.Text = "Tên Sinh Viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(32, 363);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(889, 80);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(769, 30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 38);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(620, 30);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 38);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(323, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 38);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(478, 30);
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
            btnUpdate.Location = new Point(159, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 38);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(27, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // Student_Manage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1404, 729);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Student_Manage";
            Text = "Student_Manage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private Label label8;
        private TextBox txtUId;
        private Button btnSearch;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label9;
        private TextBox txtFirstName;
        private TextBox txtUserId;
        private TextBox txtClass;
        private TextBox txtAdress;
        private ComboBox cboMajor;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private DateTimePicker dtpBirth;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtLastName;
        private Label label10;
        private TextBox txtSDTPH;
        private TextBox txtSdt;
        private Label label12;
        private Label label11;
        private TextBox txtMail;
        private Label label13;
    }
}