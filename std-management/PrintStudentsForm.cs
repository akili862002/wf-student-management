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
using System.IO;

namespace std_management
{
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.rangeDatePickerPanel.Enabled = false;
            this.studentTableData.RowTemplate.Height = 80;
            this.fromDatePicker.Format = DateTimePickerFormat.Custom;
            this.fromDatePicker.CustomFormat = "MM/dd/yyyy";
            this.toDatePicker.Format = DateTimePickerFormat.Custom;
            this.toDatePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void PrintStudentsForm_Load(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable();
        }

        private void studentTableData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.studentTableData.Columns[e.ColumnIndex].Name == "avatarImg")
            {
                string avatarImg = this?.studentTableData?.Rows[e.RowIndex]?.Cells["avatarURLCol"]?.Value?.ToString();
                if (avatarImg?.Length < 1) return;
                Image img = Helper.ConvertBase64ToImage(avatarImg);
                e.Value = img;
            }
        }

        private void LoadDataForStudentTable(string searchText = "")
        {
            new Thread(() =>
            {
                this.studentTableLoadingProgress.Value = 20;
                Database.StudentDB sqlHandler = new Database.StudentDB();
                DataTable dt = new DataTable();

                StudentEntity.GenderType genderSelected = this.maleRadio.Checked ? StudentEntity.GenderType.Male : this.famaleRadio.Checked ? StudentEntity.GenderType.Famale : StudentEntity.GenderType.All;
                DateTime? fromDate = null;
                DateTime? toDate = null;
                bool useFilerDate = this.useDateRangeCheckbox.Checked;
                if (useFilerDate)
                {
                    fromDate = this.fromDatePicker.Value;
                    toDate = this.toDatePicker.Value;
                }

                try
                {
                    sqlHandler.getAllStudentsAdapter(searchText, genderSelected, fromDate, toDate).Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Invoke(new MethodInvoker(delegate
                {
                    this.studentTableData.DataSource = dt;
                }));
                this.studentTableLoadingProgress.Value = 100;
            }).Start();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable();
        }

        private void useDateRangeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheck = this.useDateRangeCheckbox.Checked;
            this.rangeDatePickerPanel.Enabled = isCheck;
        }

        private void saveAsTextFileButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewColumnCollection allColumns = this.studentTableData.Columns;

            foreach (DataGridViewColumn column in allColumns)
            {
                if (column is DataGridViewTextBoxColumn && column.Name != "avatarURLCol")
                    dt.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in this.studentTableData.Rows)
            {
                DataRow dr = dt.NewRow();

                foreach (DataGridViewColumn column in allColumns)
                {

                    if (column is DataGridViewTextBoxColumn &&  column.Name != "avatarURLCol")
                        if (row.Cells[column.Name].Value != null)
                        {
                            dr[column.Name] = row.Cells[column.Name].Value.ToString();
                        }
                }
                dt.Rows.Add(dr);
            }
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = $"listStudents";
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
            Bitmap bm = new Bitmap(this.studentTableData.Width, this.studentTableData.Height);
            this.studentTableData.DrawToBitmap(bm, new Rectangle(0, 0, this.studentTableData.Width, this.studentTableData.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
