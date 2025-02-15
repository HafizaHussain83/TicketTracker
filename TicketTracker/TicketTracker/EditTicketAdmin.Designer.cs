namespace TicketTracker
{
    partial class EditTicketAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label labNameLabel;
            System.Windows.Forms.Label assignedToLabel;
            System.Windows.Forms.Label openByLabel;
            System.Windows.Forms.Label openDateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label relatedIssuesLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label titleLabel;
            this.ticketDataSet = new TicketTracker.TicketDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new TicketTracker.TicketDataSetTableAdapters.TicketTableAdapter();
            this.tableAdapterManager = new TicketTracker.TicketDataSetTableAdapters.TableAdapterManager();
            this.employeeDataSet = new TicketTracker.EmployeeDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TicketTracker.EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            this.submitbtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.labNameTextBox = new System.Windows.Forms.TextBox();
            this.openByTextBox = new System.Windows.Forms.TextBox();
            this.openDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.relatedIssuesTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            labNameLabel = new System.Windows.Forms.Label();
            assignedToLabel = new System.Windows.Forms.Label();
            openByLabel = new System.Windows.Forms.Label();
            openDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            relatedIssuesLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(24, 60);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 96;
            iDLabel.Text = "ID:";
            // 
            // labNameLabel
            // 
            labNameLabel.AutoSize = true;
            labNameLabel.Location = new System.Drawing.Point(24, 88);
            labNameLabel.Name = "labNameLabel";
            labNameLabel.Size = new System.Drawing.Size(73, 16);
            labNameLabel.TabIndex = 97;
            labNameLabel.Text = "Lab Name:";
            // 
            // assignedToLabel
            // 
            assignedToLabel.AutoSize = true;
            assignedToLabel.Location = new System.Drawing.Point(24, 116);
            assignedToLabel.Name = "assignedToLabel";
            assignedToLabel.Size = new System.Drawing.Size(87, 16);
            assignedToLabel.TabIndex = 98;
            assignedToLabel.Text = "Assigned To:";
            // 
            // openByLabel
            // 
            openByLabel.AutoSize = true;
            openByLabel.Location = new System.Drawing.Point(24, 144);
            openByLabel.Name = "openByLabel";
            openByLabel.Size = new System.Drawing.Size(62, 16);
            openByLabel.TabIndex = 99;
            openByLabel.Text = "Open By:";
            // 
            // openDateLabel
            // 
            openDateLabel.AutoSize = true;
            openDateLabel.Location = new System.Drawing.Point(24, 173);
            openDateLabel.Name = "openDateLabel";
            openDateLabel.Size = new System.Drawing.Size(75, 16);
            openDateLabel.TabIndex = 100;
            openDateLabel.Text = "Open Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(24, 200);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 101;
            statusLabel.Text = "Status:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(24, 228);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(65, 16);
            categoryLabel.TabIndex = 102;
            categoryLabel.Text = "Category:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(24, 256);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(51, 16);
            priorityLabel.TabIndex = 103;
            priorityLabel.Text = "Priority:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(24, 368);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 104;
            descriptionLabel.Text = "Description:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(24, 285);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(67, 16);
            dueDateLabel.TabIndex = 105;
            dueDateLabel.Text = "Due Date:";
            // 
            // relatedIssuesLabel
            // 
            relatedIssuesLabel.AutoSize = true;
            relatedIssuesLabel.Location = new System.Drawing.Point(24, 312);
            relatedIssuesLabel.Name = "relatedIssuesLabel";
            relatedIssuesLabel.Size = new System.Drawing.Size(100, 16);
            relatedIssuesLabel.TabIndex = 106;
            relatedIssuesLabel.Text = "Related Issues:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(24, 396);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(74, 16);
            commentsLabel.TabIndex = 107;
            commentsLabel.Text = "Comments:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(24, 340);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(85, 16);
            titleLabel.TabIndex = 108;
            titleLabel.Text = "Title/Subject:";
            // 
            // ticketDataSet
            // 
            this.ticketDataSet.DataSetName = "TicketDataSet";
            this.ticketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.ticketDataSet;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TicketTableAdapter = this.ticketTableAdapter;
            this.tableAdapterManager.UpdateOrder = TicketTracker.TicketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitbtn.Location = new System.Drawing.Point(667, 537);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(99, 33);
            this.submitbtn.TabIndex = 95;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pending",
            "In Process",
            "Completed"});
            this.comboBox2.Location = new System.Drawing.Point(130, 196);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 87;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.comboBox4.Location = new System.Drawing.Point(130, 252);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 24);
            this.comboBox4.TabIndex = 89;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 84;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(130, 57);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(39, 22);
            this.iDTextBox.TabIndex = 82;
            // 
            // labNameTextBox
            // 
            this.labNameTextBox.Location = new System.Drawing.Point(130, 85);
            this.labNameTextBox.Name = "labNameTextBox";
            this.labNameTextBox.ReadOnly = true;
            this.labNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.labNameTextBox.TabIndex = 83;
            // 
            // openByTextBox
            // 
            this.openByTextBox.Location = new System.Drawing.Point(130, 141);
            this.openByTextBox.Name = "openByTextBox";
            this.openByTextBox.ReadOnly = true;
            this.openByTextBox.Size = new System.Drawing.Size(200, 22);
            this.openByTextBox.TabIndex = 85;
            // 
            // openDateDateTimePicker
            // 
            this.openDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.openDateDateTimePicker.Location = new System.Drawing.Point(130, 169);
            this.openDateDateTimePicker.Name = "openDateDateTimePicker";
            this.openDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.openDateDateTimePicker.TabIndex = 86;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(130, 225);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(200, 22);
            this.categoryTextBox.TabIndex = 88;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(130, 365);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(636, 22);
            this.descriptionTextBox.TabIndex = 93;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(130, 281);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dueDateDateTimePicker.TabIndex = 90;
            // 
            // relatedIssuesTextBox
            // 
            this.relatedIssuesTextBox.Location = new System.Drawing.Point(130, 309);
            this.relatedIssuesTextBox.Name = "relatedIssuesTextBox";
            this.relatedIssuesTextBox.Size = new System.Drawing.Size(200, 22);
            this.relatedIssuesTextBox.TabIndex = 91;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(130, 393);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.Size = new System.Drawing.Size(636, 102);
            this.commentsTextBox.TabIndex = 94;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(130, 337);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(382, 22);
            this.titleTextBox.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "label2";
            // 
            // EditTicketAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(labNameLabel);
            this.Controls.Add(this.labNameTextBox);
            this.Controls.Add(assignedToLabel);
            this.Controls.Add(openByLabel);
            this.Controls.Add(this.openByTextBox);
            this.Controls.Add(openDateLabel);
            this.Controls.Add(this.openDateDateTimePicker);
            this.Controls.Add(statusLabel);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateDateTimePicker);
            this.Controls.Add(relatedIssuesLabel);
            this.Controls.Add(this.relatedIssuesTextBox);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "EditTicketAdmin";
            this.Text = "EditTicketAdmin";
            this.Load += new System.EventHandler(this.EditTicketAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TicketDataSet ticketDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private TicketDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private TicketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button submitbtn;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox iDTextBox;
        public System.Windows.Forms.TextBox labNameTextBox;
        public System.Windows.Forms.TextBox openByTextBox;
        public System.Windows.Forms.DateTimePicker openDateDateTimePicker;
        public System.Windows.Forms.TextBox categoryTextBox;
        public System.Windows.Forms.TextBox descriptionTextBox;
        public System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        public System.Windows.Forms.TextBox relatedIssuesTextBox;
        public System.Windows.Forms.TextBox commentsTextBox;
        public System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}