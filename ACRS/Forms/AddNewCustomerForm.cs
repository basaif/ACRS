using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;
using ACRS.GuiClasses;

namespace ACRS.Forms
{
    public partial class AddNewCustomerForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        ValidateData ValidateData = new ValidateData();

        ICustomerRequester callingForm;

        public AddNewCustomerForm(ICustomerRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

      

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.white_close_image_44x30;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_image_44x30;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (string.IsNullOrEmpty(emailAddressValue.Text))
                {
                    emailAddressValue.Text = "-";
                }
                IDataPresenter data = new ManipulateModels();
                
                CustomerModel c = data.CreateCustomerModel(firstNameValue.Text,
                    lastNameValue.Text,
                    licenseNumberValue.Text,
                    phoneNumberValue.Text,
                    emailAddressValue.Text);

                callingForm.CustomerComplete(c);

                Close();
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            string errorMessage = "";

            if (!ValidateData.IsNameValid(firstNameValue.Text))
            {
                output = false;
                errorMessage += "الاسم الأول الذي أدخلته يحتوي على رموز غير مقبولة";
                errorMessage += "\n";
            }

            if (!ValidateData.IsNameValid(lastNameValue.Text))
            {
                output = false;
                errorMessage += "الاسم الأخير الذي أدخلته يحتوي على رموز غير مقبولة";
                errorMessage += "\n";
            }

            if (!ValidateData.IsAlphanumeric(licenseNumberValue.Text))
            {
                output = false;
                errorMessage += "رقم الرخصة الذي أدخلته غير صحيح";
                errorMessage += "\n";
            }

            if (!ValidateData.IsPhoneNumberValid(phoneNumberValue.Text))
            {
                output = false;
                errorMessage += "رقم الهاتف الذي أدخلته غير صحيح";
                errorMessage += "\n";
            }

            if (!string.IsNullOrEmpty(emailAddressValue.Text))
            {
                if (!ValidateData.IsEmailAddressValid(emailAddressValue.Text))
                {
                    output = false;
                    errorMessage += "البريد الإلكتروني الذي أدخلته غير صحيح";
                    errorMessage += "\n";
                }
            }
           

            if (!output)
            {
                string messageTitle = "بيانات خاطئة";
                errorMessage += "أعد الإدخال من جديد";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Stop;

                MessageBox.Show(errorMessage, messageTitle, button, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            return output;
        }

        private void firstNameValue_TextChanged(object sender, EventArgs e)
        {
            DetermineSaveButtonState();
        }
        private void DetermineSaveButtonState()
        {
            saveButton.Enabled = false;
            bool emptyData = string.IsNullOrEmpty(firstNameValue.Text) || string.IsNullOrEmpty(lastNameValue.Text) || string.IsNullOrEmpty(licenseNumberValue.Text) || string.IsNullOrEmpty(phoneNumberValue.Text);
            if (!emptyData)
            {
                saveButton.Enabled = true;
            }
        }
    }
}
