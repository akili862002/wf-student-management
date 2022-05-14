using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class EditCourseForm : Form
    {
        Course course;

        public EditCourseForm()
        {
            InitializeComponent();
            resetAllValidation();
        }

        private void resetAllValidation()
        {
            this.labelErrorLabel.Hide();
            this.periodErrorLabel.Hide();
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            this.loadDataForCombobox();
        }



        private void loadDataForCombobox()
        {
            Database.CourseDB coursedb = new Database.CourseDB();
            SqlDataAdapter da = coursedb.getAllCourseAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.courseCombobox.DataSource = dt.Copy();
            this.courseCombobox.DisplayMember = "label";
            this.courseCombobox.ValueMember = "label";
        }

        private void initEditMode()
        {
            if (this.course == null) return;
            this.resetAllValidation();

            this.labelTexBox.Text = this.course.label;
            this.descTextBox.Text = this.course.description;
            this.periodUpdown.Value = this.course.preiod;
        }

        private void courseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)this.courseCombobox.SelectedItem;
            Course newCourse = new Course();
            newCourse.setId(row["id"].ToString()).setLabel(row["label"].ToString()).setPreiod(Int32.Parse(row["preiod"].ToString())).setDescription(row["description"].ToString());
            this.course = newCourse;
            this.initEditMode();
        }

        private void labelTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.labelTexBox, this.labelErrorLabel);
            if (string.IsNullOrEmpty(this.labelTexBox.Text))
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

            Database.CourseDB db = new Database.CourseDB();
            Course newCourse = new Course();
            newCourse
                .setId(this.course.id)
                .setLabel(this.labelTexBox.Text)
                .setPreiod(Convert.ToInt32(this.periodUpdown.Value))
                .setDescription(this.descTextBox.Text);
            try
            {
                db.updateCourse(this.course.id, newCourse);
                MessageBox.Show("Update course successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
