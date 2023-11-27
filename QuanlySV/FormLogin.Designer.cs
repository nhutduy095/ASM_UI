namespace QuanlySV
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 56);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(47, 107);
            label2.Name = "label2";
            label2.Size = new Size(269, 50);
            label2.TabIndex = 2;
            label2.Text = "Email đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(47, 210);
            label3.Name = "label3";
            label3.Size = new Size(169, 50);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(138, 367);
            button1.Name = "button1";
            button1.Size = new Size(283, 55);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(138, 428);
            button2.Name = "button2";
            button2.Size = new Size(283, 55);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(255, 128, 0);
            txtUserName.Location = new Point(47, 160);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(444, 44);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 128, 0);
            txtPassword.Location = new Point(47, 261);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(444, 44);
            txtPassword.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(85, 319);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 28);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.VisitedLinkColor = Color.Black;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(606, 526);
            Controls.Add(linkLabel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private LinkLabel linkLabel1;
    }
}