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
    public partial class AddScoreForm : Form
    {
        bool isValidStudentCode = false;

        public AddScoreForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.resetValidation();
            this.loadDataForCourseCombobox();
            this.loadListStudentsTable();
        }

        private void loadListStudentsTable()
        {
            new Thread(() =>
            {
                Database.StudentDB db = new Database.StudentDB();
                DataTable dt = new DataTable();
                db.getAllStudentsWithFormatSelectionAdapter("code as [Student code], first_name as [First name], last_name as [Last name]").Fill(dt);
                this.Invoke(new MethodInvoker(delegate
                {
                    this.listStudentTable.DataSource = dt;
                }));
            }).Start();
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

        private void addScoreButton_Click(object sender, EventArgs e)
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
                    this.loadListStudentsTable();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listStudentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.listStudentTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.listStudentTable.Rows[currentIndex];
            this.stdCodeTextbox.Text = row.Cells["Student code"].Value.ToString();
        }
    }
}
