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
using static std_management.DashboardForm;

namespace std_management
{
    public partial class EditStudentForm : Form
    {
        public event OnClose OnClose;
        public StudentEntity student; 
        public EditStudentForm(StudentEntity student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            birthdateDatePicker.Format = DateTimePickerFormat.Custom;
            birthdateDatePicker.CustomFormat = "MM/dd/yyyy";

            // Init components data
            this.firstNameTextBox.Text = student.first_name;
            this.lastNameTextBox.Text = student.last_name;
            this.birthdateDatePicker.Value = DateTime.Parse(student.birthdate);
            this.maleRadio.Checked = student.gender == StudentEntity.GenderType.Male.ToString();
            this.famaleRadio.Checked = student.gender == StudentEntity.GenderType.Famale.ToString();
            this.phoneTextBox.Text = student.phone;
            this.addressTextbox.Text = student.address;
            if (student.avatar.Length > 0)
                this.avatarPicture.Image = Helper.GetImageFromUrl(student.avatar);
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

        private void closeDialog()
        {
            this.OnClose();
            this.DialogResult = DialogResult.Cancel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closeDialog();
        }

        private void upateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }


            Thread thr = new Thread(() =>
            {

                int stdId = this.student.id;
                StudentEntity student = new StudentEntity();
                student
                   .setFirstName(this.firstNameTextBox.Text)
                   .setLastName(this.lastNameTextBox.Text)
                   .setBirthdate(this.birthdateDatePicker.Value)
                   .setPhone(this.phoneTextBox.Text)
                   .setAddress(this.addressTextbox.Text)
                   .setAvatar("https://cdn-icons-png.flaticon.com/128/149/149071.png");
                if (this.maleRadio.Checked)
                    student.setGender(StudentEntity.GenderType.Male);
                if (this.famaleRadio.Checked)
                    student.setGender(StudentEntity.GenderType.Famale);
                SQLHandler sqlHandler = new SQLHandler();

                Cursor.Current = Cursors.WaitCursor;
                sqlHandler.updateStudentSQL(stdId ,student);
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Update student successfully!", "Update success");
                this.closeDialog();
            });

            thr.Start();
        }

        #region Validations
        private void firstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                e.Cancel = true;
                firstNameTextBox.Focus();
                errorProviderFullName.SetError(firstNameTextBox, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProviderFullName.SetError(firstNameTextBox, "");
            }
        }

        private void lastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                e.Cancel = true;
                lastNameTextBox.Focus();
                errorProviderLastName.SetError(lastNameTextBox, "This field is required!");
                return;
            }
            e.Cancel = false;
            errorProviderLastName.SetError(lastNameTextBox, "");
        }


        #endregion

        private void phoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                e.Cancel = true;
                phoneTextBox.Focus();
                errorProviderPhone.SetError(phoneTextBox, "This field is required!");
                return;
            }
            /**
            if (!Validation.IsPhoneNumber(phoneTextBox.Text))
            {
                e.Cancel = true;
                phoneTextBox.Focus();
                errorProviderPhone.SetError(phoneTextBox, "Phone is not valid!");
                return;
            }
            **/
            e.Cancel = false;
            errorProviderPhone.SetError(phoneTextBox, "");
        }

        private void addressTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(addressTextbox.Text))
            {
                e.Cancel = true;
                addressTextbox.Focus();
                errorProviderAddress.SetError(addressTextbox, "This field is required!");
                return;
            }
            e.Cancel = false;
            errorProviderAddress.SetError(addressTextbox, "");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            SQLHandler sqlHandler = new SQLHandler();
            sqlHandler.deleteStudentByIdSQL(student.id);
        }
    }
}
