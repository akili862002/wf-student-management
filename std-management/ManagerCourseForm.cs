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
using static std_management.ListStudentForm;

namespace std_management
{
    public partial class ManagerCourseForm : Form
    {
        bool isEdit;
        Course course;
        bool isValidCourseId = false;

        public ManagerCourseForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.resetAllValidation();
            this.loadDataForListBox();
        }

        private void ManagerCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void loadDataForListBox()
        {
            try
            {
                Database.CourseDB coursedb = new Database.CourseDB();
                SqlDataAdapter da = coursedb.getAllCourseAdapter();
                int totalCount = coursedb.countCourses();
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.courseListBox.DataSource = dt;
                this.courseListBox.DisplayMember = "label";
                this.courseListBox.ValueMember = "label";
                this.listCourseLabel.Text = $"List Courses ({totalCount})";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void initCreateMode()
        {
            this.isEdit = false;
            this.submitButton.Text = "Create";
            this.resetAllValidation();
            this.deleteButton.Hide();

            this.courseIdTextBox.Text = "";
            this.labelTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.periodUpdown.Value = 0;
        }

        private void initEditMode()
        {
            if (this.course == null) return;

            this.isEdit = true;
            this.submitButton.Text = "Edit";
            this.resetAllValidation();
            this.deleteButton.Show();

            this.courseIdTextBox.Text = this.course.id;
            this.labelTextBox.Text = this.course.label;
            this.descriptionTextBox.Text = this.course.description;
            this.periodUpdown.Value = this.course.preiod;
        }

        private void resetAllValidation()
        {
            this.courseIdErrorLabel.Hide();
            this.labelErrorLabel.Hide();
            this.periodErrorLabel.Hide();
        }
        private void closeDialog()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void courseIdTextbox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.courseIdTextBox, this.courseIdErrorLabel);
            if (string.IsNullOrEmpty(this.courseIdTextBox.Text))
            {
                vali.error("This field is required!");
                return;
            }
            vali.normal();
        }

        private void labelTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.labelTextBox, this.labelErrorLabel);
            if (string.IsNullOrEmpty(this.labelTextBox.Text))
            {
                vali.error("This field is required!");
                return;
            }
            vali.normal();
        }

        private void periodUpdown_Validating(object sender, CancelEventArgs e)
        {
            UpDownValidation vali = new UpDownValidation(e, this.periodUpdown, this.periodErrorLabel);
            if (this.periodUpdown.Value <= 0)
            {
                vali.error("This field must me great than 0");
                return;
            }
            vali.normal();
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)this.courseListBox.SelectedItem;
            Course newCourse = new Course();
            newCourse.setId(row["id"].ToString()).setLabel(row["label"].ToString()).setPreiod(Int32.Parse(row["preiod"].ToString())).setDescription(row["description"].ToString());
            this.course = newCourse;
            this.initEditMode();
        }

        private void courseIdTextbox_Leave(object sender, EventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(null, this.courseIdTextBox, this.courseIdErrorLabel, false);
            if (this.isEdit && this.courseIdTextBox.Text == this.course.id)
            {
                vali.normal();
                this.isValidCourseId = true;
                return;
            }
            Database.CourseDB courseDb = new Database.CourseDB();
            if (courseDb.checkExistCourseId(this.courseIdTextBox.Text))
            {
                vali.error("Course id was used!, please try another one!");
                this.isValidCourseId = false;
                return;
            }
            vali.normal();
            this.isValidCourseId = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Database.CourseDB db = new Database.CourseDB();
            new Thread(() =>
            {
                try
                {
                    db.deleteCourseId(this.courseIdTextBox.Text);
                    MessageBox.Show("Delete course successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadDataForListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }).Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.initCreateMode();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled) || !this.isValidCourseId)
                return;

            Database.CourseDB db = new Database.CourseDB();
            Course newCourse = new Course();
            newCourse
                .setId(this.courseIdTextBox.Text)
                .setLabel(this.labelTextBox.Text)
                .setPreiod(Convert.ToInt32(this.periodUpdown.Value))
                .setDescription(this.descriptionTextBox.Text);
            try
            {
                if (this.isEdit)
                {
                    db.updateCourse(this.course.id, newCourse);
                    MessageBox.Show("Update course successfully!", "Success");
                }
                else
                {
                    db.createCourse(newCourse);
                    MessageBox.Show("Create course successfully!", "Success");
                    this.initCreateMode();
                }
                this.loadDataForListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
