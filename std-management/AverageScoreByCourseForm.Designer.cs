
namespace std_management
{
    partial class AverageScoreByCourseForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.averageScoreChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loginLabel = new System.Windows.Forms.Label();
            this.avgScoreTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgScoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // averageScoreChart
            // 
            chartArea3.Name = "ChartArea1";
            this.averageScoreChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.averageScoreChart.Legends.Add(legend3);
            this.averageScoreChart.Location = new System.Drawing.Point(0, 50);
            this.averageScoreChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.averageScoreChart.Name = "averageScoreChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Score";
            this.averageScoreChart.Series.Add(series3);
            this.averageScoreChart.Size = new System.Drawing.Size(402, 425);
            this.averageScoreChart.TabIndex = 0;
            this.averageScoreChart.Text = "Average score by course";
            this.averageScoreChart.Click += new System.EventHandler(this.averageScoreChart_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(14, 12);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(294, 32);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Average score by course";
            // 
            // avgScoreTable
            // 
            this.avgScoreTable.AllowUserToAddRows = false;
            this.avgScoreTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avgScoreTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.avgScoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avgScoreTable.Location = new System.Drawing.Point(411, 73);
            this.avgScoreTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.avgScoreTable.Name = "avgScoreTable";
            this.avgScoreTable.RowHeadersWidth = 100;
            this.avgScoreTable.Size = new System.Drawing.Size(376, 402);
            this.avgScoreTable.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Average score";
            // 
            // AverageScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.avgScoreTable);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.averageScoreChart);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AverageScoreByCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AverageScoreByCourseForm";
            this.Load += new System.EventHandler(this.AverageScoreByCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgScoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart averageScoreChart;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.DataGridView avgScoreTable;
        private System.Windows.Forms.Label label5;
    }
}