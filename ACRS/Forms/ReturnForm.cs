using System;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;
using ACRS.GuiClasses;

namespace ACRS.Forms
{
    public partial class ReturnForm : Form
    {
        ValidateData ValidateData = new ValidateData();
        IDataPresenter data = new ManipulateModels();
        RentalModel rentalModel;

        public ReturnForm(RentalModel rental)
        {
            InitializeComponent();
            rentalModel = rental;
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

        private void newMileageValue_TextChanged(object sender, EventArgs e)
        {
            DetermineReturnButtonState();
        }
        
        private void DetermineReturnButtonState()
        {
            returnButton.Enabled = false;
            bool emptyData = string.IsNullOrEmpty(newMileageValue.Text);
            if (!emptyData)
            {
                returnButton.Enabled = true;
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            string errorMessage = "";

            if (rentalModel.PickupDate.Equals(DateTime.Today))
            {
                output = false;
                errorMessage += "لا يمكنك إعادة سيارة في نفس اليوم الذي استؤجرت فيه";
                errorMessage += "\n";
            }

            if (!ValidateData.IsInteger(newMileageValue.Text))
            {
                output = false;
                errorMessage += "المسافة التي أدخلتها ليست عدد صحيح";
                errorMessage += "\n";
                
            }

            else if (rentalModel.RentedCar.Mileage >= int.Parse(newMileageValue.Text))
            {
                output = false;
                errorMessage += $"يجب أن تكون المسافة الجديدة أكبر من المسافة القديمة ({rentalModel.RentedCar.Mileage})";
                errorMessage += "\n";
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

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                data.ReturnRental(rentalModel, DateTime.Today, int.Parse(newMileageValue.Text));

                Close();
            }
        }
    }
}
