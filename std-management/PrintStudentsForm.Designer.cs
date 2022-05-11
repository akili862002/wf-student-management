
namespace std_management
{
    partial class PrintStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintStudentsForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.allGenderRadio = new System.Windows.Forms.RadioButton();
            this.famaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.studentTableData = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.avatarURLCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.useDateRangeCheckbox = new System.Windows.Forms.CheckBox();
            this.saveAsTextFileButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.rangeDatePickerPanel = new System.Windows.Forms.Panel();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableData)).BeginInit();
            this.rangeDatePickerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(176, 32);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Print students";
            // 
            // allGenderRadio
            // 
            this.allGenderRadio.AutoSize = true;
            this.allGenderRadio.Checked = true;
            this.allGenderRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allGenderRadio.Location = new System.Drawing.Point(17, 64);
            this.allGenderRadio.Margin = new System.Windows.Forms.Padding(2);
            this.allGenderRadio.Name = "allGenderRadio";
            this.allGenderRadio.Size = new System.Drawing.Size(80, 19);
            this.allGenderRadio.TabIndex = 10;
            this.allGenderRadio.TabStop = true;
            this.allGenderRadio.Text = "All Gender";
            this.allGenderRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allGenderRadio.UseVisualStyleBackColor = true;
            // 
            // famaleRadio
            // 
            this.famaleRadio.AutoSize = true;
            this.famaleRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famaleRadio.Location = new System.Drawing.Point(17, 110);
            this.famaleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.famaleRadio.Name = "famaleRadio";
            this.famaleRadio.Size = new System.Drawing.Size(63, 19);
            this.famaleRadio.TabIndex = 12;
            this.famaleRadio.Text = "Famale";
            this.famaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(17, 87);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(51, 19);
            this.maleRadio.TabIndex = 11;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fromDatePicker.Location = new System.Drawing.Point(2, 20);
            this.fromDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(102, 20);
            this.fromDatePicker.TabIndex = 29;
            this.fromDatePicker.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLabel.Location = new System.Drawing.Point(-2, 0);
            this.fromDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(41, 19);
            this.fromDateLabel.TabIndex = 30;
            this.fromDateLabel.Text = "From";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.Location = new System.Drawing.Point(111, 0);
            this.toDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(24, 19);
            this.toDateLabel.TabIndex = 32;
            this.toDateLabel.Text = "To";
            // 
            // toDatePicker
            // 
            this.toDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toDatePicker.Location = new System.Drawing.Point(108, 20);
            this.toDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(96, 20);
            this.toDatePicker.TabIndex = 31;
            this.toDatePicker.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // studentTableData
            // 
            this.studentTableData.AllowUserToAddRows = false;
            this.studentTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTableData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.studentTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.first_name,
            this.last_name,
            this.birth_date,
            this.gender,
            this.phone,
            this.address,
            this.avatarImg,
            this.avatarURLCol});
            this.studentTableData.Location = new System.Drawing.Point(17, 135);
            this.studentTableData.Margin = new System.Windows.Forms.Padding(4);
            this.studentTableData.Name = "studentTableData";
            this.studentTableData.RowHeadersWidth = 51;
            this.studentTableData.Size = new System.Drawing.Size(904, 410);
            this.studentTableData.TabIndex = 33;
            this.studentTableData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.studentTableData_CellFormatting);
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First name";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last name";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // birth_date
            // 
            this.birth_date.DataPropertyName = "birthdate";
            this.birth_date.HeaderText = "Birthdate";
            this.birth_date.MinimumWidth = 6;
            this.birth_date.Name = "birth_date";
            this.birth_date.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 50;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // avatarImg
            // 
            this.avatarImg.DataPropertyName = "avatarImg";
            this.avatarImg.HeaderText = "Avatar";
            this.avatarImg.Image = global::std_management.Properties.Resources.avatar;
            this.avatarImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.avatarImg.MinimumWidth = 6;
            this.avatarImg.Name = "avatarImg";
            this.avatarImg.ReadOnly = true;
            this.avatarImg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.avatarImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.avatarImg.Width = 125;
            // 
            // avatarURLCol
            // 
            this.avatarURLCol.DataPropertyName = "avatar";
            this.avatarURLCol.HeaderText = "AvatarURL";
            this.avatarURLCol.MinimumWidth = 6;
            this.avatarURLCol.Name = "avatarURLCol";
            this.avatarURLCol.ReadOnly = true;
            this.avatarURLCol.Visible = false;
            this.avatarURLCol.Width = 125;
            // 
            // studentTableLoadingProgress
            // 
            this.studentTableLoadingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTableLoadingProgress.Location = new System.Drawing.Point(771, 552);
            this.studentTableLoadingProgress.Margin = new System.Windows.Forms.Padding(4);
            this.studentTableLoadingProgress.Name = "studentTableLoadingProgress";
            this.studentTableLoadingProgress.Size = new System.Drawing.Size(150, 21);
            this.studentTableLoadingProgress.Step = 1;
            this.studentTableLoadingProgress.TabIndex = 34;
            // 
            // useDateRangeCheckbox
            // 
            this.useDateRangeCheckbox.AutoSize = true;
            this.useDateRangeCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useDateRangeCheckbox.Location = new System.Drawing.Point(156, 63);
            this.useDateRangeCheckbox.Name = "useDateRangeCheckbox";
            this.useDateRangeCheckbox.Size = new System.Drawing.Size(94, 21);
            this.useDateRangeCheckbox.TabIndex = 35;
            this.useDateRangeCheckbox.Text = "Date range";
            this.useDateRangeCheckbox.UseVisualStyleBackColor = true;
            this.useDateRangeCheckbox.CheckedChanged += new System.EventHandler(this.useDateRangeCheckbox_CheckedChanged);
            // 
            // saveAsTextFileButton
            // 
            this.saveAsTextFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAsTextFileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveAsTextFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsTextFileButton.Location = new System.Drawing.Point(16, 552);
            this.saveAsTextFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveAsTextFileButton.Name = "saveAsTextFileButton";
            this.saveAsTextFileButton.Size = new System.Drawing.Size(136, 32);
            this.saveAsTextFileButton.TabIndex = 36;
            this.saveAsTextFileButton.Text = "Save as text file";
            this.saveAsTextFileButton.UseVisualStyleBackColor = false;
            this.saveAsTextFileButton.Click += new System.EventHandler(this.saveAsTextFileButton_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.printButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(156, 552);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(90, 32);
            this.printButton.TabIndex = 37;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(820, 97);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refreshButton.Size = new System.Drawing.Size(101, 30);
            this.refreshButton.TabIndex = 38;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // rangeDatePickerPanel
            // 
            this.rangeDatePickerPanel.Controls.Add(this.fromDatePicker);
            this.rangeDatePickerPanel.Controls.Add(this.fromDateLabel);
            this.rangeDatePickerPanel.Controls.Add(this.toDatePicker);
            this.rangeDatePickerPanel.Controls.Add(this.toDateLabel);
            this.rangeDatePickerPanel.Location = new System.Drawing.Point(156, 87);
            this.rangeDatePickerPanel.Name = "rangeDatePickerPanel";
            this.rangeDatePickerPanel.Size = new System.Drawing.Size(206, 42);
            this.rangeDatePickerPanel.TabIndex = 39;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // PrintStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 596);
            this.Controls.Add(this.rangeDatePickerPanel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveAsTextFileButton);
            this.Controls.Add(this.useDateRangeCheckbox);
            this.Controls.Add(this.studentTableLoadingProgress);
            this.Controls.Add(this.studentTableData);
            this.Controls.Add(this.famaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.allGenderRadio);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PrintStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrintStudents";
            this.Load += new System.EventHandler(this.PrintStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentTableData)).EndInit();
            this.rangeDatePickerPanel.ResumeLayout(false);
            this.rangeDatePickerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton allGenderRadio;
        private System.Windows.Forms.RadioButton famaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DataGridView studentTableData;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewImageColumn avatarImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarURLCol;
        private System.Windows.Forms.ProgressBar studentTableLoadingProgress;
        private System.Windows.Forms.CheckBox useDateRangeCheckbox;
        private System.Windows.Forms.Button saveAsTextFileButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel rangeDatePickerPanel;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}