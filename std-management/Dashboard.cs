﻿using System;
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
    public partial class DashboardForm : Form
    {
        public delegate void UpdateDataHandler();
        public DashboardForm()
        {
            InitializeComponent();
            using (AddStudentForm addStudentForm = new AddStudentForm())
            {
                addStudentForm.ShowDialog();
            }
            
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddStudentForm addStudentForm = new AddStudentForm())
            {
                addStudentForm.ShowDialog();
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }
    }
}