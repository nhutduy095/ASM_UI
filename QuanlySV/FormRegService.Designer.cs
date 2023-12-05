namespace QuanlySV
{
    partial class FormRegService
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            cboSubject = new ComboBox();
            label6 = new Label();
            cboMajorT = new ComboBox();
            label5 = new Label();
            cboMajorF = new ComboBox();
            label4 = new Label();
            txtRemark = new TextBox();
            label3 = new Label();
            cboService = new ComboBox();
            label2 = new Label();
            panel4 = new Panel();
            btnExit = new Button();
            button3 = new Button();
            btndelete = new Button();
            btnReg = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(347, 3);
            label1.Name = "label1";
            label1.Size = new Size(274, 48);
            label1.TabIndex = 0;
            label1.Text = "Register Service";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 156);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Controls.Add(cboSubject);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(cboMajorT);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(cboMajorF);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtRemark);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cboService);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(335, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(628, 156);
            panel5.TabIndex = 1;
            // 
            // cboSubject
            // 
            cboSubject.Anchor = AnchorStyles.None;
            cboSubject.FormattingEnabled = true;
            cboSubject.Location = new Point(444, 16);
            cboSubject.Margin = new Padding(3, 4, 3, 4);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(153, 28);
            cboSubject.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(335, 13);
            label6.Name = "label6";
            label6.Size = new Size(96, 31);
            label6.TabIndex = 8;
            label6.Text = "Môn Học";
            // 
            // cboMajorT
            // 
            cboMajorT.Anchor = AnchorStyles.None;
            cboMajorT.FormattingEnabled = true;
            cboMajorT.Location = new Point(444, 55);
            cboMajorT.Margin = new Padding(3, 4, 3, 4);
            cboMajorT.Name = "cboMajorT";
            cboMajorT.Size = new Size(153, 28);
            cboMajorT.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(316, 52);
            label5.Name = "label5";
            label5.Size = new Size(123, 31);
            label5.TabIndex = 6;
            label5.Text = "Đến ngành:";
            // 
            // cboMajorF
            // 
            cboMajorF.Anchor = AnchorStyles.None;
            cboMajorF.FormattingEnabled = true;
            cboMajorF.Location = new Point(139, 55);
            cboMajorF.Margin = new Padding(3, 4, 3, 4);
            cboMajorF.Name = "cboMajorF";
            cboMajorF.Size = new Size(153, 28);
            cboMajorF.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 52);
            label4.Name = "label4";
            label4.Size = new Size(112, 31);
            label4.TabIndex = 4;
            label4.Text = "Từ Ngành:";
            // 
            // txtRemark
            // 
            txtRemark.Anchor = AnchorStyles.None;
            txtRemark.Location = new Point(139, 108);
            txtRemark.Margin = new Padding(3, 4, 3, 4);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(458, 27);
            txtRemark.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 108);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 2;
            label3.Text = "Ghi chú:";
            // 
            // cboService
            // 
            cboService.Anchor = AnchorStyles.None;
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(139, 9);
            cboService.Margin = new Padding(3, 4, 3, 4);
            cboService.Name = "cboService";
            cboService.Size = new Size(153, 28);
            cboService.TabIndex = 1;
            cboService.SelectedIndexChanged += cboService_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 7);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 0;
            label2.Text = "Dịch vụ:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.Controls.Add(btnExit);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(btndelete);
            panel4.Controls.Add(btnReg);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(335, 156);
            panel4.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(191, 94);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(18, 94);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(123, 45);
            button3.TabIndex = 3;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.None;
            btndelete.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(191, 20);
            btndelete.Margin = new Padding(3, 4, 3, 4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(123, 45);
            btndelete.TabIndex = 1;
            btndelete.Text = "Hủy";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnReg
            // 
            btnReg.Anchor = AnchorStyles.None;
            btnReg.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReg.Location = new Point(18, 20);
            btnReg.Margin = new Padding(3, 4, 3, 4);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(123, 45);
            btnReg.TabIndex = 0;
            btnReg.Text = "Đăng ký dịch vụ";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 212);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(963, 324);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(963, 324);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormRegService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 536);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegService";
            Text = "FormRegService";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btnReg;
        private Button button3;
        private Button btndelete;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox cboService;
        private Label label3;
        private TextBox txtRemark;
        private ComboBox cboMajorT;
        private Label label5;
        private ComboBox cboMajorF;
        private Label label4;
        private ComboBox cboSubject;
        private Label label6;
        private Button btnExit;
    }
}