
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
            this.totalIncome_panel = new System.Windows.Forms.Panel();
            this.totalIncome_count = new System.Windows.Forms.Label();
            this.totalIncome_panel_text = new System.Windows.Forms.Label();
            this.totalIncome_img = new System.Windows.Forms.PictureBox();
            this.totalAtds_panel = new System.Windows.Forms.Panel();
            this.totalAtds_count = new System.Windows.Forms.Label();
            this.totalAtds_panel_text = new System.Windows.Forms.Label();
            this.totalAtds_panel_img = new System.Windows.Forms.PictureBox();
            this.totalEvents_panel = new System.Windows.Forms.Panel();
            this.totalEvents_count = new System.Windows.Forms.Label();
            this.totalEvents_panel_text = new System.Windows.Forms.Label();
            this.totalEvents_panel_img = new System.Windows.Forms.PictureBox();
            this.atdsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventattendeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventaDataSet1 = new EventaDesktop.EventaDataSet1();
            this.eventaDataSet = new EventaDesktop.EventaDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new EventaDesktop.EventaDataSetTableAdapters.usersTableAdapter();
            this.event_attendeesTableAdapter = new EventaDesktop.EventaDataSet1TableAdapters.event_attendeesTableAdapter();
            this.totalIncome_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncome_img)).BeginInit();
            this.totalAtds_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAtds_panel_img)).BeginInit();
            this.totalEvents_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalEvents_panel_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atdsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventattendeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalIncome_panel
            // 
            this.totalIncome_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.totalIncome_panel.Controls.Add(this.totalIncome_count);
            this.totalIncome_panel.Controls.Add(this.totalIncome_panel_text);
            this.totalIncome_panel.Controls.Add(this.totalIncome_img);
            this.totalIncome_panel.Location = new System.Drawing.Point(49, 491);
            this.totalIncome_panel.Margin = new System.Windows.Forms.Padding(4);
            this.totalIncome_panel.Name = "totalIncome_panel";
            this.totalIncome_panel.Size = new System.Drawing.Size(315, 151);
            this.totalIncome_panel.TabIndex = 2;
            // 
            // totalIncome_count
            // 
            this.totalIncome_count.AutoSize = true;
            this.totalIncome_count.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncome_count.ForeColor = System.Drawing.Color.White;
            this.totalIncome_count.Location = new System.Drawing.Point(221, 33);
            this.totalIncome_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalIncome_count.Name = "totalIncome_count";
            this.totalIncome_count.Size = new System.Drawing.Size(90, 33);
            this.totalIncome_count.TabIndex = 6;
            this.totalIncome_count.Text = "32879";
            // 
            // totalIncome_panel_text
            // 
            this.totalIncome_panel_text.AutoSize = true;
            this.totalIncome_panel_text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.totalIncome_panel_text.ForeColor = System.Drawing.Color.White;
            this.totalIncome_panel_text.Location = new System.Drawing.Point(120, 106);
            this.totalIncome_panel_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalIncome_panel_text.Name = "totalIncome_panel_text";
            this.totalIncome_panel_text.Size = new System.Drawing.Size(136, 23);
            this.totalIncome_panel_text.TabIndex = 5;
            this.totalIncome_panel_text.Text = "Total Income";
            // 
            // totalIncome_img
            // 
            this.totalIncome_img.Image = global::EventaDesktop.Properties.Resources.money;
            this.totalIncome_img.Location = new System.Drawing.Point(27, 33);
            this.totalIncome_img.Margin = new System.Windows.Forms.Padding(4);
            this.totalIncome_img.Name = "totalIncome_img";
            this.totalIncome_img.Size = new System.Drawing.Size(80, 74);
            this.totalIncome_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.totalIncome_img.TabIndex = 2;
            this.totalIncome_img.TabStop = false;
            // 
            // totalAtds_panel
            // 
            this.totalAtds_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.totalAtds_panel.Controls.Add(this.totalAtds_count);
            this.totalAtds_panel.Controls.Add(this.totalAtds_panel_text);
            this.totalAtds_panel.Controls.Add(this.totalAtds_panel_img);
            this.totalAtds_panel.Location = new System.Drawing.Point(49, 279);
            this.totalAtds_panel.Margin = new System.Windows.Forms.Padding(4);
            this.totalAtds_panel.Name = "totalAtds_panel";
            this.totalAtds_panel.Size = new System.Drawing.Size(315, 151);
            this.totalAtds_panel.TabIndex = 1;
            // 
            // totalAtds_count
            // 
            this.totalAtds_count.AutoSize = true;
            this.totalAtds_count.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAtds_count.ForeColor = System.Drawing.Color.White;
            this.totalAtds_count.Location = new System.Drawing.Point(222, 33);
            this.totalAtds_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalAtds_count.Name = "totalAtds_count";
            this.totalAtds_count.Size = new System.Drawing.Size(75, 33);
            this.totalAtds_count.TabIndex = 4;
            this.totalAtds_count.Text = "1245";
            // 
            // totalAtds_panel_text
            // 
            this.totalAtds_panel_text.AutoSize = true;
            this.totalAtds_panel_text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.totalAtds_panel_text.ForeColor = System.Drawing.Color.White;
            this.totalAtds_panel_text.Location = new System.Drawing.Point(121, 106);
            this.totalAtds_panel_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalAtds_panel_text.Name = "totalAtds_panel_text";
            this.totalAtds_panel_text.Size = new System.Drawing.Size(164, 23);
            this.totalAtds_panel_text.TabIndex = 3;
            this.totalAtds_panel_text.Text = "Total Attendees";
            // 
            // totalAtds_panel_img
            // 
            this.totalAtds_panel_img.Image = global::EventaDesktop.Properties.Resources.attendees_removebg_preview;
            this.totalAtds_panel_img.Location = new System.Drawing.Point(21, 33);
            this.totalAtds_panel_img.Margin = new System.Windows.Forms.Padding(4);
            this.totalAtds_panel_img.Name = "totalAtds_panel_img";
            this.totalAtds_panel_img.Size = new System.Drawing.Size(80, 74);
            this.totalAtds_panel_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.totalAtds_panel_img.TabIndex = 1;
            this.totalAtds_panel_img.TabStop = false;
            // 
            // totalEvents_panel
            // 
            this.totalEvents_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.totalEvents_panel.Controls.Add(this.totalEvents_count);
            this.totalEvents_panel.Controls.Add(this.totalEvents_panel_text);
            this.totalEvents_panel.Controls.Add(this.totalEvents_panel_img);
            this.totalEvents_panel.Location = new System.Drawing.Point(49, 66);
            this.totalEvents_panel.Margin = new System.Windows.Forms.Padding(4);
            this.totalEvents_panel.Name = "totalEvents_panel";
            this.totalEvents_panel.Size = new System.Drawing.Size(315, 151);
            this.totalEvents_panel.TabIndex = 0;
            // 
            // totalEvents_count
            // 
            this.totalEvents_count.AutoSize = true;
            this.totalEvents_count.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEvents_count.ForeColor = System.Drawing.Color.White;
            this.totalEvents_count.Location = new System.Drawing.Point(261, 33);
            this.totalEvents_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalEvents_count.Name = "totalEvents_count";
            this.totalEvents_count.Size = new System.Drawing.Size(45, 33);
            this.totalEvents_count.TabIndex = 2;
            this.totalEvents_count.Text = "10";
            // 
            // totalEvents_panel_text
            // 
            this.totalEvents_panel_text.AutoSize = true;
            this.totalEvents_panel_text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEvents_panel_text.ForeColor = System.Drawing.Color.White;
            this.totalEvents_panel_text.Location = new System.Drawing.Point(124, 106);
            this.totalEvents_panel_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalEvents_panel_text.Name = "totalEvents_panel_text";
            this.totalEvents_panel_text.Size = new System.Drawing.Size(130, 23);
            this.totalEvents_panel_text.TabIndex = 1;
            this.totalEvents_panel_text.Text = "Total Events";
            // 
            // totalEvents_panel_img
            // 
            this.totalEvents_panel_img.Image = global::EventaDesktop.Properties.Resources.eventalogo_removebg_preview;
            this.totalEvents_panel_img.Location = new System.Drawing.Point(24, 33);
            this.totalEvents_panel_img.Margin = new System.Windows.Forms.Padding(4);
            this.totalEvents_panel_img.Name = "totalEvents_panel_img";
            this.totalEvents_panel_img.Size = new System.Drawing.Size(80, 74);
            this.totalEvents_panel_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.totalEvents_panel_img.TabIndex = 0;
            this.totalEvents_panel_img.TabStop = false;
            // 
            // atdsGridView
            // 
            this.atdsGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.atdsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.atdsGridView.AutoGenerateColumns = false;
            this.atdsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.atdsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.atdsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atdsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.eventidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.registeredatDataGridViewTextBoxColumn});
            this.atdsGridView.DataSource = this.eventattendeesBindingSource;
            this.atdsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.atdsGridView.Location = new System.Drawing.Point(507, 66);
            this.atdsGridView.Name = "atdsGridView";
            this.atdsGridView.RowHeadersWidth = 51;
            this.atdsGridView.RowTemplate.Height = 24;
            this.atdsGridView.Size = new System.Drawing.Size(553, 576);
            this.atdsGridView.TabIndex = 3;
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
            // eventattendeesBindingSource
            // 
            this.eventattendeesBindingSource.DataMember = "event_attendees";
            this.eventattendeesBindingSource.DataSource = this.eventaDataSet1;
            // 
            // eventaDataSet1
            // 
            this.eventaDataSet1.DataSetName = "EventaDataSet1";
            this.eventaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // event_attendeesTableAdapter
            // 
            this.event_attendeesTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.atdsGridView);
            this.Controls.Add(this.totalIncome_panel);
            this.Controls.Add(this.totalEvents_panel);
            this.Controls.Add(this.totalAtds_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1167, 695);
            this.totalIncome_panel.ResumeLayout(false);
            this.totalIncome_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncome_img)).EndInit();
            this.totalAtds_panel.ResumeLayout(false);
            this.totalAtds_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAtds_panel_img)).EndInit();
            this.totalEvents_panel.ResumeLayout(false);
            this.totalEvents_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalEvents_panel_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atdsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventattendeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel totalIncome_panel;
        private System.Windows.Forms.Panel totalAtds_panel;
        private System.Windows.Forms.Panel totalEvents_panel;
        private System.Windows.Forms.PictureBox totalEvents_panel_img;
        private System.Windows.Forms.PictureBox totalAtds_panel_img;
        private System.Windows.Forms.PictureBox totalIncome_img;
        private System.Windows.Forms.Label totalIncome_count;
        private System.Windows.Forms.Label totalIncome_panel_text;
        private System.Windows.Forms.Label totalAtds_count;
        private System.Windows.Forms.Label totalAtds_panel_text;
        private System.Windows.Forms.Label totalEvents_count;
        private System.Windows.Forms.Label totalEvents_panel_text;
        private System.Windows.Forms.DataGridView atdsGridView;
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
