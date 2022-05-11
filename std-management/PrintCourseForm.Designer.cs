
namespace std_management
{
    partial class PrintCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintCourseForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.courseTableData = new System.Windows.Forms.DataGridView();
            this.toFileButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.courseTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(9, 7);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(165, 32);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Print courses";
            // 
            // courseTableData
            // 
            this.courseTableData.AllowUserToAddRows = false;
            this.courseTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseTableData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.courseTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseTableData.Location = new System.Drawing.Point(12, 51);
            this.courseTableData.Name = "courseTableData";
            this.courseTableData.RowHeadersWidth = 51;
            this.courseTableData.Size = new System.Drawing.Size(556, 343);
            this.courseTableData.TabIndex = 14;
            // 
            // toFileButton
            // 
            this.toFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toFileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFileButton.Location = new System.Drawing.Point(12, 401);
            this.toFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toFileButton.Name = "toFileButton";
            this.toFileButton.Size = new System.Drawing.Size(100, 38);
            this.toFileButton.TabIndex = 42;
            this.toFileButton.Text = "To File";
            this.toFileButton.UseVisualStyleBackColor = false;
            this.toFileButton.Click += new System.EventHandler(this.toFileButton_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.printButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(118, 401);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 38);
            this.printButton.TabIndex = 43;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 452);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.toFileButton);
            this.Controls.Add(this.courseTableData);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PrintCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrintCourse";
            ((System.ComponentModel.ISupportInitialize)(this.courseTableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.DataGridView courseTableData;
        private System.Windows.Forms.Button toFileButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}