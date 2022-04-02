using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static std_management.DashboardForm;

namespace std_management
{
    public partial class AddStudentForm : Form
    {
        public event OnClose OnClose;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            birthdateDatePicker.Format = DateTimePickerFormat.Custom;
            birthdateDatePicker.CustomFormat = "MM/dd/yyyy";
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

        private void createButton_Click(object sender, EventArgs e)
        {
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

            Thread thr = new Thread(() =>
            {
                Cursor.Current = Cursors.WaitCursor;
                sqlHandler.createStudentSQL(student);
                Cursor.Current = Cursors.Default;
                this.closeDialog();
            });

            thr.Start();
        }
    }
}
