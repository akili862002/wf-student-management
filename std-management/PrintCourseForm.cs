using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
            this.loadDataCourseTable();
        }

        private void loadDataCourseTable()
        {
            try
            {
                Database.CourseDB coursedb = new Database.CourseDB();
                SqlDataAdapter da = coursedb.getAllCourseAdapter(true);
                int totalCount = coursedb.countCourses();
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.courseTableData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toFileButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewColumnCollection allColumns = this.courseTableData.Columns;

            foreach (DataGridViewColumn column in allColumns)
            {
                if (column is DataGridViewTextBoxColumn && column.Name != "avatarURLCol")
                    dt.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in this.courseTableData.Rows)
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
            Bitmap bm = new Bitmap(this.courseTableData.Width, this.courseTableData.Height);
            this.courseTableData.DrawToBitmap(bm, new Rectangle(0, 0, this.courseTableData.Width, this.courseTableData.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
