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
        Course courseSelected = new Course();

        public EditCourseForm()
        {
            InitializeComponent();
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

        private void courseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.courseCombobox.GetItemText(this.courseCombobox.SelectedItem);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
