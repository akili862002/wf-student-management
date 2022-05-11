
namespace std_management
{
    partial class PrintScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintScoreForm));
            this.scoreTable = new System.Windows.Forms.DataGridView();
            this.toFileButton = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTable
            // 
            this.scoreTable.AllowUserToAddRows = false;
            this.scoreTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.scoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTable.Location = new System.Drawing.Point(12, 13);
            this.scoreTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.RowHeadersWidth = 100;
            this.scoreTable.Size = new System.Drawing.Size(776, 387);
            this.scoreTable.TabIndex = 73;
            // 
            // toFileButton
            // 
            this.toFileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFileButton.Location = new System.Drawing.Point(12, 407);
            this.toFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toFileButton.Name = "toFileButton";
            this.toFileButton.Size = new System.Drawing.Size(109, 37);
            this.toFileButton.TabIndex = 74;
            this.toFileButton.Text = "To File";
            this.toFileButton.UseVisualStyleBackColor = false;
            this.toFileButton.Click += new System.EventHandler(this.toFileButton_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
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
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.printButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(125, 407);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(109, 37);
            this.printButton.TabIndex = 75;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.toFileButton);
            this.Controls.Add(this.scoreTable);
            this.Name = "PrintScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreTable;
        private System.Windows.Forms.Button toFileButton;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button printButton;
    }
}