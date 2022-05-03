using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace std_management
{
    class Validation
    {
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
        public static bool IsEmail(string email)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            return reg.IsMatch(email);
        }
    }
    class TextBoxValidation
    {
        CancelEventArgs e;
        TextBox textBox;
        Label errorLabel;
        public TextBoxValidation(CancelEventArgs e, TextBox textBox, Label errorLabel)
        {
            this.e = e;
            this.textBox = textBox;
            this.errorLabel = errorLabel;
        }
        public void error(string message)
        {
            if (this.e != null)
                this.e.Cancel = true;
            this.textBox.Focus();
            this.errorLabel.Text = message;
            this.errorLabel.Show();
        }
        public void normal()
        {
            if (this.e != null)
                this.e.Cancel = false;
            this.errorLabel.Text = "";
            this.errorLabel.Hide();
        }
    }

}
