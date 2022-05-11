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
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            this.loadDetailScoresTable();
        }

        private void loadDetailScoresTable()
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

        private void toFileButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewColumnCollection allColumns = this.scoreTable.Columns;

            foreach (DataGridViewColumn column in allColumns)
            {
                if (column is DataGridViewTextBoxColumn && column.Name != "avatarURLCol")
                    dt.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in this.scoreTable.Rows)
            {
                DataRow dr = dt.NewRow();

                foreach (DataGridViewColumn column in allColumns)
                {

                    if (column is DataGridViewTextBoxColumn && column.Name != "avatarURLCol")
                        if (row.Cells[column.Name].Value != null)
                        {
                            dr[column.Name] = row.Cells[column.Name].Value.ToString();
                        }
                }
                dt.Rows.Add(dr);
            }
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = $"courses";
            svf.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                Print.DataTableToTextFile(dt, svf.FileName);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.Show();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.scoreTable.Width, this.scoreTable.Height);
            this.scoreTable.DrawToBitmap(bm, new Rectangle(0, 0, this.scoreTable.Width, this.scoreTable.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
