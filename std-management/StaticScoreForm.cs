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
    public partial class StaticScoreForm : Form
    {
        public StaticScoreForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void StaticScoreForm_Load(object sender, EventArgs e)
        {
            this.loadAvgScores();
            this.loadResult();
        }

        private void loadAvgScores()
        {
            new Thread(() =>
            {
                Database.ScoreDB db = new Database.ScoreDB();
                DataTable dt = new DataTable();
                db.getAllAverageScoreByCourseOneLineAdapter().Fill(dt);
                this.Invoke(new MethodInvoker(delegate
                {
                    this.byScoreListBox.DataSource = dt;
                    this.byScoreListBox.DisplayMember = "label";
                    this.byScoreListBox.ValueMember = "label";
                }));
            }).Start();

            new Thread(() =>
            {
                Database.ScoreDB db = new Database.ScoreDB();
                DataTable dt = new DataTable();
                db.getAllAverageScoreByCourseAdapter().Fill(dt);
                this.Invoke(new MethodInvoker(delegate
                {
                    this.averageScoreChart.DataSource = dt;
                    this.averageScoreChart.Series["Score"].XValueMember = "Label";
                    this.averageScoreChart.Series["Score"].YValueMembers = "Average grade";
                    this.averageScoreChart.Titles.Add("Average grade by score");
                }));
            }).Start();
        }

        private void loadResult()
        {
            new Thread(() =>
            {
                Database.ScoreDB scoreDb = new Database.ScoreDB();
                Database.StudentDB studentDb = new Database.StudentDB();

                int totalPassStudents = scoreDb.countPassStudents();
                int totalStudents = studentDb.countTotalStudents();

                decimal passPercent = Math.Round(((decimal)totalPassStudents / (decimal)totalStudents * 100), 2);
                decimal failPercent = 100 - passPercent;

                this.Invoke(new MethodInvoker(delegate
                {
                    this.byResultListBox.Items.Insert(0, $"Pass: {passPercent}%");
                    this.byResultListBox.Items.Insert(1, $"Fail: {failPercent}%");
                    this.resultChart.Series["Pass"].Points.AddXY("Pass", passPercent);
                    this.resultChart.Series["Pass"].Points.AddXY("Fail", failPercent);
                    this.resultChart.Titles.Add("Static Results");
                }));
            }).Start();
        }

    }
}
