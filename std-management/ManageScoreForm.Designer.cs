
namespace std_management
{
    partial class ManageScoreForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.showAvgScoreButton = new System.Windows.Forms.Button();
            this.showScoreButton = new System.Windows.Forms.Button();
            this.showStudentButton = new System.Windows.Forms.Button();
            this.scoreTable = new System.Windows.Forms.DataGridView();
            this.courseErrorLabel = new System.Windows.Forms.Label();
            this.courseCombobox = new System.Windows.Forms.ComboBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.scoreErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.stdCodeErrorLabel = new System.Windows.Forms.Label();
            this.stdCodeLabel = new System.Windows.Forms.Label();
            this.stdCodeTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(11, 9);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(175, 32);
            this.loginLabel.TabIndex = 38;
            this.loginLabel.Text = "Manage score";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(17, 397);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(131, 37);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(152, 397);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 37);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAvgScoreButton
            // 
            this.showAvgScoreButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.showAvgScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAvgScoreButton.Location = new System.Drawing.Point(17, 440);
            this.showAvgScoreButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.showAvgScoreButton.Name = "showAvgScoreButton";
            this.showAvgScoreButton.Size = new System.Drawing.Size(261, 36);
            this.showAvgScoreButton.TabIndex = 41;
            this.showAvgScoreButton.Text = "Average score by course";
            this.showAvgScoreButton.UseVisualStyleBackColor = false;
            this.showAvgScoreButton.Click += new System.EventHandler(this.showAvgScoreButton_Click);
            // 
            // showScoreButton
            // 
            this.showScoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showScoreButton.BackColor = System.Drawing.Color.White;
            this.showScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showScoreButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showScoreButton.Location = new System.Drawing.Point(855, 35);
            this.showScoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showScoreButton.Name = "showScoreButton";
            this.showScoreButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showScoreButton.Size = new System.Drawing.Size(101, 30);
            this.showScoreButton.TabIndex = 43;
            this.showScoreButton.Text = "Show score";
            this.showScoreButton.UseVisualStyleBackColor = false;
            this.showScoreButton.Click += new System.EventHandler(this.showScoreButton_Click);
            // 
            // showStudentButton
            // 
            this.showStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showStudentButton.BackColor = System.Drawing.Color.White;
            this.showStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showStudentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentButton.Location = new System.Drawing.Point(747, 35);
            this.showStudentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showStudentButton.Name = "showStudentButton";
            this.showStudentButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showStudentButton.Size = new System.Drawing.Size(102, 30);
            this.showStudentButton.TabIndex = 44;
            this.showStudentButton.Text = "Show student";
            this.showStudentButton.UseVisualStyleBackColor = false;
            this.showStudentButton.Click += new System.EventHandler(this.showStudentButton_Click);
            // 
            // scoreTable
            // 
            this.scoreTable.AllowUserToAddRows = false;
            this.scoreTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.scoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTable.Location = new System.Drawing.Point(293, 73);
            this.scoreTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.RowHeadersWidth = 100;
            this.scoreTable.Size = new System.Drawing.Size(663, 453);
            this.scoreTable.TabIndex = 72;
            // 
            // courseErrorLabel
            // 
            this.courseErrorLabel.AutoSize = true;
            this.courseErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.courseErrorLabel.Location = new System.Drawing.Point(17, 166);
            this.courseErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseErrorLabel.Name = "courseErrorLabel";
            this.courseErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.courseErrorLabel.TabIndex = 83;
            this.courseErrorLabel.Text = "Error will be like this!";
            // 
            // courseCombobox
            // 
            this.courseCombobox.FormattingEnabled = true;
            this.courseCombobox.Location = new System.Drawing.Point(17, 142);
            this.courseCombobox.Name = "courseCombobox";
            this.courseCombobox.Size = new System.Drawing.Size(261, 21);
            this.courseCombobox.TabIndex = 82;
            this.courseCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.courseId_Validating);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(14, 120);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(52, 19);
            this.usernameLabel.TabIndex = 81;
            this.usernameLabel.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 80;
            this.label4.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(17, 271);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(261, 120);
            this.descriptionTextBox.TabIndex = 79;
            // 
            // scoreErrorLabel
            // 
            this.scoreErrorLabel.AutoSize = true;
            this.scoreErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreErrorLabel.Location = new System.Drawing.Point(17, 231);
            this.scoreErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreErrorLabel.Name = "scoreErrorLabel";
            this.scoreErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.scoreErrorLabel.TabIndex = 78;
            this.scoreErrorLabel.Text = "Error will be like this!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "Score";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.Location = new System.Drawing.Point(17, 201);
            this.scoreTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(261, 26);
            this.scoreTextBox.TabIndex = 76;
            this.scoreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.score_Validating);
            // 
            // stdCodeErrorLabel
            // 
            this.stdCodeErrorLabel.AutoSize = true;
            this.stdCodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.stdCodeErrorLabel.Location = new System.Drawing.Point(17, 104);
            this.stdCodeErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdCodeErrorLabel.Name = "stdCodeErrorLabel";
            this.stdCodeErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.stdCodeErrorLabel.TabIndex = 75;
            this.stdCodeErrorLabel.Text = "Error will be like this!";
            // 
            // stdCodeLabel
            // 
            this.stdCodeLabel.AutoSize = true;
            this.stdCodeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeLabel.Location = new System.Drawing.Point(14, 54);
            this.stdCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdCodeLabel.Name = "stdCodeLabel";
            this.stdCodeLabel.Size = new System.Drawing.Size(92, 19);
            this.stdCodeLabel.TabIndex = 74;
            this.stdCodeLabel.Text = "Student code";
            // 
            // stdCodeTextbox
            // 
            this.stdCodeTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeTextbox.Location = new System.Drawing.Point(17, 75);
            this.stdCodeTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stdCodeTextbox.Name = "stdCodeTextbox";
            this.stdCodeTextbox.Size = new System.Drawing.Size(261, 26);
            this.stdCodeTextbox.TabIndex = 73;
            this.stdCodeTextbox.Leave += new System.EventHandler(this.stdCodeTextBox_Leave);
            this.stdCodeTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.studentCode_Validating);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 539);
            this.Controls.Add(this.courseErrorLabel);
            this.Controls.Add(this.courseCombobox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.scoreErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.stdCodeErrorLabel);
            this.Controls.Add(this.stdCodeLabel);
            this.Controls.Add(this.stdCodeTextbox);
            this.Controls.Add(this.scoreTable);
            this.Controls.Add(this.showStudentButton);
            this.Controls.Add(this.showScoreButton);
            this.Controls.Add(this.showAvgScoreButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.loginLabel);
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showAvgScoreButton;
        private System.Windows.Forms.Button showScoreButton;
        private System.Windows.Forms.Button showStudentButton;
        private System.Windows.Forms.DataGridView scoreTable;
        private System.Windows.Forms.Label courseErrorLabel;
        private System.Windows.Forms.ComboBox courseCombobox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label scoreErrorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label stdCodeErrorLabel;
        private System.Windows.Forms.Label stdCodeLabel;
        private System.Windows.Forms.TextBox stdCodeTextbox;
    }
}