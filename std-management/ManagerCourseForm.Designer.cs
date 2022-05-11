
namespace std_management
{
    partial class ManagerCourseForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.listCourseLabel = new System.Windows.Forms.Label();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.latestPageButton = new System.Windows.Forms.Button();
            this.firstPageButton = new System.Windows.Forms.Button();
            this.periodErrorLabel = new System.Windows.Forms.Label();
            this.periodUpdown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.courseIdErrorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(95, 433);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 31);
            this.submitButton.TabIndex = 41;
            this.submitButton.Text = "Create";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(193, 433);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 31);
            this.deleteButton.TabIndex = 42;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // courseListBox
            // 
            this.courseListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.courseListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 19;
            this.courseListBox.Items.AddRange(new object[] {
            "Java",
            "C#",
            "Atifical Inteligent",
            "Dotnet"});
            this.courseListBox.Location = new System.Drawing.Point(286, 84);
            this.courseListBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(250, 342);
            this.courseListBox.TabIndex = 43;
            this.courseListBox.SelectedIndexChanged += new System.EventHandler(this.courseListBox_SelectedIndexChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(11, 15);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(200, 32);
            this.loginLabel.TabIndex = 44;
            this.loginLabel.Text = "Manager course";
            // 
            // listCourseLabel
            // 
            this.listCourseLabel.AutoSize = true;
            this.listCourseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCourseLabel.Location = new System.Drawing.Point(282, 55);
            this.listCourseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listCourseLabel.Name = "listCourseLabel";
            this.listCourseLabel.Size = new System.Drawing.Size(58, 19);
            this.listCourseLabel.TabIndex = 47;
            this.listCourseLabel.Text = "Courses";
            // 
            // nextPageButton
            // 
            this.nextPageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nextPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPageButton.Location = new System.Drawing.Point(463, 435);
            this.nextPageButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(28, 29);
            this.nextPageButton.TabIndex = 48;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = false;
            // 
            // prevPageButton
            // 
            this.prevPageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prevPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPageButton.Location = new System.Drawing.Point(430, 435);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(28, 29);
            this.prevPageButton.TabIndex = 49;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = false;
            // 
            // latestPageButton
            // 
            this.latestPageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.latestPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestPageButton.Location = new System.Drawing.Point(496, 435);
            this.latestPageButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.latestPageButton.Name = "latestPageButton";
            this.latestPageButton.Size = new System.Drawing.Size(40, 29);
            this.latestPageButton.TabIndex = 50;
            this.latestPageButton.Text = ">>";
            this.latestPageButton.UseVisualStyleBackColor = false;
            // 
            // firstPageButton
            // 
            this.firstPageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPageButton.Location = new System.Drawing.Point(386, 435);
            this.firstPageButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstPageButton.Name = "firstPageButton";
            this.firstPageButton.Size = new System.Drawing.Size(40, 29);
            this.firstPageButton.TabIndex = 51;
            this.firstPageButton.Text = "<<";
            this.firstPageButton.UseVisualStyleBackColor = false;
            // 
            // periodErrorLabel
            // 
            this.periodErrorLabel.AutoSize = true;
            this.periodErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.periodErrorLabel.Location = new System.Drawing.Point(16, 233);
            this.periodErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.periodErrorLabel.Name = "periodErrorLabel";
            this.periodErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.periodErrorLabel.TabIndex = 62;
            this.periodErrorLabel.Text = "Error will be like this!";
            // 
            // periodUpdown
            // 
            this.periodUpdown.Location = new System.Drawing.Point(16, 210);
            this.periodUpdown.Name = "periodUpdown";
            this.periodUpdown.Size = new System.Drawing.Size(251, 20);
            this.periodUpdown.TabIndex = 61;
            this.periodUpdown.Validating += new System.ComponentModel.CancelEventHandler(this.periodUpdown_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 273);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(252, 153);
            this.descriptionTextBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "Period";
            // 
            // labelErrorLabel
            // 
            this.labelErrorLabel.AutoSize = true;
            this.labelErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLabel.Location = new System.Drawing.Point(16, 171);
            this.labelErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorLabel.Name = "labelErrorLabel";
            this.labelErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.labelErrorLabel.TabIndex = 57;
            this.labelErrorLabel.Text = "Error will be like this!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Label";
            // 
            // labelTextBox
            // 
            this.labelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBox.Location = new System.Drawing.Point(16, 142);
            this.labelTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(252, 26);
            this.labelTextBox.TabIndex = 55;
            this.labelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.labelTextBox_Validating);
            // 
            // courseIdErrorLabel
            // 
            this.courseIdErrorLabel.AutoSize = true;
            this.courseIdErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.courseIdErrorLabel.Location = new System.Drawing.Point(16, 106);
            this.courseIdErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseIdErrorLabel.Name = "courseIdErrorLabel";
            this.courseIdErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.courseIdErrorLabel.TabIndex = 54;
            this.courseIdErrorLabel.Text = "Error will be like this!";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(13, 56);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 19);
            this.usernameLabel.TabIndex = 53;
            this.usernameLabel.Text = "Course ID";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseIdTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdTextBox.Location = new System.Drawing.Point(16, 77);
            this.courseIdTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(252, 26);
            this.courseIdTextBox.TabIndex = 52;
            this.courseIdTextBox.Leave += new System.EventHandler(this.courseIdTextbox_Leave);
            this.courseIdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.courseIdTextbox_Validating);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetButton.BackColor = System.Drawing.Color.Coral;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(16, 433);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 31);
            this.resetButton.TabIndex = 63;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ManagerCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 476);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.periodErrorLabel);
            this.Controls.Add(this.periodUpdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTextBox);
            this.Controls.Add(this.courseIdErrorLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.firstPageButton);
            this.Controls.Add(this.latestPageButton);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.listCourseLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.submitButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagerCourseForm";
            this.Load += new System.EventHandler(this.ManagerCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label listCourseLabel;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Button latestPageButton;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.Label periodErrorLabel;
        private System.Windows.Forms.NumericUpDown periodUpdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelErrorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labelTextBox;
        private System.Windows.Forms.Label courseIdErrorLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Button resetButton;
    }
}