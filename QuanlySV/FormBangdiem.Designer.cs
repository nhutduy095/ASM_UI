namespace QuanlySV
{
    partial class FormBangdiem
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
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            label4 = new Label();
            label6 = new Label();
            label24 = new Label();
            txtSearch = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            lblfail = new Label();
            lblpass = new Label();
            lblnotyet = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            lblstuding = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCredit = new Label();
            lblpointavgMst = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Image = Properties.Resources.pngtree_vector_question_mark_icon_png_image_5154481;
            linkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel1.Location = new Point(12, 15);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 15);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "       Hệ quản lý đào tạo";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(770, 70);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(59, 25);
            button3.TabIndex = 34;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(27, 70);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 35;
            label4.Text = "Tín chỉ: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(27, 46);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 36;
            label6.Text = "Điểm trung bình:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.Blue;
            label24.Location = new Point(339, 7);
            label24.Name = "label24";
            label24.Size = new Size(129, 32);
            label24.TabIndex = 48;
            label24.Text = "Bảng điểm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(623, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(141, 23);
            txtSearch.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 39);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 271);
            panel2.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(869, 271);
            dataGridView1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(44, 93);
            label8.Name = "label8";
            label8.Size = new Size(104, 30);
            label8.TabIndex = 44;
            label8.Text = "Thống kê";
            // 
            // lblfail
            // 
            lblfail.AutoSize = true;
            lblfail.Location = new Point(403, 27);
            lblfail.Name = "lblfail";
            lblfail.Size = new Size(13, 15);
            lblfail.TabIndex = 6;
            lblfail.Text = "1";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(203, 27);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(13, 15);
            lblpass.TabIndex = 5;
            lblpass.Text = "7";
            // 
            // lblnotyet
            // 
            lblnotyet.AutoSize = true;
            lblnotyet.Location = new Point(3, 27);
            lblnotyet.Name = "lblnotyet";
            lblnotyet.Size = new Size(19, 15);
            lblnotyet.TabIndex = 4;
            lblnotyet.Text = "36";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(114, 15);
            label13.TabIndex = 0;
            label13.Text = "Tổng môn chưa học";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(203, 0);
            label14.Name = "label14";
            label14.Size = new Size(82, 15);
            label14.TabIndex = 1;
            label14.Text = "Tổng môn đạt";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(403, 0);
            label15.Name = "label15";
            label15.Size = new Size(100, 15);
            label15.TabIndex = 2;
            label15.Text = "Tổng môn học lại";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(603, 0);
            label16.Name = "label16";
            label16.Size = new Size(115, 15);
            label16.TabIndex = 3;
            label16.Text = "Tổng môn đang học";
            // 
            // lblstuding
            // 
            lblstuding.AutoSize = true;
            lblstuding.Location = new Point(603, 27);
            lblstuding.Name = "lblstuding";
            lblstuding.Size = new Size(13, 15);
            lblstuding.TabIndex = 7;
            lblstuding.Text = "3";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblstuding, 3, 1);
            tableLayoutPanel1.Controls.Add(label16, 3, 0);
            tableLayoutPanel1.Controls.Add(label15, 2, 0);
            tableLayoutPanel1.Controls.Add(label14, 1, 0);
            tableLayoutPanel1.Controls.Add(label13, 0, 0);
            tableLayoutPanel1.Controls.Add(lblnotyet, 0, 1);
            tableLayoutPanel1.Controls.Add(lblpass, 1, 1);
            tableLayoutPanel1.Controls.Add(lblfail, 2, 1);
            tableLayoutPanel1.Location = new Point(27, 137);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(802, 55);
            tableLayoutPanel1.TabIndex = 45;
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCredit.ImageAlign = ContentAlignment.MiddleLeft;
            lblCredit.Location = new Point(94, 71);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(282, 25);
            lblCredit.TabIndex = 52;
            lblCredit.Text = "60 / 97(Đạt/Tổng) - 0 miễn giảm";
            // 
            // lblpointavgMst
            // 
            lblpointavgMst.AutoSize = true;
            lblpointavgMst.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblpointavgMst.ImageAlign = ContentAlignment.MiddleLeft;
            lblpointavgMst.Location = new Point(187, 46);
            lblpointavgMst.Name = "lblpointavgMst";
            lblpointavgMst.Size = new Size(46, 25);
            lblpointavgMst.TabIndex = 53;
            lblpointavgMst.Text = "9.64";
            // 
            // FormBangdiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(869, 507);
            Controls.Add(lblpointavgMst);
            Controls.Add(lblCredit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(label24);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBangdiem";
            Text = "FormBangdiem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private Button button3;
        private Label label4;
        private Label label6;
        private Label label24;
        private TextBox txtSearch;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label8;
        private Label lblfail;
        private Label lblpass;
        private Label lblnotyet;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lblstuding;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCredit;
        private Label lblpointavgMst;
    }
}