﻿using System;
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
                SQLHandler sqlHandler = new SQLHandler();
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

            int currentIndex = this.studentTableData.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.studentTableData.Rows[currentIndex];
            StudentEntity student = new StudentEntity();
            student
            .setId(Int32.Parse(row.Cells["id"].Value.ToString()))
            .setFirstName(row.Cells["first_name"].Value.ToString())
            .setLastName(row.Cells["last_name"].Value.ToString())
            .setBirthdate(DateTime.Parse(row.Cells["birth_date"].Value.ToString()))
            .setPhone(row.Cells["phone"].Value.ToString())
            .setGender(row.Cells["gender"].Value.ToString() == "Male" ? StudentEntity.GenderType.Male : StudentEntity.GenderType.Famale)
            .setAddress(row.Cells["address"].Value.ToString())
            .setAvatar(row.Cells["avatarURLCol"].Value.ToString());


            using (EditStudentForm editStudentForm = new EditStudentForm(student))
            {
                editStudentForm.OnClose += () =>
                {
                    this.LoadDataForStudentTable();
                };

                editStudentForm.ShowDialog();
            }
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StatisticForm statisticForm = new StatisticForm())
            {
                statisticForm.ShowDialog();
            }
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddNewCourseForm addNewCourseForm = new AddNewCourseForm())
            {
                addNewCourseForm.ShowDialog();
            }
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DeleteCourseForm deleteCourseForm = new DeleteCourseForm())
            {
                deleteCourseForm.ShowDialog();
            }
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditCourseForm editCourseForm = new EditCourseForm())
            {
                editCourseForm.ShowDialog();
            }
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ManagerCourseForm managerCourseForm = new ManagerCourseForm())
            {
                managerCourseForm.OnClose += () =>
                {
                    this.LoadDataForStudentTable();
                };
                managerCourseForm.ShowDialog();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintCourseForm printCourseForm = new PrintCourseForm())
            {
                printCourseForm.ShowDialog();
            }
        }

        private void avgScoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ResultForm resultForm = new ResultForm())
            {
                resultForm.ShowDialog();
            }
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StaticScoreForm staticScoreForm = new StaticScoreForm())
            {
                staticScoreForm.ShowDialog();
            }
        }
    }
}