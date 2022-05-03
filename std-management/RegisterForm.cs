using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace std_management
{
    public partial class RegisterForm : Form
    {
        bool isValidUsername = false;
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
            if (!string.IsNullOrEmpty(confirmPasswordTextBox.Text) && passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                e.Cancel = true;
                confirmPasswordTextBox.Focus();
                errorProviderConfirmPassword.SetError(confirmPasswordTextBox, "Password is not match!");
                return;
            }
            e.Cancel = false;
            errorProviderConfirmPassword.SetError(confirmPasswordTextBox, "");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.validateUsername();
            if (!ValidateChildren(ValidationConstraints.Enabled) || !this.isValidUsername)
            {
                return;
            }
            new Thread(() =>
            {
                SQLHandler sqlHandler = new SQLHandler();
                string username = usernameTextbox.Text;
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;
                sqlHandler.register(username, password, email);
                MessageBox.Show("Register successfully!\nYour account was created. Please login", "Register success");
                this.DialogResult = DialogResult.OK;
            }).Start();
        }

        private bool validateUsername ()
        {
            SQLHandler sqlHanlder = new SQLHandler();
            if (sqlHanlder.checkExistUsername(usernameTextbox.Text))
            {
                this.isValidUsername = false;
                usernameTextbox.Focus();
                errorProviderUsername.SetError(usernameTextbox, $"Username was used!\nPlease try another one!");
                return false;
            }
            this.isValidUsername = true;
            errorProviderUsername.SetError(confirmPasswordTextBox, "");
            return true;
        }

        private void usernameTextbox_MouseLeave(object sender, EventArgs e)
        {
            this.validateUsername();
        }
    }
}
