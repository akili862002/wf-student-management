using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace std_management
{
    public partial class ListStudentForm : Form
    {
        public delegate void UpdateDataHandler();
        public delegate void OnClose();

        public ListStudentForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.studentTableData.RowTemplate.Height = 80;
        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable();
        }

        private void LoadDataForStudentTable(string searchText = "")
        {
            new Thread(() =>
            {
                this.studentTableLoadingProgress.Value = 20;
                Database sqlHandler = new Database();
                DataTable dt = new DataTable();
                sqlHandler.getAllStudentsAdapter(searchText).Fill(dt);
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
      
        private void studentTableData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.studentTableData.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.studentTableData.Rows[currentIndex];
            StudentEntity student = new StudentEntity();
            student
            .setCode(row.Cells["code"].Value.ToString())
            .setFirstName(row.Cells["first_name"].Value.ToString())
            .setLastName(row.Cells["last_name"].Value.ToString())
            .setBirthdate(DateTime.Parse(row.Cells["birth_date"].Value.ToString()))
            .setPhone(row.Cells["phone"].Value.ToString())
            .setGender(row.Cells["gender"].Value.ToString() == "Male" ? StudentEntity.GenderType.Male : StudentEntity.GenderType.Famale)
            .setAddress(row.Cells["address"].Value.ToString())
            .setAvatar(row.Cells["avatarURLCol"].Value.ToString());

            using (StudentForm editStudentForm = new StudentForm(student))
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
