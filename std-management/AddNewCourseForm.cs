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

namespace std_management
{
    public partial class AddNewCourseForm : Form
    {
        bool isValidCourseId = false;
        public AddNewCourseForm()
        {
            InitializeComponent();
            this.courseIdErrorLabel.Hide();
            this.labelErrorLabel.Hide();
            this.periodErrorLabel.Hide();
        }

        private void AddNewCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void courseIdTextbox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.courseIdTextbox, this.courseIdErrorLabel);
            if (string.IsNullOrEmpty(this.courseIdTextbox.Text))
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
        private void closeDialog()
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

            Course course = new Course();
            course.
                setId(this.courseIdTextbox.Text)
                .setLabel(this.labelTextBox.Text)
                .setPreiod(Convert.ToInt32(this.periodUpdown.Value))
                .setDescription(this.descriptionTextBox.Text);

            Database.CourseDB courseDb = new Database.CourseDB();
            new Thread(() =>
            {
                try
                {
                    courseDb.createCourse(course);
                    MessageBox.Show("Add course successfully!", "Success");
                    this.closeDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }).Start();

        }

        private void courseIdTextbox_Leave(object sender, EventArgs e)
        {
            Database.CourseDB courseDb = new Database.CourseDB();
            TextBoxValidation vali = new TextBoxValidation(null, this.courseIdTextbox, this.courseIdErrorLabel, false);
            if (courseDb.checkExistCourseId(this.courseIdTextbox.Text))
            {
                vali.error("Course id was used!, please try another one!");
                this.isValidCourseId = false;
                return;
            }
            vali.normal();
            this.isValidCourseId = true;
        }
         }
}
