
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
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
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventaDataSet2 = new EventaDesktop.EventaDataSet2();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.eventPrice_input = new System.Windows.Forms.TextBox();
            this.eventPrice_label = new System.Windows.Forms.Label();
            this.eventSDate_input = new System.Windows.Forms.DateTimePicker();
            this.clearAllFields_btn = new System.Windows.Forms.Button();
            this.deleteEvent_btn = new System.Windows.Forms.Button();
            this.updateEvent_btn = new System.Windows.Forms.Button();
            this.addEvent_btn = new System.Windows.Forms.Button();
            this.eventPhoto_import_btn = new System.Windows.Forms.Button();
            this.eventPhoto = new System.Windows.Forms.PictureBox();
            this.eventSDate_label = new System.Windows.Forms.Label();
            this.eventLocation_input = new System.Windows.Forms.TextBox();
            this.eventLocation_label = new System.Windows.Forms.Label();
            this.eventDesc_input = new System.Windows.Forms.TextBox();
            this.eventDesc_label = new System.Windows.Forms.Label();
            this.eventName_input = new System.Windows.Forms.TextBox();
            this.eventName_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eventaDataSet1 = new EventaDesktop.EventaDataSet1();
            this.eventaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new EventaDesktop.EventaDataSet2TableAdapters.eventsTableAdapter();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet2)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.eventsDataGrid);
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Location = new System.Drawing.Point(24, 30);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1118, 343);
            this.topPanel.TabIndex = 0;
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.AllowUserToAddRows = false;
            this.eventsDataGrid.AllowUserToDeleteRows = false;
            this.eventsDataGrid.AutoGenerateColumns = false;
            this.eventsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.eventsDataGrid.DataSource = this.eventsBindingSource;
            this.eventsDataGrid.EnableHeadersVisualStyles = false;
            this.eventsDataGrid.Location = new System.Drawing.Point(28, 71);
            this.eventsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.ReadOnly = true;
            this.eventsDataGrid.RowHeadersVisible = false;
            this.eventsDataGrid.RowHeadersWidth = 51;
            this.eventsDataGrid.Size = new System.Drawing.Size(1064, 238);
            this.eventsDataGrid.TabIndex = 3;
            this.eventsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.eventaDataSet2;
            // 
            // eventaDataSet2
            // 
            this.eventaDataSet2.DataSetName = "EventaDataSet2";
            this.eventaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.title.Location = new System.Drawing.Point(24, 26);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(124, 27);
            this.title.TabIndex = 2;
            this.title.Text = "My Events";
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
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomPanel.Controls.Add(this.eventPrice_input);
            this.bottomPanel.Controls.Add(this.eventPrice_label);
            this.bottomPanel.Controls.Add(this.eventSDate_input);
            this.bottomPanel.Controls.Add(this.clearAllFields_btn);
            this.bottomPanel.Controls.Add(this.deleteEvent_btn);
            this.bottomPanel.Controls.Add(this.updateEvent_btn);
            this.bottomPanel.Controls.Add(this.addEvent_btn);
            this.bottomPanel.Controls.Add(this.eventPhoto_import_btn);
            this.bottomPanel.Controls.Add(this.eventPhoto);
            this.bottomPanel.Controls.Add(this.eventSDate_label);
            this.bottomPanel.Controls.Add(this.eventLocation_input);
            this.bottomPanel.Controls.Add(this.eventLocation_label);
            this.bottomPanel.Controls.Add(this.eventDesc_input);
            this.bottomPanel.Controls.Add(this.eventDesc_label);
            this.bottomPanel.Controls.Add(this.eventName_input);
            this.bottomPanel.Controls.Add(this.eventName_label);
            this.bottomPanel.Controls.Add(this.panel4);
            this.bottomPanel.Location = new System.Drawing.Point(24, 398);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1118, 264);
            this.bottomPanel.TabIndex = 2;
            // 
            // eventPrice_input
            // 
            this.eventPrice_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventPrice_input.Location = new System.Drawing.Point(826, 41);
            this.eventPrice_input.Margin = new System.Windows.Forms.Padding(4);
            this.eventPrice_input.Name = "eventPrice_input";
            this.eventPrice_input.Size = new System.Drawing.Size(113, 24);
            this.eventPrice_input.TabIndex = 23;
            // 
            // eventPrice_label
            // 
            this.eventPrice_label.AutoSize = true;
            this.eventPrice_label.Font = new System.Drawing.Font("Tahoma", 9F);
            this.eventPrice_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.eventPrice_label.Location = new System.Drawing.Point(773, 43);
            this.eventPrice_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventPrice_label.Name = "eventPrice_label";
            this.eventPrice_label.Size = new System.Drawing.Size(43, 18);
            this.eventPrice_label.TabIndex = 22;
            this.eventPrice_label.Text = "Price:";
            // 
            // eventSDate_input
            // 
            this.eventSDate_input.Location = new System.Drawing.Point(522, 84);
            this.eventSDate_input.MaxDate = new System.DateTime(2025, 4, 30, 0, 0, 0, 0);
            this.eventSDate_input.MinDate = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            this.eventSDate_input.Name = "eventSDate_input";
            this.eventSDate_input.Size = new System.Drawing.Size(217, 22);
            this.eventSDate_input.TabIndex = 20;
            this.eventSDate_input.Value = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            // 
            // clearAllFields_btn
            // 
            this.clearAllFields_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.clearAllFields_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllFields_btn.FlatAppearance.BorderSize = 0;
            this.clearAllFields_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.clearAllFields_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.clearAllFields_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.clearAllFields_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllFields_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllFields_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.clearAllFields_btn.Location = new System.Drawing.Point(788, 201);
            this.clearAllFields_btn.Margin = new System.Windows.Forms.Padding(4);
            this.clearAllFields_btn.Name = "clearAllFields_btn";
            this.clearAllFields_btn.Size = new System.Drawing.Size(151, 46);
            this.clearAllFields_btn.TabIndex = 17;
            this.clearAllFields_btn.Text = "Clear";
            this.clearAllFields_btn.UseVisualStyleBackColor = false;
            this.clearAllFields_btn.Click += new System.EventHandler(this.addEvent_clearBtn_Click);
            // 
            // deleteEvent_btn
            // 
            this.deleteEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.deleteEvent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteEvent_btn.FlatAppearance.BorderSize = 0;
            this.deleteEvent_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.deleteEvent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.deleteEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.deleteEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEvent_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEvent_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.deleteEvent_btn.Location = new System.Drawing.Point(615, 201);
            this.deleteEvent_btn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteEvent_btn.Name = "deleteEvent_btn";
            this.deleteEvent_btn.Size = new System.Drawing.Size(151, 46);
            this.deleteEvent_btn.TabIndex = 16;
            this.deleteEvent_btn.Text = "Delete";
            this.deleteEvent_btn.UseVisualStyleBackColor = false;
            this.deleteEvent_btn.Click += new System.EventHandler(this.addEvent_deleteBtn_Click);
            // 
            // updateEvent_btn
            // 
            this.updateEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.updateEvent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateEvent_btn.FlatAppearance.BorderSize = 0;
            this.updateEvent_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.updateEvent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.updateEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.updateEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEvent_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEvent_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.updateEvent_btn.Location = new System.Drawing.Point(416, 201);
            this.updateEvent_btn.Margin = new System.Windows.Forms.Padding(4);
            this.updateEvent_btn.Name = "updateEvent_btn";
            this.updateEvent_btn.Size = new System.Drawing.Size(151, 46);
            this.updateEvent_btn.TabIndex = 15;
            this.updateEvent_btn.Text = "Update";
            this.updateEvent_btn.UseVisualStyleBackColor = false;
            this.updateEvent_btn.Click += new System.EventHandler(this.addEvent_updateBtn_Click);
            // 
            // addEvent_btn
            // 
            this.addEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.addEvent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_btn.FlatAppearance.BorderSize = 0;
            this.addEvent_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEvent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.addEvent_btn.Location = new System.Drawing.Point(243, 201);
            this.addEvent_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent_btn.Name = "addEvent_btn";
            this.addEvent_btn.Size = new System.Drawing.Size(151, 46);
            this.addEvent_btn.TabIndex = 14;
            this.addEvent_btn.Text = "Add";
            this.addEvent_btn.UseVisualStyleBackColor = false;
            this.addEvent_btn.Click += new System.EventHandler(this.addEvent_addBtn_Click);
            // 
            // eventPhoto_import_btn
            // 
            this.eventPhoto_import_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.eventPhoto_import_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventPhoto_import_btn.FlatAppearance.BorderSize = 0;
            this.eventPhoto_import_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.eventPhoto_import_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.eventPhoto_import_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventPhoto_import_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventPhoto_import_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.eventPhoto_import_btn.Location = new System.Drawing.Point(983, 155);
            this.eventPhoto_import_btn.Margin = new System.Windows.Forms.Padding(4);
            this.eventPhoto_import_btn.Name = "eventPhoto_import_btn";
            this.eventPhoto_import_btn.Size = new System.Drawing.Size(109, 28);
            this.eventPhoto_import_btn.TabIndex = 13;
            this.eventPhoto_import_btn.Text = "Import";
            this.eventPhoto_import_btn.UseVisualStyleBackColor = false;
            this.eventPhoto_import_btn.Click += new System.EventHandler(this.addEvent_importBtn_Click);
            // 
            // eventPhoto
            // 
            this.eventPhoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.eventPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventPhoto.Location = new System.Drawing.Point(984, 42);
            this.eventPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.eventPhoto.Name = "eventPhoto";
            this.eventPhoto.Size = new System.Drawing.Size(109, 113);
            this.eventPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventPhoto.TabIndex = 12;
            this.eventPhoto.TabStop = false;
            // 
            // eventSDate_label
            // 
            this.eventSDate_label.AutoSize = true;
            this.eventSDate_label.Font = new System.Drawing.Font("Tahoma", 9F);
            this.eventSDate_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.eventSDate_label.Location = new System.Drawing.Point(436, 84);
            this.eventSDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventSDate_label.Name = "eventSDate_label";
            this.eventSDate_label.Size = new System.Drawing.Size(80, 18);
            this.eventSDate_label.TabIndex = 10;
            this.eventSDate_label.Text = "Start Date:";
            // 
            // eventLocation_input
            // 
            this.eventLocation_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLocation_input.Location = new System.Drawing.Point(514, 41);
            this.eventLocation_input.Margin = new System.Windows.Forms.Padding(4);
            this.eventLocation_input.Name = "eventLocation_input";
            this.eventLocation_input.Size = new System.Drawing.Size(225, 24);
            this.eventLocation_input.TabIndex = 9;
            // 
            // eventLocation_label
            // 
            this.eventLocation_label.AutoSize = true;
            this.eventLocation_label.Font = new System.Drawing.Font("Tahoma", 9F);
            this.eventLocation_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.eventLocation_label.Location = new System.Drawing.Point(401, 44);
            this.eventLocation_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventLocation_label.Name = "eventLocation_label";
            this.eventLocation_label.Size = new System.Drawing.Size(103, 18);
            this.eventLocation_label.TabIndex = 8;
            this.eventLocation_label.Text = "Event location:";
            // 
            // eventDesc_input
            // 
            this.eventDesc_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDesc_input.Location = new System.Drawing.Point(135, 91);
            this.eventDesc_input.Margin = new System.Windows.Forms.Padding(4);
            this.eventDesc_input.Multiline = true;
            this.eventDesc_input.Name = "eventDesc_input";
            this.eventDesc_input.Size = new System.Drawing.Size(225, 78);
            this.eventDesc_input.TabIndex = 5;
            // 
            // eventDesc_label
            // 
            this.eventDesc_label.AutoSize = true;
            this.eventDesc_label.Font = new System.Drawing.Font("Tahoma", 9F);
            this.eventDesc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.eventDesc_label.Location = new System.Drawing.Point(36, 91);
            this.eventDesc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventDesc_label.Name = "eventDesc_label";
            this.eventDesc_label.Size = new System.Drawing.Size(83, 18);
            this.eventDesc_label.TabIndex = 4;
            this.eventDesc_label.Text = "Description:";
            // 
            // eventName_input
            // 
            this.eventName_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName_input.Location = new System.Drawing.Point(135, 42);
            this.eventName_input.Margin = new System.Windows.Forms.Padding(4);
            this.eventName_input.Name = "eventName_input";
            this.eventName_input.Size = new System.Drawing.Size(225, 24);
            this.eventName_input.TabIndex = 3;
            // 
            // eventName_label
            // 
            this.eventName_label.AutoSize = true;
            this.eventName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.eventName_label.Location = new System.Drawing.Point(36, 45);
            this.eventName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventName_label.Name = "eventName_label";
            this.eventName_label.Size = new System.Drawing.Size(94, 18);
            this.eventName_label.TabIndex = 2;
            this.eventName_label.Text = "Event Name:";
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
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEvent";
            this.Size = new System.Drawing.Size(1167, 695);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet2)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView eventsDataGrid;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox eventDesc_input;
        private System.Windows.Forms.Label eventDesc_label;
        private System.Windows.Forms.TextBox eventName_input;
        private System.Windows.Forms.Label eventName_label;
        private System.Windows.Forms.TextBox eventLocation_input;
        private System.Windows.Forms.Label eventLocation_label;
        private System.Windows.Forms.Label eventSDate_label;
        private System.Windows.Forms.Button clearAllFields_btn;
        private System.Windows.Forms.Button deleteEvent_btn;
        private System.Windows.Forms.Button updateEvent_btn;
        private System.Windows.Forms.Button addEvent_btn;
        private System.Windows.Forms.Button eventPhoto_import_btn;
        private System.Windows.Forms.PictureBox eventPhoto;
        private System.Windows.Forms.DateTimePicker eventSDate_input;
        private System.Windows.Forms.TextBox eventPrice_input;
        private System.Windows.Forms.Label eventPrice_label;
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
