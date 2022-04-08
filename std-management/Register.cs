using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                e.Cancel = true;
                emailTextBox.Focus();
                errorProviderEmail.SetError(emailTextBox, "This field is required!");
                return;
            }
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase); ///Object initialization for Regex 
            if (reg.IsMatch(this.emailTextBox.Text) == false)
            {
                e.Cancel = true;
                emailTextBox.Focus();
                errorProviderEmail.SetError(emailTextBox, "Email is not valid!");
                return;
            }

            e.Cancel = false;
            errorProviderEmail.SetError(emailTextBox, "");
        }

        private void usernameTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextbox.Text))
            {
                e.Cancel = true;
                usernameTextbox.Focus();
                errorProviderUsername.SetError(usernameTextbox, "This field is required!");
                return;
            }
            if (usernameTextbox.Text.Length < 6)
            {
                e.Cancel = true;
                usernameTextbox.Focus();
                errorProviderUsername.SetError(usernameTextbox, "Too short!");
                return;
            }
            e.Cancel = false;
            errorProviderUsername.SetError(usernameTextbox, "");
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                e.Cancel = true;
                passwordTextBox.Focus();
                errorProviderPassword.SetError(passwordTextBox, "This field is required!");
                return;
            }
            if (passwordTextBox.Text.Length < 6)
            {
                e.Cancel = true;
                passwordTextBox.Focus();
                errorProviderPassword.SetError(passwordTextBox, "Too short!");
                return;
            }
            e.Cancel = false;
            errorProviderPassword.SetError(passwordTextBox, "");
        }

        private void confirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                e.Cancel = true;
                confirmPasswordTextBox.Focus();
                errorProviderConfirmPassword.SetError(confirmPasswordTextBox, "Password is not match!");
                return;
            }
            e.Cancel = false;
            errorProviderConfirmPassword.SetError(confirmPasswordTextBox, "");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

        }
    }
}
