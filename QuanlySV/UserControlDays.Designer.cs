namespace QuanlySV
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblday = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lblday
            // 
            lblday.AutoSize = true;
            lblday.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblday.Location = new Point(11, 10);
            lblday.Name = "lblday";
            lblday.Size = new Size(19, 15);
            lblday.TabIndex = 0;
            lblday.Text = "00";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(138, 79);
            listBox1.TabIndex = 1;
            listBox1.MouseClick += listBox1_MouseClick;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(listBox1);
            Controls.Add(lblday);
            Name = "UserControlDays";
            Size = new Size(138, 109);
            Load += UserControlDays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblday;
        private DataGridView dataGridView1;
        private ListBox listBox1;
    }
}
