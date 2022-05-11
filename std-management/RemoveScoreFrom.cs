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
    public partial class RemoveScoreFrom : Form
    {

        public RemoveScoreFrom()
        {
            InitializeComponent();
            this.loadDetailScoresTabel();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void loadDetailScoresTabel()
        {
            new Thread(() =>
            {
                try
                {
                    Database.ScoreDB db = new Database.ScoreDB();
                    DataTable dt = new DataTable();
                    db.getAllDetailScoreAdapter().Fill(dt);
                    this.Invoke(new MethodInvoker(delegate
                    {
                        this.scoreTable.DataSource = dt;
                    }));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }).Start();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int currentIndex = this.scoreTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.scoreTable.Rows[currentIndex];
            string student_code = row.Cells["Student code"].Value.ToString();
            string course_id = row.Cells["Course id"].Value.ToString();

            if (string.IsNullOrEmpty(student_code))
            {
                MessageBox.Show("Please select your row which you want to delete!");
                return;
            }

            new Thread(() =>
            {
                try
                {
                    Database.ScoreDB db = new Database.ScoreDB();
                    db.deleteScore(student_code, course_id);
                    MessageBox.Show("Delete score item successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadDetailScoresTabel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }).Start();
        }

        private void RemoveScoreFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
