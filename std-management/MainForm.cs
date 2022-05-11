using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public delegate void UpdateDataHandler();
    public delegate void OnClose();

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StudentForm addStudentForm = new StudentForm())
            {
                addStudentForm.ShowDialog();
            }
        }

        private void editRemoveStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (EditStudentForm editStudentForm = new EditStudentForm())
            //{
            //    editStudentForm.ShowDialog();
            //}
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
            using (DeleteCourseForm deleteCourse = new DeleteCourseForm())
            {
                deleteCourse.ShowDialog();
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

        private void addScoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (AddScoreForm addScoreForm = new AddScoreForm())
            {
                addScoreForm.ShowDialog();
            }
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RemoveScoreFrom removeScoreForm = new RemoveScoreFrom())
            {
                removeScoreForm.ShowDialog();
            }
        }

        private void managerScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ManageScoreForm manageScoreForm = new ManageScoreForm())
            {
                manageScoreForm.ShowDialog();
            }
        }

        private void avgScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AverageScoreByCourseForm avgScoreByCourseForm = new AverageScoreByCourseForm())
            {
                avgScoreByCourseForm.ShowDialog();
            }
        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintScoreForm printScoreForm = new PrintScoreForm())
            {
                printScoreForm.ShowDialog();
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

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ListStudentForm listStudentForm = new ListStudentForm())
            {
                listStudentForm.ShowDialog();
            }
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ManageStudentForm manageStudentForm = new ManageStudentForm())
            {
                manageStudentForm.ShowDialog();
            }
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (PrintStudentsForm printStudentForm = new PrintStudentsForm())
            {
                printStudentForm.ShowDialog();
            }
        }
    }
}
