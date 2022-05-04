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
            return number.Length > 8;
        }
        public static bool IsEmail(string email)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            return reg.IsMatch(email);
        }
    }

    class ValidateKeyPress
    {
        KeyPressEventArgs e;
        object sender;

        public ValidateKeyPress(object sender, KeyPressEventArgs e)
        {
            this.e = e;
            this.sender = sender;
        }

        public void justAllowNumber()
        {
            if (!char.IsControl(this.e.KeyChar) && !char.IsDigit(this.e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void justAllowAlphabet()
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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
