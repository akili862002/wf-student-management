﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static std_management.ListStudentForm;

namespace std_management
{
    public partial class ManagerCourseForm : Form
    {
        public event OnClose OnClose;
        public ManagerCourseForm()
        {
            InitializeComponent();
        }
    }
}
