using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    public partial class HRForm : Form
    {
        bool isValidCreate = false;
        public HRForm()
        {
            InitializeComponent();
            this.stdCodeErrorLabel.Hide();
            this.resetValidation_CreateGroup();
            this.resetValidation_EditGroup();
        }

        private void HRForm_Load(object sender, EventArgs e)
        {
            
        }

        private void resetValidation_CreateGroup ()
        {
            this.createGroupNameErrorLabel.Hide();
        }

        private void resetValidation_EditGroup()
        {
            this.createGroupNameErrorLabel.Hide();
        }


        private void addContactButton_Click(object sender, EventArgs e)
        {
            using (ContactAction createContact = new ContactAction(false))
            {
                createContact.ShowDialog();
            }
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            using (ContactAction editContact = new ContactAction(true))
            {
                editContact.ShowDialog();
            }
        }

    
        private void createGroupNameTexBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.createGroupNameTexBox, this.createGroupNameErrorLabel);
            if (string.IsNullOrEmpty(this.createGroupNameTexBox.Text))
            {
                vali.error("This field is required!");
                this.isValidCreate = false;
                return;
            }

            this.isValidCreate = true;
            vali.normal();
        }
    private void addGroupButton_Click(object sender, EventArgs e)
        {
            this.createGroupNameTexBox_Validating(null, null);
            if (!this.isValidCreate) return;

            GroupEntity newGroup = new GroupEntity();
            //newGroup.setName(this.createGroupNameTexBox.Text).createdBy(this.);
        }

    }
}
