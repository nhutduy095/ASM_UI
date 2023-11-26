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
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 27);
            label1.TabIndex = 0;
            label1.Text = "Register Servie";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 89);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cboService);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(353, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(447, 89);
            panel5.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(273, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(214, 37);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Remark:";
            // 
            // cboService
            // 
            cboService.Anchor = AnchorStyles.None;
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(61, 33);
            cboService.Name = "cboService";
            cboService.Size = new Size(134, 23);
            cboService.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(5, 37);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Dịch vụ:";
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Controls.Add(btndelete);
            panel4.Controls.Add(btnReg);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 89);
            panel4.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(125, 27);
            button3.Name = "button3";
            button3.Size = new Size(108, 34);
            button3.TabIndex = 3;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.None;
            btndelete.Location = new Point(239, 27);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(108, 34);
            btndelete.TabIndex = 1;
            btndelete.Text = "Xóa service";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            btnReg.Anchor = AnchorStyles.None;
            btnReg.Location = new Point(9, 27);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(108, 34);
            btnReg.TabIndex = 0;
            btnReg.Text = "Đăng ký dịch vụ";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 319);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 319);
            dataGridView1.TabIndex = 0;
            // 
            // FormRegService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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