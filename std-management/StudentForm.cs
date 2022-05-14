using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static std_management.ListStudentForm;

namespace std_management
{
    public partial class StudentForm : Form
    {

        public event OnClose OnClose;
        public bool isChangeImage = false;
        public StudentEntity student = null;
        bool isEdit = false;

        bool isValidStudentCode = false;
        public StudentForm(StudentEntity student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                this.student = student;
                this.isEdit = true;
                this.titleLabel.Text = "Edit student";
                this.submitButton.Text = "Update";
            }
            else
            {
                this.deleteButton.Hide();
            }
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

            if (this.isEdit)
            {
                this.stdCodeTextBox.Text = student.code;
                this.firstNameTextBox.Text = student.first_name;
                this.lastNameTextBox.Text = student.last_name;
                this.birthdateDatePicker.Value = DateTime.Parse(student.birthdate);
                this.maleRadio.Checked = student.gender == StudentEntity.GenderType.Male.ToString();
                this.famaleRadio.Checked = student.gender == StudentEntity.GenderType.Famale.ToString();
                this.phoneTextBox.Text = student.phone;
                this.addressTextbox.Text = student.address;
                if (student.avatar.Length > 0)
                    this.avatarPicture.Image = Helper.ConvertBase64ToImage(student.avatar);
            }
        }
        private void closeDialog()
        {
            this.OnClose?.Invoke();
            this.DialogResult = DialogResult.Cancel;
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
                    StudentEntity newStudent = new StudentEntity();
                    newStudent
                       .setCode(this.stdCodeTextBox.Text)
                       .setFirstName(this.firstNameTextBox.Text)
                       .setLastName(this.lastNameTextBox.Text)
                       .setBirthdate(this.birthdateDatePicker.Value)
                       .setPhone(this.phoneTextBox.Text)
                       .setAddress(this.addressTextbox.Text)
                       .setAvatar(Helper.ConvertImageToBase64(this.avatarPicture.Image));

                    if (this.maleRadio.Checked)
                        newStudent.setGender(StudentEntity.GenderType.Male);
                    if (this.famaleRadio.Checked)
                        newStudent.setGender(StudentEntity.GenderType.Famale);
                    Database.StudentDB sqlHandler = new Database.StudentDB();
                    Cursor.Current = Cursors.WaitCursor;

                    if (this.isEdit)
                    {
                        sqlHandler.updateStudentSQL(this.student.code, newStudent);
                    }
                    else
                    {
                        sqlHandler.createStudentSQL(newStudent);
                    }

                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Add student successfully!", "Success");
                    this.closeDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            thr.Start();
        }

        private void stdCodeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.stdCodeTextBox, this.stdCodeErrorLabel);
            if (string.IsNullOrEmpty(stdCodeTextBox.Text))
            {
                vali.error("Student code is required!");
                return;
            }
            vali.normal();
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
            Database.StudentDB db = new Database.StudentDB();

            if (this.isEdit && newCode == this.student.code)
            {
                // pass
            }
            else if (db.checkExistStudentCode(newCode))
            {
                vali.error("Student code was existed!, Please try another one");
                this.isValidStudentCode = false;
                return;
            }

            this.isValidStudentCode = true;
            vali.normal();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Database.StudentDB sqlHandler = new Database.StudentDB();
                sqlHandler.deleteStudentByIdSQL(student.code);
                MessageBox.Show("Delete student successfully!", "Success!");
                this.closeDialog();
            }).Start();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.closeDialog();
        }
    }
}
