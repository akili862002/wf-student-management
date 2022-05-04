
namespace std_management
{
    partial class AddStudentForm
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
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.famaleRadio = new System.Windows.Forms.RadioButton();
            this.birthdateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.avatarLabel = new System.Windows.Forms.Label();
            this.uploadAvatarButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.stdCodeErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stdCodeTextBox = new System.Windows.Forms.TextBox();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.Location = new System.Drawing.Point(178, 127);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(74, 19);
            this.firstnameLabel.TabIndex = 3;
            this.firstnameLabel.Text = "First name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(181, 149);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(180, 26);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextBox_KeyPress);
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(9, 11);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(236, 32);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Create new student";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.Location = new System.Drawing.Point(361, 127);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(72, 19);
            this.lastnameLabel.TabIndex = 8;
            this.lastnameLabel.Text = "Last name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(364, 149);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(135, 26);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastNameTextBox_Validating);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(177, 252);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(48, 19);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(180, 274);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(319, 26);
            this.phoneTextBox.TabIndex = 5;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            this.phoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneTextBox_Validating);
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.Location = new System.Drawing.Point(177, 199);
            this.birthdateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(66, 19);
            this.birthdateLabel.TabIndex = 12;
            this.birthdateLabel.Text = "Birthdate";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(177, 319);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 19);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.Location = new System.Drawing.Point(180, 341);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addressTextbox.Multiline = true;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(319, 76);
            this.addressTextbox.TabIndex = 6;
            this.addressTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextbox_Validating);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(177, 435);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 19);
            this.genderLabel.TabIndex = 16;
            this.genderLabel.Text = "Gender";
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(183, 460);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(51, 19);
            this.maleRadio.TabIndex = 9;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // famaleRadio
            // 
            this.famaleRadio.AutoSize = true;
            this.famaleRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famaleRadio.Location = new System.Drawing.Point(246, 460);
            this.famaleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.famaleRadio.Name = "famaleRadio";
            this.famaleRadio.Size = new System.Drawing.Size(63, 19);
            this.famaleRadio.TabIndex = 10;
            this.famaleRadio.Text = "Famale";
            this.famaleRadio.UseVisualStyleBackColor = true;
            // 
            // birthdateDatePicker
            // 
            this.birthdateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdateDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthdateDatePicker.Location = new System.Drawing.Point(180, 224);
            this.birthdateDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.birthdateDatePicker.Name = "birthdateDatePicker";
            this.birthdateDatePicker.Size = new System.Drawing.Size(318, 20);
            this.birthdateDatePicker.TabIndex = 4;
            this.birthdateDatePicker.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // avatarLabel
            // 
            this.avatarLabel.AutoSize = true;
            this.avatarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarLabel.Location = new System.Drawing.Point(14, 60);
            this.avatarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avatarLabel.Name = "avatarLabel";
            this.avatarLabel.Size = new System.Drawing.Size(49, 19);
            this.avatarLabel.TabIndex = 21;
            this.avatarLabel.Text = "Avatar";
            // 
            // uploadAvatarButton
            // 
            this.uploadAvatarButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadAvatarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadAvatarButton.Location = new System.Drawing.Point(18, 237);
            this.uploadAvatarButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uploadAvatarButton.Name = "uploadAvatarButton";
            this.uploadAvatarButton.Size = new System.Drawing.Size(150, 28);
            this.uploadAvatarButton.TabIndex = 22;
            this.uploadAvatarButton.Text = "Upload";
            this.uploadAvatarButton.UseVisualStyleBackColor = false;
            this.uploadAvatarButton.Click += new System.EventHandler(this.uploadAvatarButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(114, 3);
            this.createButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(109, 37);
            this.createButton.TabIndex = 23;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.DarkGray;
            this.cancelButton.Location = new System.Drawing.Point(2, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 37);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.createButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(274, 505);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 43);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // avatarPicture
            // 
            this.avatarPicture.Image = global::std_management.Properties.Resources.graduated;
            this.avatarPicture.Location = new System.Drawing.Point(18, 82);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(2);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(150, 150);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPicture.TabIndex = 20;
            this.avatarPicture.TabStop = false;
            // 
            // errorProviderFullName
            // 
            this.errorProviderFullName.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // stdCodeErrorLabel
            // 
            this.stdCodeErrorLabel.AutoSize = true;
            this.stdCodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.stdCodeErrorLabel.Location = new System.Drawing.Point(180, 112);
            this.stdCodeErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdCodeErrorLabel.Name = "stdCodeErrorLabel";
            this.stdCodeErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.stdCodeErrorLabel.TabIndex = 28;
            this.stdCodeErrorLabel.Text = "Error will be like this!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Student code";
            // 
            // stdCodeTextBox
            // 
            this.stdCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeTextBox.Location = new System.Drawing.Point(181, 83);
            this.stdCodeTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stdCodeTextBox.Name = "stdCodeTextBox";
            this.stdCodeTextBox.Size = new System.Drawing.Size(318, 26);
            this.stdCodeTextBox.TabIndex = 1;
            this.stdCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stdCodeTextBox_KeyPress);
            this.stdCodeTextBox.Leave += new System.EventHandler(this.stdCodeTextBox_Leave);
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(180, 178);
            this.firstNameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.firstNameErrorLabel.TabIndex = 29;
            this.firstNameErrorLabel.Text = "Error will be like this!";
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(362, 178);
            this.lastNameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.lastNameErrorLabel.TabIndex = 30;
            this.lastNameErrorLabel.Text = "Error will be like this!";
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(180, 303);
            this.phoneErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.phoneErrorLabel.TabIndex = 31;
            this.phoneErrorLabel.Text = "Error will be like this!";
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addressErrorLabel.Location = new System.Drawing.Point(180, 420);
            this.addressErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.addressErrorLabel.TabIndex = 32;
            this.addressErrorLabel.Text = "Error will be like this!";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 559);
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
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton famaleRadio;
        private System.Windows.Forms.DateTimePicker birthdateDatePicker;
        private System.Windows.Forms.PictureBox avatarPicture;
        private System.Windows.Forms.Label avatarLabel;
        private System.Windows.Forms.Button uploadAvatarButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderFullName;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label stdCodeErrorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stdCodeTextBox;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
    }
}