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
            this.usernameErrorLabel.Hide();
            this.passwordErrorLabel.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) == false) return;

            string username = this.usernameTextbox.Text;
            string password = this.passwordTextBox.Text;
            Database sqlHanlder = new Database();
            Database.Auth dbAuth = new Database.Auth();

            if (!dbAuth.login(username, password))
            {
                MessageBox.Show("Username or password is not correct!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            using (RegisterForm registerForm = new RegisterForm())
            {
                registerForm.ShowDialog();
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.passwordTextBox, this.passwordErrorLabel);
            if (String.IsNullOrEmpty(this.passwordTextBox.Text))
            {
                vali.error("Password is required!");
                return;
            }

            if ((this.passwordTextBox.Text.Length < 6))
            {
                vali.error("Too short!");
                return;
            }

            vali.normal();
        }

        private void usernameTextbox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.usernameTextbox, this.usernameErrorLabel);
            string text = this.usernameTextbox.Text;
            if (String.IsNullOrEmpty(text))
            {
                vali.error("Username is required!");
                return;
            }
            if ((text.Length < 6))
            {
                vali.error("Too short!");
                return;
            }
            vali.normal();
        }
    }
}
