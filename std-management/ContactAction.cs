using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class ContactAction : Form
    {
        bool isEdit = false;
        public ContactAction(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            resetValidations();
            if (this.isEdit)
                this.initEditMode();
            else
                this.initCreateMode();
        }

        private void initEditMode()
        {
            this.titleLabel.Text = "Edit contact";
            this.deleteButton.Show();
            this.submitButton.Text = "Update";
        }

        private void initCreateMode()
        {
                this.titleLabel.Text = "Create new contact";
                this.deleteButton.Hide();
            this.submitButton.Text = "Create";
        }

        private void ContactAction_Load(object sender, EventArgs e)
        {
            
        }
        private void uploadAvatarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(opnfd.FileName);
                Console.WriteLine("w: " + img.Width);
                Console.WriteLine("h: " + img.Height);
                if (img.Width != img.Height)
                {
                    MessageBox.Show(String.Format("Please select a square image! ({0}x{1})", img.Width, img.Height), "Error");
                    return;
                }
                this.avatarPicture.Image = img;
            }
        }

        private void resetValidations()
        {
            this.firstNameErrorLabel.Hide();
            this.lastNameErrorLabel.Hide();
            this.groupErrorLabel.Hide();
            this.phoneErrorLabel.Hide();
            this.emailErrorLabel.Hide();
            this.addressErrorLabel.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.firstNameTextBox, this.firstNameErrorLabel);
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                vali.error("Firstname is required!");
                return;
            }
            vali.normal();
        }

        private void lastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            TextBoxValidation vali = new TextBoxValidation(e, this.lastNameTextBox, this.lastNameErrorLabel);
            if (string.IsNullOrEmpty(this.lastNameTextBox.Text))
            {
                vali.error("Lastname is required!");
                return;
            }
            vali.normal();
        }

        private void phoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = this.phoneTextBox.Text;
            TextBoxValidation vali = new TextBoxValidation(e, this.phoneTextBox, this.phoneErrorLabel);
            if (string.IsNullOrEmpty(text))
            {
                vali.error("Phone number is required!");
                return;
            }

            if (!Validation.IsPhoneNumber(text))
            {
                vali.error("Phone number is not valid!");
                return;
            }

            vali.normal();
        }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = this.emailTexBox.Text;
            TextBoxValidation vali = new TextBoxValidation(e, this.emailTexBox, this.emailErrorLabel);
            if (string.IsNullOrEmpty(text))
            {
                vali.error("Email is required!");
                return;
            }

            if (!Validation.IsEmail(text))
            {
                vali.error("Email is not valid!");
                return;
            }

            vali.normal();
        }

        private void addressTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.addressTextbox, this.addressErrorLabel);
            if (string.IsNullOrEmpty(addressTextbox.Text))
            {
                vali.error("Address is required!");
                return;
            }
            vali.normal();
        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowAlphabet();
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowAlphabet();
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }
 private void groupCombobox_Validating(object sender, CancelEventArgs e)
        {
            ComboboxValidation vali = new ComboboxValidation(e, this.groupCombobox, this.groupErrorLabel);
            if (this.groupCombobox.SelectedItem == null)
            {
                vali.error("This field is required!");
                return;
            }
            vali.normal();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

                    ContactEntity contact = new ContactEntity();
                    //newStudent
                    //   .setCode(this.stdCodeTextBox.Text)
                    //   .setFirstName(this.firstNameTextBox.Text)
                    //   .setLastName(this.lastNameTextBox.Text)
                    //   .setBirthdate(this.birthdateDatePicker.Value)
                    //   .setPhone(this.phoneTextBox.Text)
                    //   .setAddress(this.addressTextbox.Text)
                    //   .setAvatar(Helper.ConvertImageToBase64(this.avatarPicture.Image));

                    Database.ContactDB db = new Database.ContactDB();
            Thread thr = new Thread(() =>
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (this.isEdit)
                    {
                        MessageBox.Show("Update contact successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update contact successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Cursor.Current = Cursors.Default;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
        }
}
