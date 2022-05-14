
namespace std_management
{
    partial class AddNewCourseForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.courseIdErrorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.courseIdTextbox = new System.Windows.Forms.TextBox();
            this.labelErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.periodUpdown = new System.Windows.Forms.NumericUpDown();
            this.periodErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(14, 11);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(289, 48);
            this.loginLabel.TabIndex = 30;
            this.loginLabel.Text = "Add new course";
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(290, 611);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(176, 51);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // courseIdErrorLabel
            // 
            this.courseIdErrorLabel.AutoSize = true;
            this.courseIdErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.courseIdErrorLabel.Location = new System.Drawing.Point(22, 143);
            this.courseIdErrorLabel.Name = "courseIdErrorLabel";
            this.courseIdErrorLabel.Size = new System.Drawing.Size(167, 23);
            this.courseIdErrorLabel.TabIndex = 41;
            this.courseIdErrorLabel.Text = "Error will be like this!";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(18, 66);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(106, 30);
            this.usernameLabel.TabIndex = 40;
            this.usernameLabel.Text = "Course ID";
            // 
            // courseIdTextbox
            // 
            this.courseIdTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseIdTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdTextbox.Location = new System.Drawing.Point(22, 98);
            this.courseIdTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.courseIdTextbox.Name = "courseIdTextbox";
            this.courseIdTextbox.Size = new System.Drawing.Size(440, 35);
            this.courseIdTextbox.TabIndex = 1;
            this.courseIdTextbox.Leave += new System.EventHandler(this.courseIdTextbox_Leave);
            this.courseIdTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.courseIdTextbox_Validating);
            // 
            // labelErrorLabel
            // 
            this.labelErrorLabel.AutoSize = true;
            this.labelErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLabel.Location = new System.Drawing.Point(22, 243);
            this.labelErrorLabel.Name = "labelErrorLabel";
            this.labelErrorLabel.Size = new System.Drawing.Size(167, 23);
            this.labelErrorLabel.TabIndex = 44;
            this.labelErrorLabel.Text = "Error will be like this!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "Label";
            // 
            // labelTextBox
            // 
            this.labelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBox.Location = new System.Drawing.Point(22, 198);
            this.labelTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(440, 35);
            this.labelTextBox.TabIndex = 2;
            this.labelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.labelTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "Period";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 30);
            this.label6.TabIndex = 49;
            this.label6.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(22, 400);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(440, 181);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // periodUpdown
            // 
            this.periodUpdown.Location = new System.Drawing.Point(22, 303);
            this.periodUpdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.periodUpdown.Name = "periodUpdown";
            this.periodUpdown.Size = new System.Drawing.Size(441, 26);
            this.periodUpdown.TabIndex = 3;
            this.periodUpdown.Validating += new System.ComponentModel.CancelEventHandler(this.periodUpdown_Validating);
            // 
            // periodErrorLabel
            // 
            this.periodErrorLabel.AutoSize = true;
            this.periodErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.periodErrorLabel.Location = new System.Drawing.Point(22, 338);
            this.periodErrorLabel.Name = "periodErrorLabel";
            this.periodErrorLabel.Size = new System.Drawing.Size(167, 23);
            this.periodErrorLabel.TabIndex = 51;
            this.periodErrorLabel.Text = "Error will be like this!";
            // 
            // AddNewCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 680);
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
            this.Controls.Add(this.courseIdTextbox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.loginLabel);
            this.Name = "AddNewCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewCourse";
            this.Load += new System.EventHandler(this.AddNewCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label courseIdErrorLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox courseIdTextbox;
        private System.Windows.Forms.Label labelErrorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown periodUpdown;
        private System.Windows.Forms.Label periodErrorLabel;
    }
}