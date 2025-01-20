
namespace EventManagementSystem
{
    partial class RegisterForm
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
            this.signup_btn = new System.Windows.Forms.Button();
            this.register_showPassword_checkbox = new System.Windows.Forms.CheckBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.register_form_title = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_logo = new System.Windows.Forms.PictureBox();
            this.signup_loginBtn = new System.Windows.Forms.Button();
            this.signup_login_redirect = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signup_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.signup_btn.Location = new System.Drawing.Point(392, 359);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(4);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(124, 42);
            this.signup_btn.TabIndex = 17;
            this.signup_btn.Text = "SIGN UP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // register_showPassword_checkbox
            // 
            this.register_showPassword_checkbox.AutoSize = true;
            this.register_showPassword_checkbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPassword_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.register_showPassword_checkbox.Location = new System.Drawing.Point(591, 311);
            this.register_showPassword_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.register_showPassword_checkbox.Name = "register_showPassword_checkbox";
            this.register_showPassword_checkbox.Size = new System.Drawing.Size(130, 22);
            this.register_showPassword_checkbox.TabIndex = 16;
            this.register_showPassword_checkbox.Text = "Show Password";
            this.register_showPassword_checkbox.UseVisualStyleBackColor = true;
            this.register_showPassword_checkbox.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(392, 267);
            this.password_input.Margin = new System.Windows.Forms.Padding(4);
            this.password_input.Multiline = true;
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(347, 36);
            this.password_input.TabIndex = 15;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.password_label.Location = new System.Drawing.Point(388, 242);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(87, 21);
            this.password_label.TabIndex = 14;
            this.password_label.Text = "Password:";
            // 
            // username_input
            // 
            this.username_input.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_input.Location = new System.Drawing.Point(392, 188);
            this.username_input.Margin = new System.Windows.Forms.Padding(4);
            this.username_input.Multiline = true;
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(347, 36);
            this.username_input.TabIndex = 13;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.username_label.Location = new System.Drawing.Point(388, 164);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(91, 21);
            this.username_label.TabIndex = 12;
            this.username_label.Text = "Username:";
            // 
            // register_form_title
            // 
            this.register_form_title.AutoSize = true;
            this.register_form_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_form_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.register_form_title.Location = new System.Drawing.Point(455, 38);
            this.register_form_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_form_title.Name = "register_form_title";
            this.register_form_title.Size = new System.Drawing.Size(212, 28);
            this.register_form_title.TabIndex = 11;
            this.register_form_title.Text = "Register Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(735, 9);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.signup_logo);
            this.panel1.Controls.Add(this.signup_loginBtn);
            this.panel1.Controls.Add(this.signup_login_redirect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 492);
            this.panel1.TabIndex = 9;
            // 
            // signup_logo
            // 
            this.signup_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signup_logo.Image = global::EventaDesktop.Properties.Resources.eventalogo_removebg_preview;
            this.signup_logo.Location = new System.Drawing.Point(87, 63);
            this.signup_logo.Margin = new System.Windows.Forms.Padding(4);
            this.signup_logo.Name = "signup_logo";
            this.signup_logo.Size = new System.Drawing.Size(183, 160);
            this.signup_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signup_logo.TabIndex = 3;
            this.signup_logo.TabStop = false;
            // 
            // signup_loginBtn
            // 
            this.signup_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.signup_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.signup_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.signup_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.signup_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_loginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.signup_loginBtn.Location = new System.Drawing.Point(29, 438);
            this.signup_loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.signup_loginBtn.Name = "signup_loginBtn";
            this.signup_loginBtn.Size = new System.Drawing.Size(301, 38);
            this.signup_loginBtn.TabIndex = 1;
            this.signup_loginBtn.Text = "SIGN IN";
            this.signup_loginBtn.UseVisualStyleBackColor = false;
            this.signup_loginBtn.Click += new System.EventHandler(this.signup_loginBtn_Click);
            // 
            // signup_login_redirect
            // 
            this.signup_login_redirect.AutoSize = true;
            this.signup_login_redirect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_login_redirect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.signup_login_redirect.Location = new System.Drawing.Point(97, 407);
            this.signup_login_redirect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signup_login_redirect.Name = "signup_login_redirect";
            this.signup_login_redirect.Size = new System.Drawing.Size(164, 18);
            this.signup_login_redirect.TabIndex = 0;
            this.signup_login_redirect.Text = "Have an account? Login";
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(392, 113);
            this.email_input.Margin = new System.Windows.Forms.Padding(4);
            this.email_input.Multiline = true;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(347, 36);
            this.email_input.TabIndex = 19;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.email_label.Location = new System.Drawing.Point(388, 89);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(57, 21);
            this.email_label.TabIndex = 18;
            this.email_label.Text = "Email:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.register_showPassword_checkbox);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.register_form_title);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signup_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox register_showPassword_checkbox;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label register_form_title;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox signup_logo;
        private System.Windows.Forms.Button signup_loginBtn;
        private System.Windows.Forms.Label signup_login_redirect;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label email_label;
    }
}