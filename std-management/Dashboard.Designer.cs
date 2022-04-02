
namespace std_management
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshButton = new System.Windows.Forms.Button();
            this.studentTableData = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.avatarURLCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(17, 88);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(187, 26);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(214, 86);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchButton.Size = new System.Drawing.Size(57, 30);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(11, 38);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(260, 32);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Student management";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(875, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.editRemoveStudentToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripDropDownButton1.Text = "Tools";
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addStudentsToolStripMenuItem.Text = "Add student";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // editRemoveStudentToolStripMenuItem
            // 
            this.editRemoveStudentToolStripMenuItem.Name = "editRemoveStudentToolStripMenuItem";
            this.editRemoveStudentToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.editRemoveStudentToolStripMenuItem.Text = "Edit/Remove student";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(775, 86);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refreshButton.Size = new System.Drawing.Size(86, 30);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // studentTableData
            // 
            this.studentTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTableData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.studentTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.firstNameCol,
            this.lastnameCol,
            this.Birthdate,
            this.genderCol,
            this.phoneCol,
            this.addressCol,
            this.avatarImg,
            this.avatarURLCol});
            this.studentTableData.Location = new System.Drawing.Point(17, 132);
            this.studentTableData.Name = "studentTableData";
            this.studentTableData.Size = new System.Drawing.Size(844, 437);
            this.studentTableData.TabIndex = 13;
            this.studentTableData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.studentTableData_CellFormatting);
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "id";
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // firstNameCol
            // 
            this.firstNameCol.DataPropertyName = "first_name";
            this.firstNameCol.HeaderText = "First name";
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.ReadOnly = true;
            // 
            // lastnameCol
            // 
            this.lastnameCol.DataPropertyName = "last_name";
            this.lastnameCol.HeaderText = "Last name";
            this.lastnameCol.Name = "lastnameCol";
            this.lastnameCol.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "birthdate";
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // genderCol
            // 
            this.genderCol.DataPropertyName = "gender";
            this.genderCol.HeaderText = "Gender";
            this.genderCol.Name = "genderCol";
            this.genderCol.ReadOnly = true;
            // 
            // phoneCol
            // 
            this.phoneCol.DataPropertyName = "phone";
            this.phoneCol.HeaderText = "Phone";
            this.phoneCol.Name = "phoneCol";
            this.phoneCol.ReadOnly = true;
            // 
            // addressCol
            // 
            this.addressCol.DataPropertyName = "address";
            this.addressCol.HeaderText = "Address";
            this.addressCol.Name = "addressCol";
            this.addressCol.ReadOnly = true;
            // 
            // avatarImg
            // 
            this.avatarImg.DataPropertyName = "avatarImg";
            this.avatarImg.HeaderText = "Avatar";
            this.avatarImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.avatarImg.Name = "avatarImg";
            this.avatarImg.ReadOnly = true;
            this.avatarImg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.avatarImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // avatarURLCol
            // 
            this.avatarURLCol.DataPropertyName = "avatar";
            this.avatarURLCol.HeaderText = "AvatarURL";
            this.avatarURLCol.Name = "avatarURLCol";
            this.avatarURLCol.ReadOnly = true;
            this.avatarURLCol.Visible = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 581);
            this.Controls.Add(this.studentTableData);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveStudentToolStripMenuItem;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView studentTableData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
        private System.Windows.Forms.DataGridViewImageColumn avatarImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarURLCol;
    }
}