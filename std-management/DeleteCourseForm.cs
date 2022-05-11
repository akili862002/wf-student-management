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
    public partial class DeleteCourseForm : Form
    {
        bool isValidCourseId = false;
        public DeleteCourseForm()
        {
            InitializeComponent();
            this.courseIdErrorLabel.Hide();
        }

        private void DeleteCourse_Load(object sender, EventArgs e)
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

        private void courseIdTextbox_Leave(object sender, EventArgs e)
        {
            Database.CourseDB courseDb = new Database.CourseDB();
            TextBoxValidation vali = new TextBoxValidation(null, this.courseIdTextbox, this.courseIdErrorLabel);
            if (!courseDb.checkExistCourseId(this.courseIdTextbox.Text))
            {
                vali.error("Not found any course has id");
                this.isValidCourseId = false;
                return;
            }
            vali.normal();
            this.isValidCourseId = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled) || !this.isValidCourseId)
                return;

            Database.CourseDB courseDb = new Database.CourseDB();

            new Thread(() =>
            {
                try
                {
                    courseDb.deleteCourseId(this.courseIdTextbox.Text);
                    MessageBox.Show("Delete course successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.closeDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }).Start();
        }

        private void closeDialog()
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
