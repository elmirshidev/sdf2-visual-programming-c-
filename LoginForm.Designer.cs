
namespace EventManagementSystem
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_logo = new System.Windows.Forms.PictureBox();
            this.login_signupBtn = new System.Windows.Forms.Button();
            this.login_register_redirect = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.login_form_title = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.login_email_input = new System.Windows.Forms.TextBox();
            this.login_password_input = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.login_showPass_checkbox = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.login_logo);
            this.panel1.Controls.Add(this.login_signupBtn);
            this.panel1.Controls.Add(this.login_register_redirect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 492);
            this.panel1.TabIndex = 0;
            // 
            // login_logo
            // 
            this.login_logo.Image = global::EventaDesktop.Properties.Resources.eventalogo_removebg_preview;
            this.login_logo.Location = new System.Drawing.Point(87, 63);
            this.login_logo.Margin = new System.Windows.Forms.Padding(4);
            this.login_logo.Name = "login_logo";
            this.login_logo.Size = new System.Drawing.Size(183, 160);
            this.login_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_logo.TabIndex = 3;
            this.login_logo.TabStop = false;
            // 
            // login_signupBtn
            // 
            this.login_signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.login_signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_signupBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.login_signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.login_signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.login_signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.login_signupBtn.Location = new System.Drawing.Point(29, 438);
            this.login_signupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.login_signupBtn.Name = "login_signupBtn";
            this.login_signupBtn.Size = new System.Drawing.Size(301, 38);
            this.login_signupBtn.TabIndex = 1;
            this.login_signupBtn.Text = "SIGN UP";
            this.login_signupBtn.UseVisualStyleBackColor = false;
            this.login_signupBtn.Click += new System.EventHandler(this.login_signupBtn_Click);
            // 
            // login_register_redirect
            // 
            this.login_register_redirect.AutoSize = true;
            this.login_register_redirect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_register_redirect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.login_register_redirect.Location = new System.Drawing.Point(71, 405);
            this.login_register_redirect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_register_redirect.Name = "login_register_redirect";
            this.login_register_redirect.Size = new System.Drawing.Size(220, 18);
            this.login_register_redirect.TabIndex = 0;
            this.login_register_redirect.Text = "Don\'t have an account? Register";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(733, 9);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login_form_title
            // 
            this.login_form_title.AutoSize = true;
            this.login_form_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_form_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.login_form_title.Location = new System.Drawing.Point(462, 74);
            this.login_form_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_form_title.Name = "login_form_title";
            this.login_form_title.Size = new System.Drawing.Size(177, 28);
            this.login_form_title.TabIndex = 2;
            this.login_form_title.Text = "Login Account";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.email_label.Location = new System.Drawing.Point(383, 164);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(57, 21);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "Email:";
            // 
            // login_email_input
            // 
            this.login_email_input.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_email_input.Location = new System.Drawing.Point(387, 188);
            this.login_email_input.Margin = new System.Windows.Forms.Padding(4);
            this.login_email_input.Multiline = true;
            this.login_email_input.Name = "login_email_input";
            this.login_email_input.Size = new System.Drawing.Size(347, 36);
            this.login_email_input.TabIndex = 4;
            // 
            // login_password_input
            // 
            this.login_password_input.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password_input.Location = new System.Drawing.Point(387, 267);
            this.login_password_input.Margin = new System.Windows.Forms.Padding(4);
            this.login_password_input.Multiline = true;
            this.login_password_input.Name = "login_password_input";
            this.login_password_input.PasswordChar = '*';
            this.login_password_input.Size = new System.Drawing.Size(347, 36);
            this.login_password_input.TabIndex = 6;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.password_label.Location = new System.Drawing.Point(383, 242);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(87, 21);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password:";
            // 
            // login_showPass_checkbox
            // 
            this.login_showPass_checkbox.AutoSize = true;
            this.login_showPass_checkbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.login_showPass_checkbox.Location = new System.Drawing.Point(585, 311);
            this.login_showPass_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.login_showPass_checkbox.Name = "login_showPass_checkbox";
            this.login_showPass_checkbox.Size = new System.Drawing.Size(130, 22);
            this.login_showPass_checkbox.TabIndex = 7;
            this.login_showPass_checkbox.Text = "Show Password";
            this.login_showPass_checkbox.UseVisualStyleBackColor = true;
            this.login_showPass_checkbox.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.login_btn.Location = new System.Drawing.Point(387, 359);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(124, 42);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_showPass_checkbox);
            this.Controls.Add(this.login_password_input);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_email_input);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.login_form_title);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label login_form_title;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox login_email_input;
        private System.Windows.Forms.TextBox login_password_input;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.CheckBox login_showPass_checkbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_signupBtn;
        private System.Windows.Forms.Label login_register_redirect;
        private System.Windows.Forms.PictureBox login_logo;
    }
}

