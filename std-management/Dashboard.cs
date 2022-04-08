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
            Control.CheckForIllegalCrossThreadCalls = false;
            using (AddStudentForm addStudentForm = new AddStudentForm())
            {
                // addStudentForm.ShowDialog();
            }

        }
      

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable();
        }

        private void LoadDataForStudentTable(string searchText = "")
        {
            SQLHandler sqlHandler = new SQLHandler();
            DataTable dt = new DataTable();
            sqlHandler.getAllStudentsAdapter(searchText).Fill(dt);
            this.Invoke(new MethodInvoker(delegate
            {
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
                    string avatarImg = this?.studentTableData?.Rows[e.RowIndex]?.Cells["avatarURLCol"]?.Value?.ToString();
                    if (avatarImg?.Length < 1) return;
                    Image img = Helper.GetImageFromUrl(avatarImg);
                    e.Value = img;
                }).Start();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable(searchTextBox.Text);
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoadDataForStudentTable(searchTextBox.Text);
                searchTextBox.Text = "";
                return;
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

        private void editRemoveStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditStudentForm editStudentForm = new EditStudentForm())
            {
                editStudentForm.OnClose += () =>
                {
                    this.LoadDataForStudentTable();
                };

                editStudentForm.ShowDialog();
            }
        }
    }
}
