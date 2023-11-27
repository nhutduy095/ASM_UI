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
            label1.Font = new Font("Jokerman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Image = Properties.Resources.tk;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(123, 57);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 25;
            label1.Text = "         Kỳ học :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Gabriola", 12F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(358, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(355, 45);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "Fall 2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Jokerman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Image = Properties.Resources.th__1_;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(123, 115);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 28;
            label2.Text = "         Thời gian :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Image = Properties.Resources.pngtree_vector_question_mark_icon_png_image_5154481;
            linkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel1.Location = new Point(14, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(164, 20);
            linkLabel1.TabIndex = 32;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "       Hệ quản lý đào tạo";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Lucida Handwriting", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Blue;
            label18.Location = new Point(401, 5);
            label18.Name = "label18";
            label18.Size = new Size(192, 48);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 175);
            panel1.TabIndex = 34;
            // 
            // btnsearch
            // 
            btnsearch.BackgroundImageLayout = ImageLayout.Center;
            btnsearch.Font = new Font("Jokerman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnsearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnsearch.Location = new Point(762, 82);
            btnsearch.Margin = new Padding(3, 4, 3, 4);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(105, 58);
            btnsearch.TabIndex = 35;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Gabriola", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(358, 115);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(355, 41);
            dateTimePicker1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPre);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(linkLabel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1055);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1215, 72);
            panel2.TabIndex = 35;
            // 
            // btnPre
            // 
            btnPre.Location = new Point(913, 20);
            btnPre.Margin = new Padding(3, 4, 3, 4);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(86, 31);
            btnPre.TabIndex = 34;
            btnPre.Text = "Previous";
            btnPre.UseVisualStyleBackColor = true;
            btnPre.Click += btnPre_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1006, 20);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
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
            panel3.Location = new Point(0, 175);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1215, 880);
            panel3.TabIndex = 36;
            // 
            // daycontainer
            // 
            daycontainer.Dock = DockStyle.Fill;
            daycontainer.Location = new Point(0, 80);
            daycontainer.Margin = new Padding(3, 4, 3, 4);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1215, 800);
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
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1215, 80);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Location = new Point(162, 80);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(152, 124);
            panel7.TabIndex = 1;
            // 
            // saturday
            // 
            saturday.AutoSize = true;
            saturday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saturday.ForeColor = SystemColors.ActiveCaptionText;
            saturday.Location = new Point(998, 27);
            saturday.Name = "saturday";
            saturday.Size = new Size(111, 31);
            saturday.TabIndex = 6;
            saturday.Text = "Saturday";
            // 
            // friday
            // 
            friday.AutoSize = true;
            friday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            friday.ForeColor = SystemColors.ActiveCaptionText;
            friday.Location = new Point(865, 27);
            friday.Name = "friday";
            friday.Size = new Size(84, 31);
            friday.TabIndex = 5;
            friday.Text = "Friday";
            // 
            // thursday
            // 
            thursday.AutoSize = true;
            thursday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            thursday.ForeColor = SystemColors.ActiveCaptionText;
            thursday.Location = new Point(665, 27);
            thursday.Name = "thursday";
            thursday.Size = new Size(116, 31);
            thursday.TabIndex = 4;
            thursday.Text = "Thursday";
            // 
            // Wednesday
            // 
            Wednesday.AutoSize = true;
            Wednesday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Wednesday.ForeColor = SystemColors.ActiveCaptionText;
            Wednesday.Location = new Point(502, 27);
            Wednesday.Name = "Wednesday";
            Wednesday.Size = new Size(138, 31);
            Wednesday.TabIndex = 3;
            Wednesday.Text = "Wednesday";
            // 
            // tuesday
            // 
            tuesday.AutoSize = true;
            tuesday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tuesday.ForeColor = SystemColors.ActiveCaptionText;
            tuesday.Location = new Point(358, 27);
            tuesday.Name = "tuesday";
            tuesday.Size = new Size(104, 31);
            tuesday.TabIndex = 2;
            tuesday.Text = "Tuesday";
            // 
            // monday
            // 
            monday.AutoSize = true;
            monday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            monday.ForeColor = SystemColors.ActiveCaptionText;
            monday.Location = new Point(189, 27);
            monday.Name = "monday";
            monday.Size = new Size(105, 31);
            monday.TabIndex = 1;
            monday.Text = "Monday";
            // 
            // sunday
            // 
            sunday.AutoSize = true;
            sunday.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sunday.ForeColor = SystemColors.ActiveCaptionText;
            sunday.Location = new Point(31, 27);
            sunday.Name = "sunday";
            sunday.Size = new Size(96, 31);
            sunday.TabIndex = 0;
            sunday.Text = "Sunday";
            // 
            // FormLichhoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1215, 1127);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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