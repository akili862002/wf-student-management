
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
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshButton = new System.Windows.Forms.Button();
            this.studentTableData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.avatarURLCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addCourseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(20, 110);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(218, 30);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(249, 108);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchButton.Size = new System.Drawing.Size(66, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(13, 42);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(322, 41);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Student management";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.editRemoveStudentToolStripMenuItem,
            this.statisticToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 24);
            this.toolStripDropDownButton1.Text = "Students";
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.addStudentsToolStripMenuItem.Text = "Add student";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // editRemoveStudentToolStripMenuItem
            // 
            this.editRemoveStudentToolStripMenuItem.Name = "editRemoveStudentToolStripMenuItem";
            this.editRemoveStudentToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.editRemoveStudentToolStripMenuItem.Text = "Edit/Remove student";
            this.editRemoveStudentToolStripMenuItem.Click += new System.EventHandler(this.editRemoveStudentToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageCourseToolStripMenuItem,
            this.printToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(74, 24);
            this.toolStripDropDownButton2.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCourseToolStripMenuItem.Text = "Add course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeCourseToolStripMenuItem.Text = "Remove course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editCourseToolStripMenuItem.Text = "Edit course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageCourseToolStripMenuItem
            // 
            this.manageCourseToolStripMenuItem.Name = "manageCourseToolStripMenuItem";
            this.manageCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageCourseToolStripMenuItem.Text = "Manage course";
            this.manageCourseToolStripMenuItem.Click += new System.EventHandler(this.manageCourseToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(977, 108);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refreshButton.Size = new System.Drawing.Size(101, 30);
            this.refreshButton.TabIndex = 5;
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
            this.id,
            this.first_name,
            this.last_name,
            this.birth_date,
            this.gender,
            this.phone,
            this.address,
            this.avatarImg,
            this.avatarURLCol});
            this.studentTableData.Location = new System.Drawing.Point(20, 158);
            this.studentTableData.Margin = new System.Windows.Forms.Padding(4);
            this.studentTableData.Name = "studentTableData";
            this.studentTableData.RowHeadersWidth = 51;
            this.studentTableData.Size = new System.Drawing.Size(1058, 372);
            this.studentTableData.TabIndex = 13;
            this.studentTableData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.studentTableData_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First name";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 125;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last name";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 125;
            // 
            // birth_date
            // 
            this.birth_date.DataPropertyName = "birthdate";
            this.birth_date.HeaderText = "Birthdate";
            this.birth_date.MinimumWidth = 6;
            this.birth_date.Name = "birth_date";
            this.birth_date.ReadOnly = true;
            this.birth_date.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
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
            this.address.Width = 125;
            // 
            // avatarImg
            // 
            this.avatarImg.DataPropertyName = "avatarImg";
            this.avatarImg.HeaderText = "Avatar";
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
            this.studentTableLoadingProgress.Location = new System.Drawing.Point(794, 538);
            this.studentTableLoadingProgress.Margin = new System.Windows.Forms.Padding(4);
            this.studentTableLoadingProgress.Name = "studentTableLoadingProgress";
            this.studentTableLoadingProgress.Size = new System.Drawing.Size(150, 27);
            this.studentTableLoadingProgress.Step = 1;
            this.studentTableLoadingProgress.TabIndex = 14;
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem1,
            this.removeScoreToolStripMenuItem,
            this.managerScoreToolStripMenuItem,
            this.avgScoreToolStripMenuItem,
            this.printResultToolStripMenuItem});
            this.toolStripDropDownButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton3.Text = "Score";
            // 
            // addCourseToolStripMenuItem1
            // 
            this.addCourseToolStripMenuItem1.Name = "addCourseToolStripMenuItem1";
            this.addCourseToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addCourseToolStripMenuItem1.Text = "Add score";
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeScoreToolStripMenuItem.Text = "Remove score";
            // 
            // managerScoreToolStripMenuItem
            // 
            this.managerScoreToolStripMenuItem.Name = "managerScoreToolStripMenuItem";
            this.managerScoreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.managerScoreToolStripMenuItem.Text = "Manager score";
            // 
            // avgScoreToolStripMenuItem
            // 
            this.avgScoreToolStripMenuItem.Name = "avgScoreToolStripMenuItem";
            this.avgScoreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.avgScoreToolStripMenuItem.Text = "Avg score";
            // 
            // printResultToolStripMenuItem
            // 
            this.printResultToolStripMenuItem.Name = "printResultToolStripMenuItem";
            this.printResultToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printResultToolStripMenuItem.Text = "Print result";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 578);
            this.Controls.Add(this.studentTableLoadingProgress);
            this.Controls.Add(this.studentTableData);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewImageColumn avatarImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarURLCol;
        private System.Windows.Forms.ProgressBar studentTableLoadingProgress;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printResultToolStripMenuItem;
    }
}