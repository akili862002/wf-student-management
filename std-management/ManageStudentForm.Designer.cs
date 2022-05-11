namespace std_management
{
    partial class ManageStudentForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.stdCodeErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stdCodeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.uploadAvatarButton = new System.Windows.Forms.Button();
            this.avatarLabel = new System.Windows.Forms.Label();
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.birthdateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.famaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentTableLoadingProgress = new System.Windows.Forms.ProgressBar();
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(11, 522);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 37);
            this.deleteButton.TabIndex = 59;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addressErrorLabel.Location = new System.Drawing.Point(180, 417);
            this.addressErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.addressErrorLabel.TabIndex = 58;
            this.addressErrorLabel.Text = "Error will be like this!";
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(180, 300);
            this.phoneErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.phoneErrorLabel.TabIndex = 57;
            this.phoneErrorLabel.Text = "Error will be like this!";
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(300, 175);
            this.lastNameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.lastNameErrorLabel.TabIndex = 56;
            this.lastNameErrorLabel.Text = "Error will be like this!";
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(180, 175);
            this.firstNameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.firstNameErrorLabel.TabIndex = 55;
            this.firstNameErrorLabel.Text = "Error will be like this!";
            // 
            // stdCodeErrorLabel
            // 
            this.stdCodeErrorLabel.AutoSize = true;
            this.stdCodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.stdCodeErrorLabel.Location = new System.Drawing.Point(180, 109);
            this.stdCodeErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdCodeErrorLabel.Name = "stdCodeErrorLabel";
            this.stdCodeErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.stdCodeErrorLabel.TabIndex = 54;
            this.stdCodeErrorLabel.Text = "Error will be like this!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Student code";
            // 
            // stdCodeTextBox
            // 
            this.stdCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeTextBox.Location = new System.Drawing.Point(181, 80);
            this.stdCodeTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stdCodeTextBox.Name = "stdCodeTextBox";
            this.stdCodeTextBox.Size = new System.Drawing.Size(251, 26);
            this.stdCodeTextBox.TabIndex = 34;
            this.stdCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stdCodeTextBox_KeyPress);
            this.stdCodeTextBox.Leave += new System.EventHandler(this.stdCodeTextBox_Leave);
            this.stdCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stdCodeTextBox_Validating);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.submitButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(207, 516);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 43);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.BackColor = System.Drawing.Color.Orange;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(2, 3);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 37);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(114, 3);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 37);
            this.submitButton.TabIndex = 23;
            this.submitButton.Text = "Create";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // uploadAvatarButton
            // 
            this.uploadAvatarButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadAvatarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadAvatarButton.Location = new System.Drawing.Point(11, 235);
            this.uploadAvatarButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uploadAvatarButton.Name = "uploadAvatarButton";
            this.uploadAvatarButton.Size = new System.Drawing.Size(150, 28);
            this.uploadAvatarButton.TabIndex = 51;
            this.uploadAvatarButton.Text = "Upload";
            this.uploadAvatarButton.UseVisualStyleBackColor = false;
            this.uploadAvatarButton.Click += new System.EventHandler(this.uploadAvatarButton_Click);
            // 
            // avatarLabel
            // 
            this.avatarLabel.AutoSize = true;
            this.avatarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarLabel.Location = new System.Drawing.Point(7, 58);
            this.avatarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avatarLabel.Name = "avatarLabel";
            this.avatarLabel.Size = new System.Drawing.Size(53, 19);
            this.avatarLabel.TabIndex = 50;
            this.avatarLabel.Text = "Picture";
            // 
            // avatarPicture
            // 
            this.avatarPicture.Image = global::std_management.Properties.Resources.graduated;
            this.avatarPicture.InitialImage = global::std_management.Properties.Resources.graduated;
            this.avatarPicture.Location = new System.Drawing.Point(11, 80);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(2);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(150, 150);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPicture.TabIndex = 49;
            this.avatarPicture.TabStop = false;
            // 
            // birthdateDatePicker
            // 
            this.birthdateDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthdateDatePicker.Location = new System.Drawing.Point(180, 221);
            this.birthdateDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.birthdateDatePicker.Name = "birthdateDatePicker";
            this.birthdateDatePicker.Size = new System.Drawing.Size(251, 20);
            this.birthdateDatePicker.TabIndex = 38;
            this.birthdateDatePicker.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // famaleRadio
            // 
            this.famaleRadio.AutoSize = true;
            this.famaleRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famaleRadio.Location = new System.Drawing.Point(246, 457);
            this.famaleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.famaleRadio.Name = "famaleRadio";
            this.famaleRadio.Size = new System.Drawing.Size(63, 19);
            this.famaleRadio.TabIndex = 44;
            this.famaleRadio.Text = "Famale";
            this.famaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(183, 457);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(51, 19);
            this.maleRadio.TabIndex = 43;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(177, 432);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 19);
            this.genderLabel.TabIndex = 48;
            this.genderLabel.Text = "Gender";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(177, 316);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 19);
            this.addressLabel.TabIndex = 47;
            this.addressLabel.Text = "Address";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.Location = new System.Drawing.Point(180, 338);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addressTextbox.Multiline = true;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(252, 76);
            this.addressTextbox.TabIndex = 41;
            this.addressTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextbox_Validating);
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.Location = new System.Drawing.Point(177, 196);
            this.birthdateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(66, 19);
            this.birthdateLabel.TabIndex = 46;
            this.birthdateLabel.Text = "Birthdate";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(177, 249);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(48, 19);
            this.phoneLabel.TabIndex = 45;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(180, 271);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(252, 26);
            this.phoneTextBox.TabIndex = 39;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            this.phoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneTextBox_Validating);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.Location = new System.Drawing.Point(299, 124);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(72, 19);
            this.lastnameLabel.TabIndex = 42;
            this.lastnameLabel.Text = "Last name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(299, 146);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(133, 26);
            this.lastNameTextBox.TabIndex = 36;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastNameTextBox_Validating);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(9, 8);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(202, 32);
            this.titleLabel.TabIndex = 40;
            this.titleLabel.Text = "Manage Student";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.Location = new System.Drawing.Point(178, 124);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(74, 19);
            this.firstnameLabel.TabIndex = 37;
            this.firstnameLabel.Text = "First name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(181, 146);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(114, 26);
            this.firstNameTextBox.TabIndex = 35;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextBox_KeyPress);
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
            // 
            // studentTableLoadingProgress
            // 
            this.studentTableLoadingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTableLoadingProgress.Location = new System.Drawing.Point(1239, 530);
            this.studentTableLoadingProgress.Margin = new System.Windows.Forms.Padding(4);
            this.studentTableLoadingProgress.Name = "studentTableLoadingProgress";
            this.studentTableLoadingProgress.Size = new System.Drawing.Size(116, 30);
            this.studentTableLoadingProgress.Step = 1;
            this.studentTableLoadingProgress.TabIndex = 65;
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
            this.studentTableData.Location = new System.Drawing.Point(450, 80);
            this.studentTableData.Margin = new System.Windows.Forms.Padding(4);
            this.studentTableData.Name = "studentTableData";
            this.studentTableData.RowHeadersWidth = 51;
            this.studentTableData.Size = new System.Drawing.Size(905, 431);
            this.studentTableData.TabIndex = 64;
            this.studentTableData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTableData_CellDoubleClick);
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
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(1154, 530);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refreshButton.Size = new System.Drawing.Size(78, 30);
            this.refreshButton.TabIndex = 63;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(444, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(149, 32);
            this.loginLabel.TabIndex = 60;
            this.loginLabel.Text = "Student List";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1280, 40);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchButton.Size = new System.Drawing.Size(76, 32);
            this.searchButton.TabIndex = 61;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(1090, 43);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(184, 26);
            this.searchTextBox.TabIndex = 62;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.Location = new System.Drawing.Point(11, 269);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(150, 28);
            this.downloadButton.TabIndex = 66;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1368, 571);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.studentTableLoadingProgress);
            this.Controls.Add(this.studentTableData);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addressErrorLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.stdCodeErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stdCodeTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uploadAvatarButton);
            this.Controls.Add(this.avatarLabel);
            this.Controls.Add(this.avatarPicture);
            this.Controls.Add(this.birthdateDatePicker);
            this.Controls.Add(this.famaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "ManageStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label stdCodeErrorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stdCodeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button uploadAvatarButton;
        private System.Windows.Forms.Label avatarLabel;
        private System.Windows.Forms.PictureBox avatarPicture;
        private System.Windows.Forms.DateTimePicker birthdateDatePicker;
        private System.Windows.Forms.RadioButton famaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ProgressBar studentTableLoadingProgress;
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
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button downloadButton;
    }
}