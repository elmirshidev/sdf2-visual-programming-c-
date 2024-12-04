
namespace EventManagementSystem
{
    partial class AddEvent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addEvent_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEvent_endDate = new System.Windows.Forms.DateTimePicker();
            this.addEvent_startDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.addEvent_clearBtn = new System.Windows.Forms.Button();
            this.addEvent_deleteBtn = new System.Windows.Forms.Button();
            this.addEvent_updateBtn = new System.Windows.Forms.Button();
            this.addEvent_addBtn = new System.Windows.Forms.Button();
            this.addEvent_importBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addEvent_location = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEvent_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEvent_eventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eventaDataSet1 = new EventaDesktop.EventaDataSet1();
            this.eventaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventaDataSet2 = new EventaDesktop.EventaDataSet2();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new EventaDesktop.EventaDataSet2TableAdapters.eventsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addEvent_picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEvent_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(24, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 343);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventsBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(28, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 238);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Events";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 278);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addEvent_price);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addEvent_endDate);
            this.panel3.Controls.Add(this.addEvent_startDate);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.addEvent_clearBtn);
            this.panel3.Controls.Add(this.addEvent_deleteBtn);
            this.panel3.Controls.Add(this.addEvent_updateBtn);
            this.panel3.Controls.Add(this.addEvent_addBtn);
            this.panel3.Controls.Add(this.addEvent_importBtn);
            this.panel3.Controls.Add(this.addEvent_picture);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.addEvent_location);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.addEvent_description);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addEvent_eventName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(24, 398);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 264);
            this.panel3.TabIndex = 2;
            // 
            // addEvent_price
            // 
            this.addEvent_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_price.Location = new System.Drawing.Point(826, 41);
            this.addEvent_price.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_price.Name = "addEvent_price";
            this.addEvent_price.Size = new System.Drawing.Size(113, 24);
            this.addEvent_price.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.label4.Location = new System.Drawing.Point(773, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price:";
            // 
            // addEvent_endDate
            // 
            this.addEvent_endDate.Location = new System.Drawing.Point(522, 129);
            this.addEvent_endDate.MaxDate = new System.DateTime(2025, 4, 30, 0, 0, 0, 0);
            this.addEvent_endDate.MinDate = new System.DateTime(2024, 12, 25, 23, 59, 0, 0);
            this.addEvent_endDate.Name = "addEvent_endDate";
            this.addEvent_endDate.Size = new System.Drawing.Size(217, 22);
            this.addEvent_endDate.TabIndex = 21;
            this.addEvent_endDate.Value = new System.DateTime(2024, 12, 25, 23, 59, 0, 0);
            // 
            // addEvent_startDate
            // 
            this.addEvent_startDate.Location = new System.Drawing.Point(522, 84);
            this.addEvent_startDate.MaxDate = new System.DateTime(2025, 4, 30, 0, 0, 0, 0);
            this.addEvent_startDate.MinDate = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            this.addEvent_startDate.Name = "addEvent_startDate";
            this.addEvent_startDate.Size = new System.Drawing.Size(217, 22);
            this.addEvent_startDate.TabIndex = 20;
            this.addEvent_startDate.Value = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.label7.Location = new System.Drawing.Point(441, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "End Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addEvent_clearBtn
            // 
            this.addEvent_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.addEvent_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_clearBtn.FlatAppearance.BorderSize = 0;
            this.addEvent_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEvent_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.addEvent_clearBtn.Location = new System.Drawing.Point(788, 201);
            this.addEvent_clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_clearBtn.Name = "addEvent_clearBtn";
            this.addEvent_clearBtn.Size = new System.Drawing.Size(151, 46);
            this.addEvent_clearBtn.TabIndex = 17;
            this.addEvent_clearBtn.Text = "Clear";
            this.addEvent_clearBtn.UseVisualStyleBackColor = false;
            this.addEvent_clearBtn.Click += new System.EventHandler(this.addEvent_clearBtn_Click);
            // 
            // addEvent_deleteBtn
            // 
            this.addEvent_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.addEvent_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addEvent_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEvent_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.addEvent_deleteBtn.Location = new System.Drawing.Point(615, 201);
            this.addEvent_deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_deleteBtn.Name = "addEvent_deleteBtn";
            this.addEvent_deleteBtn.Size = new System.Drawing.Size(151, 46);
            this.addEvent_deleteBtn.TabIndex = 16;
            this.addEvent_deleteBtn.Text = "Delete";
            this.addEvent_deleteBtn.UseVisualStyleBackColor = false;
            this.addEvent_deleteBtn.Click += new System.EventHandler(this.addEvent_deleteBtn_Click);
            // 
            // addEvent_updateBtn
            // 
            this.addEvent_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.addEvent_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_updateBtn.FlatAppearance.BorderSize = 0;
            this.addEvent_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEvent_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.addEvent_updateBtn.Location = new System.Drawing.Point(416, 201);
            this.addEvent_updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_updateBtn.Name = "addEvent_updateBtn";
            this.addEvent_updateBtn.Size = new System.Drawing.Size(151, 46);
            this.addEvent_updateBtn.TabIndex = 15;
            this.addEvent_updateBtn.Text = "Update";
            this.addEvent_updateBtn.UseVisualStyleBackColor = false;
            this.addEvent_updateBtn.Click += new System.EventHandler(this.addEvent_updateBtn_Click);
            // 
            // addEvent_addBtn
            // 
            this.addEvent_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.addEvent_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_addBtn.FlatAppearance.BorderSize = 0;
            this.addEvent_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEvent_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.addEvent_addBtn.Location = new System.Drawing.Point(243, 201);
            this.addEvent_addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_addBtn.Name = "addEvent_addBtn";
            this.addEvent_addBtn.Size = new System.Drawing.Size(151, 46);
            this.addEvent_addBtn.TabIndex = 14;
            this.addEvent_addBtn.Text = "Add";
            this.addEvent_addBtn.UseVisualStyleBackColor = false;
            this.addEvent_addBtn.Click += new System.EventHandler(this.addEvent_addBtn_Click);
            // 
            // addEvent_importBtn
            // 
            this.addEvent_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.addEvent_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_importBtn.FlatAppearance.BorderSize = 0;
            this.addEvent_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_importBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_importBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.addEvent_importBtn.Location = new System.Drawing.Point(983, 155);
            this.addEvent_importBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_importBtn.Name = "addEvent_importBtn";
            this.addEvent_importBtn.Size = new System.Drawing.Size(109, 28);
            this.addEvent_importBtn.TabIndex = 13;
            this.addEvent_importBtn.Text = "Import";
            this.addEvent_importBtn.UseVisualStyleBackColor = false;
            this.addEvent_importBtn.Click += new System.EventHandler(this.addEvent_importBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.label6.Location = new System.Drawing.Point(436, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Start Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addEvent_location
            // 
            this.addEvent_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_location.Location = new System.Drawing.Point(514, 41);
            this.addEvent_location.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_location.Name = "addEvent_location";
            this.addEvent_location.Size = new System.Drawing.Size(225, 24);
            this.addEvent_location.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.label5.Location = new System.Drawing.Point(401, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Event location:";
            // 
            // addEvent_description
            // 
            this.addEvent_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_description.Location = new System.Drawing.Point(135, 91);
            this.addEvent_description.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_description.Multiline = true;
            this.addEvent_description.Name = "addEvent_description";
            this.addEvent_description.Size = new System.Drawing.Size(225, 78);
            this.addEvent_description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // addEvent_eventName
            // 
            this.addEvent_eventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_eventName.Location = new System.Drawing.Point(135, 42);
            this.addEvent_eventName.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_eventName.Name = "addEvent_eventName";
            this.addEvent_eventName.Size = new System.Drawing.Size(225, 24);
            this.addEvent_eventName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(0, 368);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1119, 278);
            this.panel4.TabIndex = 1;
            // 
            // eventaDataSet1
            // 
            this.eventaDataSet1.DataSetName = "EventaDataSet1";
            this.eventaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventaDataSet1BindingSource
            // 
            this.eventaDataSet1BindingSource.DataSource = this.eventaDataSet1;
            this.eventaDataSet1BindingSource.Position = 0;
            // 
            // eventaDataSet2
            // 
            this.eventaDataSet2.DataSetName = "EventaDataSet2";
            this.eventaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.eventaDataSet2;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.starttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "created_by";
            this.createdbyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdbyDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Width = 125;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // addEvent_picture
            // 
            this.addEvent_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEvent_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEvent_picture.Location = new System.Drawing.Point(984, 42);
            this.addEvent_picture.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_picture.Name = "addEvent_picture";
            this.addEvent_picture.Size = new System.Drawing.Size(109, 113);
            this.addEvent_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEvent_picture.TabIndex = 12;
            this.addEvent_picture.TabStop = false;
            this.addEvent_picture.Click += new System.EventHandler(this.addEvent_picture_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEvent";
            this.Size = new System.Drawing.Size(1167, 695);
            this.Load += new System.EventHandler(this.AddEvent_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEvent_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addEvent_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEvent_eventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEvent_location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addEvent_clearBtn;
        private System.Windows.Forms.Button addEvent_deleteBtn;
        private System.Windows.Forms.Button addEvent_updateBtn;
        private System.Windows.Forms.Button addEvent_addBtn;
        private System.Windows.Forms.Button addEvent_importBtn;
        private System.Windows.Forms.PictureBox addEvent_picture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker addEvent_endDate;
        private System.Windows.Forms.DateTimePicker addEvent_startDate;
        private System.Windows.Forms.TextBox addEvent_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private EventaDesktop.EventaDataSet2 eventaDataSet2;
        private EventaDesktop.EventaDataSet1 eventaDataSet1;
        private System.Windows.Forms.BindingSource eventaDataSet1BindingSource;
        private EventaDesktop.EventaDataSet2TableAdapters.eventsTableAdapter eventsTableAdapter;
    }
}
