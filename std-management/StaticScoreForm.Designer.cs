
namespace std_management
{
    partial class StaticScoreForm
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
            this.staticByScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.byScoreListBox = new System.Windows.Forms.ListBox();
            this.byResultListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // staticByScoreLabel
            // 
            this.staticByScoreLabel.AutoSize = true;
            this.staticByScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticByScoreLabel.Location = new System.Drawing.Point(12, 18);
            this.staticByScoreLabel.Name = "staticByScoreLabel";
            this.staticByScoreLabel.Size = new System.Drawing.Size(180, 32);
            this.staticByScoreLabel.TabIndex = 2;
            this.staticByScoreLabel.Text = "Static by score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Static by result";
            // 
            // byScoreListBox
            // 
            this.byScoreListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.byScoreListBox.BackColor = System.Drawing.Color.White;
            this.byScoreListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.byScoreListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.byScoreListBox.FormattingEnabled = true;
            this.byScoreListBox.ItemHeight = 19;
            this.byScoreListBox.Items.AddRange(new object[] {
            "Java: 8.22",
            "C#: 7.10",
            "Atifical Inteligent: 9.32",
            "Dotnet: 6.50"});
            this.byScoreListBox.Location = new System.Drawing.Point(18, 64);
            this.byScoreListBox.Margin = new System.Windows.Forms.Padding(2);
            this.byScoreListBox.Name = "byScoreListBox";
            this.byScoreListBox.Size = new System.Drawing.Size(194, 152);
            this.byScoreListBox.TabIndex = 44;
            // 
            // byResultListBox
            // 
            this.byResultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.byResultListBox.BackColor = System.Drawing.Color.White;
            this.byResultListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.byResultListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.byResultListBox.FormattingEnabled = true;
            this.byResultListBox.ItemHeight = 19;
            this.byResultListBox.Items.AddRange(new object[] {
            "Pass: 89%",
            "Fail: 11%"});
            this.byResultListBox.Location = new System.Drawing.Point(228, 64);
            this.byResultListBox.Margin = new System.Windows.Forms.Padding(2);
            this.byResultListBox.Name = "byResultListBox";
            this.byResultListBox.Size = new System.Drawing.Size(194, 152);
            this.byResultListBox.TabIndex = 45;
            // 
            // StaticScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 227);
            this.Controls.Add(this.byResultListBox);
            this.Controls.Add(this.byScoreListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staticByScoreLabel);
            this.Name = "StaticScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StaticScoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticByScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox byScoreListBox;
        private System.Windows.Forms.ListBox byResultListBox;
    }
}