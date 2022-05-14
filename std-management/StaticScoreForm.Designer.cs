
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.staticByScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.byScoreListBox = new System.Windows.Forms.ListBox();
            this.byResultListBox = new System.Windows.Forms.ListBox();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageScoreChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreChart)).BeginInit();
            this.SuspendLayout();
            // 
            // staticByScoreLabel
            // 
            this.staticByScoreLabel.AutoSize = true;
            this.staticByScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticByScoreLabel.Location = new System.Drawing.Point(18, 28);
            this.staticByScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staticByScoreLabel.Name = "staticByScoreLabel";
            this.staticByScoreLabel.Size = new System.Drawing.Size(262, 48);
            this.staticByScoreLabel.TabIndex = 2;
            this.staticByScoreLabel.Text = "Static by score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Static by result";
            // 
            // byScoreListBox
            // 
            this.byScoreListBox.BackColor = System.Drawing.Color.White;
            this.byScoreListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.byScoreListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.byScoreListBox.FormattingEnabled = true;
            this.byScoreListBox.ItemHeight = 28;
            this.byScoreListBox.Items.AddRange(new object[] {
            "Java: 8.22",
            "C#: 7.10",
            "Atifical Inteligent: 9.32",
            "Dotnet: 6.50"});
            this.byScoreListBox.Location = new System.Drawing.Point(27, 98);
            this.byScoreListBox.Name = "byScoreListBox";
            this.byScoreListBox.Size = new System.Drawing.Size(370, 196);
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
            this.byResultListBox.ItemHeight = 28;
            this.byResultListBox.Location = new System.Drawing.Point(492, 98);
            this.byResultListBox.Name = "byResultListBox";
            this.byResultListBox.Size = new System.Drawing.Size(399, 112);
            this.byResultListBox.TabIndex = 45;
            // 
            // resultChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resultChart.Legends.Add(legend1);
            this.resultChart.Location = new System.Drawing.Point(492, 280);
            this.resultChart.Name = "resultChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Pass";
            this.resultChart.Series.Add(series1);
            this.resultChart.Size = new System.Drawing.Size(357, 372);
            this.resultChart.TabIndex = 46;
            this.resultChart.Text = "chart1";
            // 
            // averageScoreChart
            // 
            chartArea2.Name = "ChartArea1";
            this.averageScoreChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.averageScoreChart.Legends.Add(legend2);
            this.averageScoreChart.Location = new System.Drawing.Point(12, 280);
            this.averageScoreChart.Name = "averageScoreChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Score";
            this.averageScoreChart.Series.Add(series2);
            this.averageScoreChart.Size = new System.Drawing.Size(380, 393);
            this.averageScoreChart.TabIndex = 47;
            this.averageScoreChart.Text = "chart1";
            // 
            // StaticScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 714);
            this.Controls.Add(this.averageScoreChart);
            this.Controls.Add(this.resultChart);
            this.Controls.Add(this.byResultListBox);
            this.Controls.Add(this.byScoreListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staticByScoreLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaticScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StaticScoreForm";
            this.Load += new System.EventHandler(this.StaticScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticByScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox byScoreListBox;
        private System.Windows.Forms.ListBox byResultListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart averageScoreChart;
    }
}