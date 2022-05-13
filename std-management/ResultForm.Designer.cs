
namespace std_management
{
    partial class ResultForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.java = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.codeAndFirstNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(28, 119);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(185, 38);
            this.usernameLabel.TabIndex = 28;
            this.usernameLabel.Text = "Student code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(34, 160);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(362, 44);
            this.codeTextBox.TabIndex = 27;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(22, 35);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(368, 65);
            this.loginLabel.TabIndex = 30;
            this.loginLabel.Text = "Student results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "First name";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTextBox.Location = new System.Drawing.Point(34, 267);
            this.firstnameTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(362, 44);
            this.firstnameTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Last name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(34, 373);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(362, 44);
            this.lastNameTextBox.TabIndex = 33;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstName,
            this.last_name,
            this.csharp,
            this.java,
            this.result});
            this.resultDataGridView.Location = new System.Drawing.Point(432, 119);
            this.resultDataGridView.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersWidth = 51;
            this.resultDataGridView.Size = new System.Drawing.Size(1358, 715);
            this.resultDataGridView.TabIndex = 35;
            this.resultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Student code";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "FirstName";
            this.firstName.MinimumWidth = 10;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 200;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last name";
            this.last_name.MinimumWidth = 10;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 200;
            // 
            // csharp
            // 
            this.csharp.HeaderText = "C#";
            this.csharp.MinimumWidth = 10;
            this.csharp.Name = "csharp";
            this.csharp.ReadOnly = true;
            this.csharp.Width = 200;
            // 
            // java
            // 
            this.java.HeaderText = "Java";
            this.java.MinimumWidth = 10;
            this.java.Name = "java";
            this.java.ReadOnly = true;
            this.java.Width = 200;
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.MinimumWidth = 10;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 200;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(36, 565);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(364, 62);
            this.searchButton.TabIndex = 36;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 442);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 38);
            this.label3.TabIndex = 38;
            this.label3.Text = "Code and Firstname";
            // 
            // codeAndFirstNameTextBox
            // 
            this.codeAndFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeAndFirstNameTextBox.Location = new System.Drawing.Point(36, 483);
            this.codeAndFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.codeAndFirstNameTextBox.Name = "codeAndFirstNameTextBox";
            this.codeAndFirstNameTextBox.Size = new System.Drawing.Size(362, 44);
            this.codeAndFirstNameTextBox.TabIndex = 37;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1816, 860);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeAndFirstNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.codeTextBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn csharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn java;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeAndFirstNameTextBox;
    }
}