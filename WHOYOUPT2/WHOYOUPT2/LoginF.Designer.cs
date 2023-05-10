namespace WHOYOUPT2
{
    partial class LoginF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            registerLink = new LinkLabel();
            noaccountTxt = new Label();
            submitBtn = new Button();
            forgotpassTxt = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            passTxt = new Label();
            emailTxt = new Label();
            loginmealsTxt = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(registerLink);
            panel1.Controls.Add(noaccountTxt);
            panel1.Controls.Add(submitBtn);
            panel1.Controls.Add(forgotpassTxt);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(passTxt);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(loginmealsTxt);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(551, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 563);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // registerLink
            // 
            registerLink.ActiveLinkColor = Color.LawnGreen;
            registerLink.AutoSize = true;
            registerLink.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            registerLink.ForeColor = SystemColors.ControlDarkDark;
            registerLink.LinkColor = Color.DarkOliveGreen;
            registerLink.Location = new Point(180, 495);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(65, 13);
            registerLink.TabIndex = 9;
            registerLink.TabStop = true;
            registerLink.Text = "Create one.";
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // noaccountTxt
            // 
            noaccountTxt.AutoSize = true;
            noaccountTxt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            noaccountTxt.ForeColor = SystemColors.ControlDark;
            noaccountTxt.Location = new Point(57, 495);
            noaccountTxt.Name = "noaccountTxt";
            noaccountTxt.Size = new Size(128, 13);
            noaccountTxt.TabIndex = 8;
            noaccountTxt.Text = "Don't have an account?";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.MediumSeaGreen;
            submitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.ForeColor = SystemColors.HighlightText;
            submitBtn.Location = new Point(28, 456);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(251, 36);
            submitBtn.TabIndex = 7;
            submitBtn.Text = "Login";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.BackColorChanged += submitBtn_MouseHover;
            submitBtn.Click += submitBtn_Click;
            submitBtn.MouseLeave += submitBtn_MouseLeave;
            submitBtn.MouseHover += submitBtn_MouseHover;
            // 
            // forgotpassTxt
            // 
            forgotpassTxt.AutoSize = true;
            forgotpassTxt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            forgotpassTxt.ForeColor = SystemColors.ControlDark;
            forgotpassTxt.Location = new Point(28, 425);
            forgotpassTxt.Name = "forgotpassTxt";
            forgotpassTxt.Size = new Size(99, 13);
            forgotpassTxt.TabIndex = 6;
            forgotpassTxt.Text = "Forgot Password?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 399);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your password";
            textBox2.Size = new Size(251, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 345);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "your@email.com";
            textBox1.Size = new Size(251, 23);
            textBox1.TabIndex = 4;
            // 
            // passTxt
            // 
            passTxt.AutoSize = true;
            passTxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passTxt.Location = new Point(28, 381);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(57, 15);
            passTxt.TabIndex = 3;
            passTxt.Text = "Password";
            // 
            // emailTxt
            // 
            emailTxt.AutoSize = true;
            emailTxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailTxt.Location = new Point(28, 327);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(81, 15);
            emailTxt.TabIndex = 2;
            emailTxt.Text = "Email Address";
            // 
            // loginmealsTxt
            // 
            loginmealsTxt.AutoSize = true;
            loginmealsTxt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            loginmealsTxt.Location = new Point(57, 295);
            loginmealsTxt.Name = "loginmealsTxt";
            loginmealsTxt.Size = new Size(199, 17);
            loginmealsTxt.TabIndex = 1;
            loginmealsTxt.Text = "Login to order your MMH meals.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.morning_munch_hungry_high_resolution_logo_color_on_transparent_background_1__4_;
            pictureBox1.Location = new Point(28, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 274);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_login_signin;
            ClientSize = new Size(855, 563);
            Controls.Add(panel1);
            Name = "LoginF";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label loginmealsTxt;
        private Label passTxt;
        private Label emailTxt;
        private Label noaccountTxt;
        private Button submitBtn;
        private Label forgotpassTxt;
        private TextBox textBox2;
        private TextBox textBox1;
        private LinkLabel registerLink;
    }
}