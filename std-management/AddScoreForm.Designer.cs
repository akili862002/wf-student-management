
namespace std_management
{
    partial class AddScoreForm
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
            this.stdCodeErrorLabel = new System.Windows.Forms.Label();
            this.stdCodeLabel = new System.Windows.Forms.Label();
            this.stdCodeTextbox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.scoreErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.courseCombobox = new System.Windows.Forms.ComboBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addScoreButton = new System.Windows.Forms.Button();
            this.listStudentTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.courseErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listStudentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // stdCodeErrorLabel
            // 
            this.stdCodeErrorLabel.AutoSize = true;
            this.stdCodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.stdCodeErrorLabel.Location = new System.Drawing.Point(17, 102);
            this.stdCodeErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdCodeErrorLabel.Name = "stdCodeErrorLabel";
            this.stdCodeErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.stdCodeErrorLabel.TabIndex = 29;
            this.stdCodeErrorLabel.Text = "Error will be like this!";
            // 
            // stdCodeLabel
            // 
            this.stdCodeLabel.AutoSize = true;
            this.stdCodeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeLabel.Location = new System.Drawing.Point(14, 52);
            this.stdCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdCodeLabel.Name = "stdCodeLabel";
            this.stdCodeLabel.Size = new System.Drawing.Size(92, 19);
            this.stdCodeLabel.TabIndex = 28;
            this.stdCodeLabel.Text = "Student code";
            // 
            // stdCodeTextbox
            // 
            this.stdCodeTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCodeTextbox.Location = new System.Drawing.Point(17, 73);
            this.stdCodeTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stdCodeTextbox.Name = "stdCodeTextbox";
            this.stdCodeTextbox.Size = new System.Drawing.Size(261, 26);
            this.stdCodeTextbox.TabIndex = 27;
            this.stdCodeTextbox.Leave += new System.EventHandler(this.stdCodeTextBox_Leave);
            this.stdCodeTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.studentCode_Validating);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(11, 9);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(130, 32);
            this.loginLabel.TabIndex = 30;
            this.loginLabel.Text = "Add score";
            // 
            // scoreErrorLabel
            // 
            this.scoreErrorLabel.AutoSize = true;
            this.scoreErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreErrorLabel.Location = new System.Drawing.Point(17, 229);
            this.scoreErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreErrorLabel.Name = "scoreErrorLabel";
            this.scoreErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.scoreErrorLabel.TabIndex = 33;
            this.scoreErrorLabel.Text = "Error will be like this!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Score";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.Location = new System.Drawing.Point(17, 199);
            this.scoreTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(261, 26);
            this.scoreTextBox.TabIndex = 31;
            this.scoreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.score_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(17, 268);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(261, 120);
            this.descriptionTextBox.TabIndex = 34;
            // 
            // courseCombobox
            // 
            this.courseCombobox.FormattingEnabled = true;
            this.courseCombobox.Location = new System.Drawing.Point(17, 140);
            this.courseCombobox.Name = "courseCombobox";
            this.courseCombobox.Size = new System.Drawing.Size(261, 21);
            this.courseCombobox.TabIndex = 67;
            this.courseCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.courseId_Validating);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(14, 118);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(52, 19);
            this.usernameLabel.TabIndex = 66;
            this.usernameLabel.Text = "Course";
            // 
            // addScoreButton
            // 
            this.addScoreButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScoreButton.Location = new System.Drawing.Point(17, 398);
            this.addScoreButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(262, 32);
            this.addScoreButton.TabIndex = 68;
            this.addScoreButton.Text = "Add score";
            this.addScoreButton.UseVisualStyleBackColor = false;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // listStudentTable
            // 
            this.listStudentTable.AllowUserToAddRows = false;
            this.listStudentTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStudentTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listStudentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStudentTable.Location = new System.Drawing.Point(296, 73);
            this.listStudentTable.Name = "listStudentTable";
            this.listStudentTable.Size = new System.Drawing.Size(383, 357);
            this.listStudentTable.TabIndex = 69;
            this.listStudentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listStudentTable_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "List students";
            // 
            // courseErrorLabel
            // 
            this.courseErrorLabel.AutoSize = true;
            this.courseErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.courseErrorLabel.Location = new System.Drawing.Point(17, 164);
            this.courseErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseErrorLabel.Name = "courseErrorLabel";
            this.courseErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.courseErrorLabel.TabIndex = 71;
            this.courseErrorLabel.Text = "Error will be like this!";
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 447);
            this.Controls.Add(this.courseErrorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listStudentTable);
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.courseCombobox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.scoreErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.stdCodeErrorLabel);
            this.Controls.Add(this.stdCodeLabel);
            this.Controls.Add(this.stdCodeTextbox);
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.listStudentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stdCodeErrorLabel;
        private System.Windows.Forms.Label stdCodeLabel;
        private System.Windows.Forms.TextBox stdCodeTextbox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label scoreErrorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox courseCombobox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button addScoreButton;
        private System.Windows.Forms.DataGridView listStudentTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label courseErrorLabel;
    }
}