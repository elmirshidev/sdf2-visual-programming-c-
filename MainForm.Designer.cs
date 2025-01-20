
namespace EventManagementSystem
{
    partial class MainForm
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
            this.main_title = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewEvents_btn = new System.Windows.Forms.Button();
            this.logout_txt = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addEvent_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.main_username = new System.Windows.Forms.Label();
            this.main_pp = new System.Windows.Forms.PictureBox();
            this.mainForm_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.main_title);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 43);
            this.panel1.TabIndex = 0;
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.main_title.Location = new System.Drawing.Point(9, 11);
            this.main_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(65, 20);
            this.main_title.TabIndex = 1;
            this.main_title.Text = "Eventa";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1439, 10);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.viewEvents_btn);
            this.panel2.Controls.Add(this.logout_txt);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.addEvent_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.main_username);
            this.panel2.Controls.Add(this.main_pp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 695);
            this.panel2.TabIndex = 1;
            // 
            // viewEvents_btn
            // 
            this.viewEvents_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.viewEvents_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewEvents_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.viewEvents_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.viewEvents_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.viewEvents_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.viewEvents_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEvents_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEvents_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.viewEvents_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewEvents_btn.Location = new System.Drawing.Point(19, 407);
            this.viewEvents_btn.Margin = new System.Windows.Forms.Padding(4);
            this.viewEvents_btn.Name = "viewEvents_btn";
            this.viewEvents_btn.Size = new System.Drawing.Size(267, 49);
            this.viewEvents_btn.TabIndex = 7;
            this.viewEvents_btn.Text = "VIEW EVENTS";
            this.viewEvents_btn.UseVisualStyleBackColor = false;
            this.viewEvents_btn.Click += new System.EventHandler(this.viewEvents_Click);
            // 
            // logout_txt
            // 
            this.logout_txt.AutoSize = true;
            this.logout_txt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.logout_txt.Location = new System.Drawing.Point(73, 649);
            this.logout_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logout_txt.Name = "logout_txt";
            this.logout_txt.Size = new System.Drawing.Size(83, 23);
            this.logout_txt.TabIndex = 6;
            this.logout_txt.Text = "Sign Out";
            // 
            // logout_btn
            // 
            this.logout_btn.BackgroundImage = global::EventaDesktop.Properties.Resources.icons8_logout_rounded_up_filled_25px;
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(25, 642);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(40, 40);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // addEvent_btn
            // 
            this.addEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.addEvent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEvent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.addEvent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEvent_btn.Location = new System.Drawing.Point(19, 341);
            this.addEvent_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_btn.Name = "addEvent_btn";
            this.addEvent_btn.Size = new System.Drawing.Size(267, 49);
            this.addEvent_btn.TabIndex = 3;
            this.addEvent_btn.Text = "ADD EVENT";
            this.addEvent_btn.UseVisualStyleBackColor = false;
            this.addEvent_btn.Click += new System.EventHandler(this.addEvent_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(19, 271);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(267, 49);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // main_username
            // 
            this.main_username.AutoSize = true;
            this.main_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.main_username.Location = new System.Drawing.Point(73, 183);
            this.main_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_username.Name = "main_username";
            this.main_username.Size = new System.Drawing.Size(156, 24);
            this.main_username.TabIndex = 1;
            this.main_username.Text = "Welcome, Elmir!";
            // 
            // main_pp
            // 
            this.main_pp.Image = global::EventaDesktop.Properties.Resources.pp_removebg_preview;
            this.main_pp.Location = new System.Drawing.Point(90, 55);
            this.main_pp.Margin = new System.Windows.Forms.Padding(4);
            this.main_pp.Name = "main_pp";
            this.main_pp.Size = new System.Drawing.Size(123, 124);
            this.main_pp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main_pp.TabIndex = 0;
            this.main_pp.TabStop = false;
            // 
            // mainForm_panel
            // 
            this.mainForm_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.mainForm_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainForm_panel.Location = new System.Drawing.Point(300, 43);
            this.mainForm_panel.Margin = new System.Windows.Forms.Padding(4);
            this.mainForm_panel.Name = "mainForm_panel";
            this.mainForm_panel.Size = new System.Drawing.Size(1167, 695);
            this.mainForm_panel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 738);
            this.Controls.Add(this.mainForm_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox main_pp;
        private System.Windows.Forms.Label main_username;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button addEvent_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label logout_txt;
        private System.Windows.Forms.Panel mainForm_panel;
        private System.Windows.Forms.Button viewEvents_btn;
        //private Salary salary1;
        //private Dashboard dashboard1;
        //private AddEmployee addEmployee1;
    }
}