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
            textBox1 = new TextBox();
            label3 = new Label();
            cboService = new ComboBox();
            label2 = new Label();
            panel4 = new Panel();
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
            panel1.Size = new Size(929, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(347, 2);
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
            panel2.Size = new Size(929, 119);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cboService);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(403, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(526, 119);
            panel5.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(341, 45);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(252, 43);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 2;
            label3.Text = "Remark:";
            // 
            // cboService
            // 
            cboService.Anchor = AnchorStyles.None;
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(93, 44);
            cboService.Margin = new Padding(3, 4, 3, 4);
            cboService.Name = "cboService";
            cboService.Size = new Size(153, 28);
            cboService.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 0;
            label2.Text = "Dịch vụ:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(btndelete);
            panel4.Controls.Add(btnReg);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 119);
            panel4.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(143, 36);
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
            btndelete.Location = new Point(273, 36);
            btndelete.Margin = new Padding(3, 4, 3, 4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(123, 45);
            btndelete.TabIndex = 1;
            btndelete.Text = "Xóa service";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            btnReg.Anchor = AnchorStyles.None;
            btnReg.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReg.Location = new Point(10, 36);
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
            panel3.Location = new Point(0, 175);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(929, 301);
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
            dataGridView1.Size = new Size(929, 301);
            dataGridView1.TabIndex = 0;
            // 
            // FormRegService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 476);
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
        private TextBox textBox1;
    }
}