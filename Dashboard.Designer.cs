
namespace EventManagementSystem
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboard_income = new System.Windows.Forms.Panel();
            this.dashboard_IE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dashboard_attendees = new System.Windows.Forms.Panel();
            this.dashboard_AE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dashboard_events = new System.Windows.Forms.Panel();
            this.dashboard_TE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventaDataSet = new EventaDesktop.EventaDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new EventaDesktop.EventaDataSetTableAdapters.usersTableAdapter();
            this.eventaDataSet1 = new EventaDesktop.EventaDataSet1();
            this.eventattendeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.event_attendeesTableAdapter = new EventaDesktop.EventaDataSet1TableAdapters.event_attendeesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dashboard_income.SuspendLayout();
            this.dashboard_attendees.SuspendLayout();
            this.dashboard_events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventattendeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboard_income
            // 
            this.dashboard_income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.dashboard_income.Controls.Add(this.dashboard_IE);
            this.dashboard_income.Controls.Add(this.label6);
            this.dashboard_income.Controls.Add(this.pictureBox3);
            this.dashboard_income.Location = new System.Drawing.Point(49, 491);
            this.dashboard_income.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_income.Name = "dashboard_income";
            this.dashboard_income.Size = new System.Drawing.Size(315, 151);
            this.dashboard_income.TabIndex = 2;
            // 
            // dashboard_IE
            // 
            this.dashboard_IE.AutoSize = true;
            this.dashboard_IE.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_IE.ForeColor = System.Drawing.Color.White;
            this.dashboard_IE.Location = new System.Drawing.Point(221, 33);
            this.dashboard_IE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard_IE.Name = "dashboard_IE";
            this.dashboard_IE.Size = new System.Drawing.Size(90, 33);
            this.dashboard_IE.TabIndex = 6;
            this.dashboard_IE.Text = "32879";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(120, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Income";
            // 
            // dashboard_attendees
            // 
            this.dashboard_attendees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.dashboard_attendees.Controls.Add(this.dashboard_AE);
            this.dashboard_attendees.Controls.Add(this.label4);
            this.dashboard_attendees.Controls.Add(this.pictureBox2);
            this.dashboard_attendees.Location = new System.Drawing.Point(49, 279);
            this.dashboard_attendees.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_attendees.Name = "dashboard_attendees";
            this.dashboard_attendees.Size = new System.Drawing.Size(315, 151);
            this.dashboard_attendees.TabIndex = 1;
            // 
            // dashboard_AE
            // 
            this.dashboard_AE.AutoSize = true;
            this.dashboard_AE.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_AE.ForeColor = System.Drawing.Color.White;
            this.dashboard_AE.Location = new System.Drawing.Point(222, 33);
            this.dashboard_AE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard_AE.Name = "dashboard_AE";
            this.dashboard_AE.Size = new System.Drawing.Size(75, 33);
            this.dashboard_AE.TabIndex = 4;
            this.dashboard_AE.Text = "1245";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Attendees";
            // 
            // dashboard_events
            // 
            this.dashboard_events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.dashboard_events.Controls.Add(this.dashboard_TE);
            this.dashboard_events.Controls.Add(this.label1);
            this.dashboard_events.Controls.Add(this.pictureBox1);
            this.dashboard_events.Location = new System.Drawing.Point(49, 66);
            this.dashboard_events.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_events.Name = "dashboard_events";
            this.dashboard_events.Size = new System.Drawing.Size(315, 151);
            this.dashboard_events.TabIndex = 0;
            // 
            // dashboard_TE
            // 
            this.dashboard_TE.AutoSize = true;
            this.dashboard_TE.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TE.ForeColor = System.Drawing.Color.White;
            this.dashboard_TE.Location = new System.Drawing.Point(261, 33);
            this.dashboard_TE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard_TE.Name = "dashboard_TE";
            this.dashboard_TE.Size = new System.Drawing.Size(45, 33);
            this.dashboard_TE.TabIndex = 2;
            this.dashboard_TE.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Events";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.eventidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.registeredatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventattendeesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.dataGridView1.Location = new System.Drawing.Point(507, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 576);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eventaDataSet
            // 
            this.eventaDataSet.DataSetName = "EventaDataSet";
            this.eventaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.eventaDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // eventaDataSet1
            // 
            this.eventaDataSet1.DataSetName = "EventaDataSet1";
            this.eventaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventattendeesBindingSource
            // 
            this.eventattendeesBindingSource.DataMember = "event_attendees";
            this.eventattendeesBindingSource.DataSource = this.eventaDataSet1;
            // 
            // event_attendeesTableAdapter
            // 
            this.event_attendeesTableAdapter.ClearBeforeFill = true;
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
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "event_id";
            this.eventidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            this.eventidDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // registeredatDataGridViewTextBoxColumn
            // 
            this.registeredatDataGridViewTextBoxColumn.DataPropertyName = "registered_at";
            this.registeredatDataGridViewTextBoxColumn.HeaderText = "registered_at";
            this.registeredatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registeredatDataGridViewTextBoxColumn.Name = "registeredatDataGridViewTextBoxColumn";
            this.registeredatDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EventaDesktop.Properties.Resources.money;
            this.pictureBox3.Location = new System.Drawing.Point(27, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventaDesktop.Properties.Resources.eventalogo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EventaDesktop.Properties.Resources.attendees_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(21, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dashboard_income);
            this.Controls.Add(this.dashboard_events);
            this.Controls.Add(this.dashboard_attendees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1167, 695);
            this.dashboard_income.ResumeLayout(false);
            this.dashboard_income.PerformLayout();
            this.dashboard_attendees.ResumeLayout(false);
            this.dashboard_attendees.PerformLayout();
            this.dashboard_events.ResumeLayout(false);
            this.dashboard_events.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventattendeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dashboard_income;
        private System.Windows.Forms.Panel dashboard_attendees;
        private System.Windows.Forms.Panel dashboard_events;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label dashboard_IE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dashboard_AE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dashboard_TE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private EventaDesktop.EventaDataSet eventaDataSet;
        private EventaDesktop.EventaDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventattendeesBindingSource;
        private EventaDesktop.EventaDataSet1 eventaDataSet1;
        private EventaDesktop.EventaDataSet1TableAdapters.event_attendeesTableAdapter event_attendeesTableAdapter;
    }
}
