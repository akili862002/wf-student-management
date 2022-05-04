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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            Database sqlHanlder = new Database();
            totalStudentsLabel.Text = sqlHanlder.countTotalStudents().ToString();
            totalBoysLabel.Text = sqlHanlder.countTotalStudentsByGender(true).ToString();
            totalGirlsLabel.Text = sqlHanlder.countTotalStudentsByGender(false).ToString();
        }

        private void totalGirlsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
