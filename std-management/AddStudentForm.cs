using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static std_management.ListStudentForm;

namespace std_management
{
    public partial class AddStudentForm : Form
    {
        bool isValidStudentCode = false;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            birthdateDatePicker.Format = DateTimePickerFormat.Custom;
            birthdateDatePicker.CustomFormat = "MM/dd/yyyy";
            this.stdCodeErrorLabel.Hide();
            this.firstNameErrorLabel.Hide();
            this.lastNameErrorLabel.Hide();
            this.phoneErrorLabel.Hide();
            this.addressErrorLabel.Hide();
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

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;


            Thread thr = new Thread(() =>
            {
                try
                {
                    StudentEntity student = new StudentEntity();
                    student
                       .setCode(this.stdCodeTextBox.Text)
                       .setFirstName(this.firstNameTextBox.Text)
                       .setLastName(this.lastNameTextBox.Text)
                       .setBirthdate(this.birthdateDatePicker.Value)
                       .setPhone(this.phoneTextBox.Text)
                       .setAddress(this.addressTextbox.Text)
                       .setAvatar(Helper.ConvertImageToBase64(this.avatarPicture.Image));

                    if (this.maleRadio.Checked)
                        student.setGender(StudentEntity.GenderType.Male);
                    if (this.famaleRadio.Checked)
                        student.setGender(StudentEntity.GenderType.Famale);
                    Database sqlHandler = new Database();
                    Cursor.Current = Cursors.WaitCursor;
                    sqlHandler.createStudentSQL(student);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Add student successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            thr.Start();
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

        private void stdCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
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

        private void stdCodeTextBox_Leave(object sender, EventArgs e)
        {
            string newCode = this.stdCodeTextBox.Text;
            TextBoxValidation vali = new TextBoxValidation(null, this.stdCodeTextBox, this.stdCodeErrorLabel);
            Database db = new Database();

            if (db.checkExistStudentCode(newCode))
            {
                vali.error("Student code was existed!, Please try another one");
                this.isValidStudentCode = false;
                return;
            }

            this.isValidStudentCode = true;
            vali.normal();
        }
    }
}
