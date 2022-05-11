using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class AverageScoreByCourseForm : Form
    {
        public AverageScoreByCourseForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.loadAvgScoreChartAndTable();
            this.avgScoreTable.AllowUserToAddRows = false;
        }

        private void AverageScoreByCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void loadAvgScoreChartAndTable()
        {
            new Thread(() =>
            {
                Database.ScoreDB db = new Database.ScoreDB();
                DataTable dt = new DataTable();
                db.getAllAverageScoreByCourseAdapter().Fill(dt);
                this.Invoke(new MethodInvoker(delegate
                {
                    this.averageScoreChart.DataSource = dt;
                    this.avgScoreTable.DataSource = dt;
                    this.averageScoreChart.Series["Score"].XValueMember = "Label";
                    this.averageScoreChart.Series["Score"].YValueMembers = "Average grade";
                    this.averageScoreChart.Titles.Add("Average grade by score");

                    this.avgScoreTable.Columns[0].Width = 140;
                    this.avgScoreTable.Columns[1].Width = 140;
                }));
            }).Start();
        }

        private void averageScoreChart_Click(object sender, EventArgs e)
        {

        }
    }
}
