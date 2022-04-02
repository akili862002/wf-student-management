using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace std_management
{

    public partial class DashboardForm : Form
    {
        public delegate void UpdateDataHandler();
        public delegate void OnClose();
        public DashboardForm()
        {
            InitializeComponent();
            using (AddStudentForm addStudentForm = new AddStudentForm())
            {
                // addStudentForm.ShowDialog();
            }

        }
        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddStudentForm addStudentForm = new AddStudentForm())
            {
                addStudentForm.OnClose += () =>
                {
                    this.LoadDataForStudentTable();
                };

                addStudentForm.ShowDialog();
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable();
        }

        private void LoadDataForStudentTable()
        {
            SQLHandler sqlHandler = new SQLHandler();
            DataTable dt = new DataTable();
            sqlHandler.getAllStudentsAdapter().Fill(dt);
            this.Invoke(new MethodInvoker(delegate {
                this.studentTableData.DataSource = dt;
            }));
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable();
        }

        private void studentTableData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.studentTableData.Columns[e.ColumnIndex].Name == "avatarImg")
            {
                new Thread(() =>
                {

            //this.Invoke(new MethodInvoker(delegate {
                    string avatarImg = this?.studentTableData?.Rows[e.RowIndex]?.Cells["avatarURLCol"]?.Value?.ToString();
                    if (avatarImg?.Length < 1) return;
                    Image img = Helper.GetImageFromUrl(avatarImg);
                    e.Value = img;
            //}));
                }).Start();
            }
        }

    }
}
