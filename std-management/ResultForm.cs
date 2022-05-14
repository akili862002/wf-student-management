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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            this.loadDataForResultTable();
        }

        private void loadDataForResultTable()
        {
            Database.ScoreDB db = new Database.ScoreDB();
            try
            {
                DataTable dt = new DataTable();
                db.getAllScoreResultByStudentsAdapter(
                    this.stdCodeTextBox.Text,
                    this.firstnameTextBox.Text,
                    this.lastNameTextBox.Text, 
                    this.codeAndFirstNameTextBox.Text
                ).Fill(dt);
                this.resultDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.loadDataForResultTable();
        }

        private void toFileButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewColumnCollection allColumns = this.resultDataGridView.Columns;

            foreach (DataGridViewColumn column in allColumns)
            {
                if (column is DataGridViewTextBoxColumn && column.Name != "avatarURLCol")
                    dt.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in this.resultDataGridView.Rows)
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
            svf.FileName = $"results";
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
            Bitmap bm = new Bitmap(this.resultDataGridView.Width, this.resultDataGridView.Height);
            this.resultDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.resultDataGridView.Width, this.resultDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
