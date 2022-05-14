using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class ManageScoreForm : Form
    {
        bool isValidStudentCode = false;
        public ManageScoreForm()
        {
            InitializeComponent();
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
        private void loadAllStudentsTable()
        {
            new Thread(() =>
            {
                try
                {
                    Database.StudentDB db = new Database.StudentDB();
                    DataTable dt = new DataTable();
                    db.getAllStudentsWithSelectAdapter("code as [Student code], first_name as [First name], last_name as [Last name], birthdate").Fill(dt);
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

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            this.resetValidation();
            this.loadDetailScoresTabel();
            this.loadDataForCourseCombobox();
        }

        private void resetValidation()
        {
            this.stdCodeErrorLabel.Hide();
            this.courseErrorLabel.Hide();
            this.scoreErrorLabel.Hide();
        }

        private void loadDataForCourseCombobox()
        {
            Database.CourseDB coursedb = new Database.CourseDB();
            SqlDataAdapter da = coursedb.getAllCourseAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.courseCombobox.DataSource = dt.Copy();
            this.courseCombobox.DisplayMember = "label";
            this.courseCombobox.ValueMember = "label";
        }

        private void studentCode_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(null, this.stdCodeTextbox, this.stdCodeErrorLabel);
            if (string.IsNullOrEmpty(this.stdCodeTextbox.Text))
            {
                vali.error("This field is required!");
                return;
            }
            vali.normal();
        }

        private void courseId_Validating(object sender, CancelEventArgs e)
        {
            ComboboxValidation vali = new ComboboxValidation(null, this.courseCombobox, this.courseErrorLabel);
            if (this.courseCombobox.SelectedItem == null)
            {
                vali.error("This field is required!");
                return;
            }
            vali.normal();
        }

        private void score_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(null, this.scoreTextBox, this.scoreErrorLabel);
            if (string.IsNullOrEmpty(this.scoreTextBox.Text))
            {
                vali.error("This field is required!");
                return;
            }
            float score = float.Parse(this.scoreTextBox.Text);
            if (score > 10)
            {
                vali.error("score must be less than 10!");
                return;
            }
            vali.normal();
        }

        private void stdCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }

        private void stdCodeTextBox_Leave(object sender, EventArgs e)
        {
            string newCode = this.stdCodeTextbox.Text;
            TextBoxValidation vali = new TextBoxValidation(null, this.stdCodeTextbox, this.stdCodeErrorLabel);
            Database.StudentDB db = new Database.StudentDB();

            if (!db.checkExistStudentCode(newCode))
            {
                vali.error("Student is not existed, please try another!");
                this.isValidStudentCode = false;
                return;
            }

            this.isValidStudentCode = true;
            vali.normal();
        }

        private void showAvgScoreButton_Click(object sender, EventArgs e)
        {
            using (AverageScoreByCourseForm avgScoreForm = new AverageScoreByCourseForm())
            {
                avgScoreForm.ShowDialog();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled) || !this.isValidStudentCode)
                return;


            DataRowView row = (DataRowView)this.courseCombobox.SelectedItem;
            Score newScore = new Score();
            newScore.setStudentCode(this.stdCodeTextbox.Text).setCourseId(row["id"].ToString()).setStudentScore(float.Parse(this.scoreTextBox.Text)).setDescription(this.descriptionTextBox.Text);

            try
            {
                Database.ScoreDB db = new Database.ScoreDB();
                if (db.checkExistScore(newScore.studentCode, newScore.courseId))
                {
                    DialogResult dialogResult = MessageBox.Show("This score was existed!, are you want to update it?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.updateScore(newScore.studentCode, newScore.courseId, newScore);
                        MessageBox.Show("Update score successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    db.createScore(newScore);
                    MessageBox.Show("Create score successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadDetailScoresTabel();
                }
                this.loadDetailScoresTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void showStudentButton_Click(object sender, EventArgs e)
        {
            this.loadAllStudentsTable();
            this.deleteButton.Hide();
        }

        private void showScoreButton_Click(object sender, EventArgs e)
        {
            this.loadDetailScoresTabel();
            this.deleteButton.Show();
        }
    }
}
