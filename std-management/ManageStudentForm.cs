using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class ManageStudentForm : Form
    {
        public StudentEntity student = null;
        bool isEdit = false;
        bool isValidStudentCode = false;

        public ManageStudentForm()
        {
            InitializeComponent();
            this.LoadDataForStudentTable();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.studentTableData.RowTemplate.Height = 80;
            this.initCreateMode();
        }

        private void initEditMode()
        {
            this.isEdit = true;
            this.initValidationLabels();
            this.submitButton.Text = "Update";
            this.deleteButton.Show();

            this.stdCodeTextBox.Text = student.code;
            this.firstNameTextBox.Text = student.first_name;
            this.lastNameTextBox.Text = student.last_name;
            this.birthdateDatePicker.Value = DateTime.Parse(student.birthdate);
            this.maleRadio.Checked = student.gender == StudentEntity.GenderType.Male.ToString();
            this.famaleRadio.Checked = student.gender == StudentEntity.GenderType.Famale.ToString();
            this.phoneTextBox.Text = student.phone;
            this.addressTextbox.Text = student.address;
            if (student.avatar.Length > 0)
            {
                this.downloadButton.Show();
                this.avatarPicture.Image = Helper.ConvertBase64ToImage(student.avatar);
            }
        }

        private void initCreateMode()
        {
            this.isEdit = false;
            this.initValidationLabels();
            this.submitButton.Text = "Create";
            this.deleteButton.Hide();
            this.downloadButton.Hide();

            this.stdCodeTextBox.Text = "";
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.birthdateDatePicker.Value = DateTime.Parse("02/02/2002");
            this.maleRadio.Checked = true;
            this.famaleRadio.Checked = false;
            this.phoneTextBox.Text = "";
            this.addressTextbox.Text = "";
            this.avatarPicture.Image = this.avatarPicture.InitialImage;
        }

        private void initValidationLabels()
        {
            this.stdCodeErrorLabel.Hide();
            this.firstNameErrorLabel.Hide();
            this.lastNameErrorLabel.Hide();
            this.phoneErrorLabel.Hide();
            this.addressErrorLabel.Hide();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            birthdateDatePicker.Format = DateTimePickerFormat.Custom;
            birthdateDatePicker.CustomFormat = "MM/dd/yyyy";
            this.initValidationLabels();
        }

        private void closeDialog()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void studentTableData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.studentTableData.Columns[e.ColumnIndex].Name == "avatarImg")
            {
                string avatarImg = this?.studentTableData?.Rows[e.RowIndex]?.Cells["avatarURLCol"]?.Value?.ToString();
                if (avatarImg?.Length < 1) return;
                Image img = Helper.ConvertBase64ToImage(avatarImg);
                e.Value = img;
            }
        }
        private void stdCodeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.stdCodeTextBox, this.stdCodeErrorLabel);
            if (string.IsNullOrEmpty(this.stdCodeTextBox.Text))
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
            Database db = new Database();

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
                Database sqlHandler = new Database();
                sqlHandler.deleteStudentByIdSQL(student.code);
                MessageBox.Show("Delete student successfully!", "Success!");
                this.LoadDataForStudentTable();
            }).Start();
        }

        private void LoadDataForStudentTable(string searchText = "")
        {
            new Thread(() =>
            {
                this.studentTableLoadingProgress.Value = 20;
                Database sqlHandler = new Database();
                DataTable dt = new DataTable();
                sqlHandler.getAllStudentsAdapter(searchText).Fill(dt);
                this.Invoke(new MethodInvoker(delegate
                {
                    this.studentTableData.DataSource = dt;
                }));
                this.studentTableLoadingProgress.Value = 100;
            }).Start();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.LoadDataForStudentTable();
        }

        private void studentTableData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.studentTableData.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.studentTableData.Rows[currentIndex];
            StudentEntity student = new StudentEntity();
            student
            .setCode(row.Cells["code"].Value.ToString())
            .setFirstName(row.Cells["first_name"].Value.ToString())
            .setLastName(row.Cells["last_name"].Value.ToString())
            .setBirthdate(DateTime.Parse(row.Cells["birth_date"].Value.ToString()))
            .setPhone(row.Cells["phone"].Value.ToString())
            .setGender(row.Cells["gender"].Value.ToString() == "Male" ? StudentEntity.GenderType.Male : StudentEntity.GenderType.Famale)
            .setAddress(row.Cells["address"].Value.ToString())
            .setAvatar(row.Cells["avatarURLCol"].Value.ToString());

            this.student = student;
            this.initEditMode();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.initCreateMode();
        }

        private void submitButton_Click(object sender, EventArgs e)
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
                    Database sqlHandler = new Database();
                    Cursor.Current = Cursors.WaitCursor;

                    if (this.isEdit)
                    {
                        sqlHandler.updateStudentSQL(this.student.code, newStudent);
                    }
                    else
                    {
                        sqlHandler.createStudentSQL(newStudent);
                        this.initCreateMode();
                    }

                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Add student successfully!", "Success");
                    this.LoadDataForStudentTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            thr.Start();
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
                this.downloadButton.Show();
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = $"student_{this.student.code}.jpg";
            if (this.avatarPicture.Image == null) return;

            if (svf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(svf.FileName);
                this.avatarPicture.Image.Save(svf.FileName);
            }
        }
    }
}
