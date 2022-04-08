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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            registerTooltip.SetToolTip(registerLabel, "Click to register");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextbox.Text;
            string password = this.passwordTextBox.Text;
            SQLHandler sqlHanlder = new SQLHandler();

            if (!sqlHanlder.login(username, password))
            {
                MessageBox.Show("Username or password is not correct!", "Login error");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
