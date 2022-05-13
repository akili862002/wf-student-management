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
        }
    }
}
