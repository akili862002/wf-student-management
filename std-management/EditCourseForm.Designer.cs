
namespace std_management
{
    partial class EditCourseForm
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
            this.periodErrorLabel = new System.Windows.Forms.Label();
            this.periodUpdown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTexBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.courseCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // periodErrorLabel
            // 
            this.periodErrorLabel.AutoSize = true;
            this.periodErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.periodErrorLabel.Location = new System.Drawing.Point(16, 317);
            this.periodErrorLabel.Name = "periodErrorLabel";
            this.periodErrorLabel.Size = new System.Drawing.Size(167, 23);
            this.periodErrorLabel.TabIndex = 64;
            this.periodErrorLabel.Text = "Error will be like this!";
            // 
            // periodUpdown
            // 
            this.periodUpdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.periodUpdown.Location = new System.Drawing.Point(16, 282);
            this.periodUpdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.periodUpdown.Name = "periodUpdown";
            this.periodUpdown.Size = new System.Drawing.Size(414, 26);
            this.periodUpdown.TabIndex = 3;
            this.periodUpdown.Validating += new System.ComponentModel.CancelEventHandler(this.periodUpdown_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 30);
            this.label6.TabIndex = 62;
            this.label6.Text = "Description";
            // 
            // descTextBox
            // 
            this.descTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTextBox.Location = new System.Drawing.Point(16, 378);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(412, 181);
            this.descTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 30);
            this.label4.TabIndex = 60;
            this.label4.Text = "Period";
            // 
            // labelErrorLabel
            // 
            this.labelErrorLabel.AutoSize = true;
            this.labelErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLabel.Location = new System.Drawing.Point(16, 220);
            this.labelErrorLabel.Name = "labelErrorLabel";
            this.labelErrorLabel.Size = new System.Drawing.Size(167, 23);
            this.labelErrorLabel.TabIndex = 59;
            this.labelErrorLabel.Text = "Error will be like this!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Label";
            // 
            // labelTexBox
            // 
            this.labelTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTexBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexBox.Location = new System.Drawing.Point(16, 177);
            this.labelTexBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelTexBox.Name = "labelTexBox";
            this.labelTexBox.Size = new System.Drawing.Size(412, 35);
            this.labelTexBox.TabIndex = 2;
            this.labelTexBox.Validating += new System.ComponentModel.CancelEventHandler(this.labelTextBox_Validating);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 66);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 30);
            this.usernameLabel.TabIndex = 55;
            this.usernameLabel.Text = "Course";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(243, 595);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(188, 51);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 48);
            this.label3.TabIndex = 52;
            this.label3.Text = "Edit course";
            // 
            // courseCombobox
            // 
            this.courseCombobox.FormattingEnabled = true;
            this.courseCombobox.Location = new System.Drawing.Point(16, 100);
            this.courseCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseCombobox.Name = "courseCombobox";
            this.courseCombobox.Size = new System.Drawing.Size(412, 28);
            this.courseCombobox.TabIndex = 1;
            this.courseCombobox.SelectedIndexChanged += new System.EventHandler(this.courseCombobox_SelectedIndexChanged);
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 665);
            this.Controls.Add(this.courseCombobox);
            this.Controls.Add(this.periodErrorLabel);
            this.Controls.Add(this.periodUpdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTexBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label3);
            this.Name = "EditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label periodErrorLabel;
        private System.Windows.Forms.NumericUpDown periodUpdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelTexBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox courseCombobox;
    }
}