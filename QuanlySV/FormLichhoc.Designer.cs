namespace QuanlySV
{
    partial class FormLichhoc
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label18 = new Label();
            panel1 = new Panel();
            btnsearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            btnPre = new Button();
            btnNext = new Button();
            panel3 = new Panel();
            daycontainer = new FlowLayoutPanel();
            panel5 = new Panel();
            panel7 = new Panel();
            saturday = new Label();
            friday = new Label();
            thursday = new Label();
            Wednesday = new Label();
            tuesday = new Label();
            monday = new Label();
            sunday = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = Properties.Resources.tk;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(108, 43);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 25;
            label1.Text = "         Kỳ học :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(313, 43);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(311, 23);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "Fall 2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = Properties.Resources.th__1_;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(108, 86);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 28;
            label2.Text = "         Thời gian :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Image = Properties.Resources.pngtree_vector_question_mark_icon_png_image_5154481;
            linkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel1.Location = new Point(12, 25);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 15);
            linkLabel1.TabIndex = 32;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "       Hệ quản lý đào tạo";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Blue;
            label18.Location = new Point(351, 9);
            label18.Name = "label18";
            label18.Size = new Size(102, 32);
            label18.TabIndex = 33;
            label18.Text = "Lịch học";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 131);
            panel1.TabIndex = 34;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(662, 43);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(96, 66);
            btnsearch.TabIndex = 35;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(313, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(311, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPre);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(linkLabel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 791);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 54);
            panel2.TabIndex = 35;
            // 
            // btnPre
            // 
            btnPre.Location = new Point(799, 15);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(75, 23);
            btnPre.TabIndex = 34;
            btnPre.Text = "Previous";
            btnPre.UseVisualStyleBackColor = true;
            btnPre.Click += btnPre_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(880, 15);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 33;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(daycontainer);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(1063, 660);
            panel3.TabIndex = 36;
            // 
            // daycontainer
            // 
            daycontainer.Dock = DockStyle.Fill;
            daycontainer.Location = new Point(0, 60);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1063, 600);
            daycontainer.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(saturday);
            panel5.Controls.Add(friday);
            panel5.Controls.Add(thursday);
            panel5.Controls.Add(Wednesday);
            panel5.Controls.Add(tuesday);
            panel5.Controls.Add(monday);
            panel5.Controls.Add(sunday);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1063, 60);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Location = new Point(142, 60);
            panel7.Name = "panel7";
            panel7.Size = new Size(133, 93);
            panel7.TabIndex = 1;
            // 
            // saturday
            // 
            saturday.AutoSize = true;
            saturday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saturday.ForeColor = SystemColors.ActiveCaptionText;
            saturday.Location = new Point(873, 20);
            saturday.Name = "saturday";
            saturday.Size = new Size(82, 23);
            saturday.TabIndex = 6;
            saturday.Text = "Saturday";
            // 
            // friday
            // 
            friday.AutoSize = true;
            friday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            friday.ForeColor = SystemColors.ActiveCaptionText;
            friday.Location = new Point(757, 20);
            friday.Name = "friday";
            friday.Size = new Size(63, 23);
            friday.TabIndex = 5;
            friday.Text = "Friday";
            // 
            // thursday
            // 
            thursday.AutoSize = true;
            thursday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            thursday.ForeColor = SystemColors.ActiveCaptionText;
            thursday.Location = new Point(582, 20);
            thursday.Name = "thursday";
            thursday.Size = new Size(86, 23);
            thursday.TabIndex = 4;
            thursday.Text = "Thursday";
            // 
            // Wednesday
            // 
            Wednesday.AutoSize = true;
            Wednesday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Wednesday.ForeColor = SystemColors.ActiveCaptionText;
            Wednesday.Location = new Point(439, 20);
            Wednesday.Name = "Wednesday";
            Wednesday.Size = new Size(101, 23);
            Wednesday.TabIndex = 3;
            Wednesday.Text = "Wednesday";
            // 
            // tuesday
            // 
            tuesday.AutoSize = true;
            tuesday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tuesday.ForeColor = SystemColors.ActiveCaptionText;
            tuesday.Location = new Point(313, 20);
            tuesday.Name = "tuesday";
            tuesday.Size = new Size(77, 23);
            tuesday.TabIndex = 2;
            tuesday.Text = "Tuesday";
            // 
            // monday
            // 
            monday.AutoSize = true;
            monday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            monday.ForeColor = SystemColors.ActiveCaptionText;
            monday.Location = new Point(165, 20);
            monday.Name = "monday";
            monday.Size = new Size(77, 23);
            monday.TabIndex = 1;
            monday.Text = "Monday";
            // 
            // sunday
            // 
            sunday.AutoSize = true;
            sunday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sunday.ForeColor = SystemColors.ActiveCaptionText;
            sunday.Location = new Point(27, 20);
            sunday.Name = "sunday";
            sunday.Size = new Size(70, 23);
            sunday.TabIndex = 0;
            sunday.Text = "Sunday";
            // 
            // FormLichhoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1063, 845);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLichhoc";
            Text = "QUẢN LÝ SINH VIÊN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label18;
        private Panel panel1;
        private Button btnsearch;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label Wednesday;
        private Label tuesday;
        private Label monday;
        private Label sunday;
        private Label saturday;
        private Label friday;
        private Label thursday;
        private Panel panel7;
        private FlowLayoutPanel daycontainer;
        private Button btnPre;
        private Button btnNext;
    }
}