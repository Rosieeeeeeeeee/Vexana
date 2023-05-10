namespace WHOYOUPT2
{
    partial class RegisterF
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
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            lastnameBox = new TextBox();
            firstnameBox = new TextBox();
            loginLink = new LinkLabel();
            alreadyTxt = new Label();
            signupBtn = new Button();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            passTxt = new Label();
            emailTxt = new Label();
            setupTxt = new Label();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(lastnameBox);
            panel2.Controls.Add(firstnameBox);
            panel2.Controls.Add(loginLink);
            panel2.Controls.Add(alreadyTxt);
            panel2.Controls.Add(signupBtn);
            panel2.Controls.Add(passwordBox);
            panel2.Controls.Add(emailBox);
            panel2.Controls.Add(passTxt);
            panel2.Controls.Add(emailTxt);
            panel2.Controls.Add(setupTxt);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(551, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 563);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.SteelBlue;
            checkBox1.Location = new Point(27, 465);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(192, 17);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "I accept all terms and conditions";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(179, 330);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.PlaceholderText = "Last name";
            lastnameBox.Size = new Size(100, 23);
            lastnameBox.TabIndex = 11;
            // 
            // firstnameBox
            // 
            firstnameBox.Location = new Point(27, 330);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.PlaceholderText = "First name";
            firstnameBox.Size = new Size(100, 23);
            firstnameBox.TabIndex = 10;
            // 
            // loginLink
            // 
            loginLink.ActiveLinkColor = Color.LawnGreen;
            loginLink.AutoSize = true;
            loginLink.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginLink.ForeColor = SystemColors.ControlDarkDark;
            loginLink.LinkColor = Color.DarkOliveGreen;
            loginLink.Location = new Point(188, 533);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(35, 13);
            loginLink.TabIndex = 9;
            loginLink.TabStop = true;
            loginLink.Text = "Login";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // alreadyTxt
            // 
            alreadyTxt.AutoSize = true;
            alreadyTxt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            alreadyTxt.ForeColor = SystemColors.ControlDark;
            alreadyTxt.Location = new Point(55, 533);
            alreadyTxt.Name = "alreadyTxt";
            alreadyTxt.Size = new Size(137, 13);
            alreadyTxt.TabIndex = 8;
            alreadyTxt.Text = "Already have an account?";
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.MediumSeaGreen;
            signupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signupBtn.ForeColor = SystemColors.HighlightText;
            signupBtn.Location = new Point(27, 494);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(251, 36);
            signupBtn.TabIndex = 7;
            signupBtn.Text = "Signup";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            signupBtn.MouseLeave += signupBtn_MouseLeave;
            signupBtn.MouseHover += signupBtn_MouseHover;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(27, 438);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Enter your password";
            passwordBox.Size = new Size(251, 23);
            passwordBox.TabIndex = 5;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(27, 384);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "your@email.com";
            emailBox.Size = new Size(251, 23);
            emailBox.TabIndex = 4;
            // 
            // passTxt
            // 
            passTxt.AutoSize = true;
            passTxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passTxt.Location = new Point(27, 420);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(57, 15);
            passTxt.TabIndex = 3;
            passTxt.Text = "Password";
            // 
            // emailTxt
            // 
            emailTxt.AutoSize = true;
            emailTxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailTxt.Location = new Point(27, 366);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(81, 15);
            emailTxt.TabIndex = 2;
            emailTxt.Text = "Email Address";
            // 
            // setupTxt
            // 
            setupTxt.AutoSize = true;
            setupTxt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            setupTxt.Location = new Point(35, 295);
            setupTxt.Name = "setupTxt";
            setupTxt.Size = new Size(240, 17);
            setupTxt.TabIndex = 1;
            setupTxt.Text = "Setup your account to see MMH meals.";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.morning_munch_hungry_high_resolution_logo_color_on_transparent_background_1__4_;
            pictureBox2.Location = new Point(28, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(251, 274);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // RegisterF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_login_signin;
            ClientSize = new Size(855, 563);
            Controls.Add(panel2);
            Name = "RegisterF";
            Text = "RegisterF";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private LinkLabel loginLink;
        private Label alreadyTxt;
        private Button signupBtn;
        private TextBox passwordBox;
        private TextBox emailBox;
        private Label passTxt;
        private Label emailTxt;
        private Label setupTxt;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private TextBox lastnameBox;
        private TextBox firstnameBox;
    }
}