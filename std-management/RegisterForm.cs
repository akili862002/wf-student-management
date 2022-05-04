using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace std_management
{
    public partial class RegisterForm : Form
    {
        bool isValidUsername = true;

        public RegisterForm()
        {
            InitializeComponent();
            this.emailErrorLabel.Hide();
            this.usernameErrorLabel.Hide();
            this.passwordErorrLabel.Hide();
            this.confirmPasswordErrorLabel.Hide();
        }


        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation validation = new TextBoxValidation(e, this.emailTextBox, this.emailErrorLabel);

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                validation.error("This field is required!");
                return;
            }
            if (Validation.IsEmail(this.emailTextBox.Text) == false)
            {
                validation.error("Error is not valid!");
                return;
            }
            validation.normal();
        }

        private void usernameTextbox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation validation = new TextBoxValidation(e, this.usernameTextbox, this.usernameErrorLabel);
            if (string.IsNullOrEmpty(usernameTextbox.Text))
            {
                validation.error("Username is required!");
                return;
            }
            if (usernameTextbox.Text.Length < 6)
            {
                validation.error("Too short!");
                return;
            }
            validation.normal();
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation validation = new TextBoxValidation(e, this.passwordTextBox, this.passwordErorrLabel);
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                validation.error("Password is required!");
                return;
            }
            if (passwordTextBox.Text.Length < 6)
            {
                validation.error("Too short!");
                return;
            }
            validation.normal();
        }

        private void confirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation validation = new TextBoxValidation(e, this.confirmPasswordTextBox, this.confirmPasswordErrorLabel);
            if (!string.IsNullOrEmpty(confirmPasswordTextBox.Text) && passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                validation.error("Password is not match!");
                return;
            }
            validation.normal();
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
                Database.Auth dbAuth = new Database.Auth();
                string username = usernameTextbox.Text;
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;
                dbAuth.register(username, password, email);
                MessageBox.Show("Register successfully!\nYour account was created. Please login", "Register success");
                this.DialogResult = DialogResult.OK;
            }).Start();
        }

        private bool validateUsername()
        {
            Database.Auth dbAuth = new Database.Auth();
            TextBoxValidation validation = new TextBoxValidation(null, this.usernameTextbox, this.usernameErrorLabel);

            if (dbAuth.checkExistUsername(usernameTextbox.Text))
            {
                this.isValidUsername = false;
                validation.error("Username was used!, Please try another one!");
                return false;
            }

            this.isValidUsername = true;
            validation.normal();
            return true;
        }

        private void usernameTextbox_Leave(object sender, EventArgs e)
        {
            this.validateUsername();
        }
    }
}
