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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSignin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Location = new Point(479, 190);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(184, 40);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(479, 240);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(184, 40);
            txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(371, 204);
            label1.Name = "label1";
            label1.Size = new Size(32, 26);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(371, 253);
            label2.Name = "label2";
            label2.Size = new Size(102, 26);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(546, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 44);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = SystemColors.Control;
            btnSignin.FlatAppearance.BorderColor = Color.Black;
            btnSignin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignin.ForeColor = Color.White;
            btnSignin.Image = (Image)resources.GetObject("btnSignin.Image");
            btnSignin.Location = new Point(422, 331);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(117, 44);
            btnSignin.TabIndex = 11;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 26);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(341, 247);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 28);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(479, 295);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 23);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Remember Id";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(675, 437);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignin);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "FormLogin";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        private Button btnSignin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
    }
}