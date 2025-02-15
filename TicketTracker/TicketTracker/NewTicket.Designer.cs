namespace TicketTracker
{
    partial class NewTicket
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label openedByLabel;
            System.Windows.Forms.Label openedDateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label relatedIssuesLabel;
            System.Windows.Forms.Label commentsLabel;
            this.LabNametxt = new System.Windows.Forms.TextBox();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketDataSet = new TicketTracker.TicketDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.openedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.relatedIssuesTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.ticketTableAdapter = new TicketTracker.TicketDataSetTableAdapters.TicketTableAdapter();
            this.OpenedBytxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.unameLabel = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.newticketlbl = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            openedByLabel = new System.Windows.Forms.Label();
            openedDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            relatedIssuesLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(11, 345);
            titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(100, 20);
            titleLabel.TabIndex = 36;
            titleLabel.Text = "Title/Subject:";
            // 
            // openedByLabel
            // 
            openedByLabel.AutoSize = true;
            openedByLabel.Location = new System.Drawing.Point(10, 109);
            openedByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            openedByLabel.Name = "openedByLabel";
            openedByLabel.Size = new System.Drawing.Size(92, 20);
            openedByLabel.TabIndex = 39;
            openedByLabel.Text = "Opened By:";
            // 
            // openedDateLabel
            // 
            openedDateLabel.AutoSize = true;
            openedDateLabel.Location = new System.Drawing.Point(9, 140);
            openedDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            openedDateLabel.Name = "openedDateLabel";
            openedDateLabel.Size = new System.Drawing.Size(109, 20);
            openedDateLabel.TabIndex = 40;
            openedDateLabel.Text = "Opened Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(11, 175);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(60, 20);
            statusLabel.TabIndex = 42;
            statusLabel.Text = "Status:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(11, 210);
            categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(77, 20);
            categoryLabel.TabIndex = 43;
            categoryLabel.Text = "Category:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(11, 242);
            priorityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(60, 20);
            priorityLabel.TabIndex = 45;
            priorityLabel.Text = "Priority:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(11, 378);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 46;
            descriptionLabel.Text = "Description:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(9, 280);
            dueDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(82, 20);
            dueDateLabel.TabIndex = 48;
            dueDateLabel.Text = "Due Date:";
            // 
            // relatedIssuesLabel
            // 
            relatedIssuesLabel.AutoSize = true;
            relatedIssuesLabel.Location = new System.Drawing.Point(10, 312);
            relatedIssuesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            relatedIssuesLabel.Name = "relatedIssuesLabel";
            relatedIssuesLabel.Size = new System.Drawing.Size(120, 20);
            relatedIssuesLabel.TabIndex = 50;
            relatedIssuesLabel.Text = "Related Issues:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(9, 410);
            commentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(90, 20);
            commentsLabel.TabIndex = 52;
            commentsLabel.Text = "Comments:";
            // 
            // LabNametxt
            // 
            this.LabNametxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "LabName", true));
            this.LabNametxt.Location = new System.Drawing.Point(127, 71);
            this.LabNametxt.Margin = new System.Windows.Forms.Padding(2);
            this.LabNametxt.Name = "LabNametxt";
            this.LabNametxt.ReadOnly = true;
            this.LabNametxt.Size = new System.Drawing.Size(169, 26);
            this.LabNametxt.TabIndex = 2;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.ticketDataSet;
            // 
            // ticketDataSet
            // 
            this.ticketDataSet.DataSetName = "TicketDataSet";
            this.ticketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Lab Name:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Please Select an Option",
            "High",
            "Normal",
            "Low"});
            this.comboBox4.Location = new System.Drawing.Point(127, 239);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(169, 28);
            this.comboBox4.TabIndex = 7;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(127, 341);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(276, 26);
            this.titleTextBox.TabIndex = 10;
            // 
            // openedDateDateTimePicker
            // 
            this.openedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.openedDateDateTimePicker.Location = new System.Drawing.Point(127, 139);
            this.openedDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.openedDateDateTimePicker.Name = "openedDateDateTimePicker";
            this.openedDateDateTimePicker.Size = new System.Drawing.Size(169, 26);
            this.openedDateDateTimePicker.TabIndex = 4;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(127, 206);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(169, 26);
            this.categoryTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(127, 374);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(566, 26);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(127, 274);
            this.dueDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(169, 26);
            this.dueDateDateTimePicker.TabIndex = 8;
            // 
            // relatedIssuesTextBox
            // 
            this.relatedIssuesTextBox.Location = new System.Drawing.Point(127, 309);
            this.relatedIssuesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.relatedIssuesTextBox.Name = "relatedIssuesTextBox";
            this.relatedIssuesTextBox.Size = new System.Drawing.Size(169, 26);
            this.relatedIssuesTextBox.TabIndex = 9;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(127, 406);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(566, 152);
            this.commentsTextBox.TabIndex = 12;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // OpenedBytxtbox
            // 
            this.OpenedBytxtbox.Location = new System.Drawing.Point(127, 105);
            this.OpenedBytxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenedBytxtbox.Name = "OpenedBytxtbox";
            this.OpenedBytxtbox.ReadOnly = true;
            this.OpenedBytxtbox.Size = new System.Drawing.Size(169, 26);
            this.OpenedBytxtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(693, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "User:";
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(127, 171);
            this.statustxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statustxt.Name = "statustxt";
            this.statustxt.ReadOnly = true;
            this.statustxt.Size = new System.Drawing.Size(169, 26);
            this.statustxt.TabIndex = 5;
            // 
            // unameLabel
            // 
            this.unameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unameLabel.AutoSize = true;
            this.unameLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.unameLabel.Location = new System.Drawing.Point(744, 11);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(51, 20);
            this.unameLabel.TabIndex = 68;
            this.unameLabel.Text = "label3";
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitbtn.Location = new System.Drawing.Point(582, 564);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(111, 41);
            this.submitbtn.TabIndex = 13;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // newticketlbl
            // 
            this.newticketlbl.AutoSize = true;
            this.newticketlbl.Location = new System.Drawing.Point(11, 11);
            this.newticketlbl.Name = "newticketlbl";
            this.newticketlbl.Size = new System.Drawing.Size(90, 20);
            this.newticketlbl.TabIndex = 69;
            this.newticketlbl.Text = "New Ticket:";
            // 
            // NewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 630);
            this.Controls.Add(this.newticketlbl);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.unameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.OpenedBytxtbox);
            this.Controls.Add(this.LabNametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(openedByLabel);
            this.Controls.Add(openedDateLabel);
            this.Controls.Add(this.openedDateDateTimePicker);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewTicket";
            this.Text = "NewTicket";
            this.Load += new System.EventHandler(this.NewTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LabNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker openedDateDateTimePicker;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox relatedIssuesTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private TicketDataSet ticketDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private TicketDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.TextBox OpenedBytxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label newticketlbl;
    }
}