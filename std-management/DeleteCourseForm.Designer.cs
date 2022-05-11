
namespace std_management
{
    partial class DeleteCourseForm
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
            this.courseIdErrorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.courseIdTextbox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseIdErrorLabel
            // 
            this.courseIdErrorLabel.AutoSize = true;
            this.courseIdErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.courseIdErrorLabel.Location = new System.Drawing.Point(11, 104);
            this.courseIdErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseIdErrorLabel.Name = "courseIdErrorLabel";
            this.courseIdErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.courseIdErrorLabel.TabIndex = 46;
            this.courseIdErrorLabel.Text = "Error will be like this!";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(8, 54);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 19);
            this.usernameLabel.TabIndex = 45;
            this.usernameLabel.Text = "Course id";
            // 
            // courseIdTextbox
            // 
            this.courseIdTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseIdTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdTextbox.Location = new System.Drawing.Point(11, 75);
            this.courseIdTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.courseIdTextbox.Name = "courseIdTextbox";
            this.courseIdTextbox.Size = new System.Drawing.Size(388, 26);
            this.courseIdTextbox.TabIndex = 44;
            this.courseIdTextbox.Leave += new System.EventHandler(this.courseIdTextbox_Leave);
            this.courseIdTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.courseIdTextbox_Validating);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(281, 135);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 33);
            this.deleteButton.TabIndex = 43;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(5, 12);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(171, 32);
            this.loginLabel.TabIndex = 42;
            this.loginLabel.Text = "Delete course";
            // 
            // DeleteCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 174);
            this.Controls.Add(this.courseIdErrorLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.courseIdTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loginLabel);
            this.Name = "DeleteCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteCourse";
            this.Load += new System.EventHandler(this.DeleteCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseIdErrorLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox courseIdTextbox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label loginLabel;
    }
}