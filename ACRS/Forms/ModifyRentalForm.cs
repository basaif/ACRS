using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;
using ACRS.GuiClasses;

namespace ACRS.Forms
{
    public partial class ModifyRentalForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        private RentalModel rentalModel;

        ValidateData ValidateData = new ValidateData();
        IDataPresenter data = new ManipulateModels();

        List<CustomerModel> rentersList;
        List<CarModel> carsList;

        public ModifyRentalForm(RentalModel rental)
        {
            InitializeComponent();
            rentalModel = rental;

            rentersList = data.GetNotRentingCustomerModels();
            carsList = data.GetAvailableCarModels();

            FillInForm(rentalModel);
            saveButton.Enabled = true;
        }

        private void FillInForm(RentalModel model)
        {
            pickupDateTimePicker.Value = model.PickupDate;
            dropOffDateTimePicker.Value = model.DropoffDate;

            rentersList.Add(model.Renter);
            WireUpRentersLists();
            renterComboBox.SelectedItem = model.Renter;
            WireUpRentersLists();

            carsList.Add(model.RentedCar);
            WireUpCarsLists();
            carComboBox.SelectedItem = model.RentedCar;
            WireUpCarsLists();

            lateFeeValue.Text = model.LateFeePerDay.ToString();
            earlyDiscountValue.Text = model.EarlyDiscountPerDay.ToString();
        }

        private void WireUpCarsLists()
        {
            carComboBox.DataSource = null;

            carComboBox.DataSource = carsList;
            carComboBox.DisplayMember = "DisplayName";

        }

        private void WireUpRentersLists()
        {
            renterComboBox.DataSource = null;

            renterComboBox.DataSource = rentersList;
            renterComboBox.DisplayMember = "FullName";

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.white_close_image_44x30;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_image_44x30;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private bool ValidateForm()
        {
            bool output = true;
            string errorMessage = "";

            CarModel selectedCar = (CarModel)carComboBox.SelectedItem;

            if (!ValidateData.IsStartDateValid(pickupDateTimePicker.Value))
            {
                output = false;
                errorMessage += "تاريخ بداية التأجير يجب أن يكون اليوم أو تاريخ في المستقبل في غضون 30 يوم";
                errorMessage += "\n";
            }

            if (!ValidateData.IsPeriodValid(pickupDateTimePicker.Value, dropOffDateTimePicker.Value))
            {
                output = false;
                errorMessage += "يجب أن تكون مدة التأجير يوم واحد على الأقل أو 365 يوم على الأكثر";
                errorMessage += "\n";
            }

            if (!ValidateData.IsDecimal(lateFeeValue.Text))
            {
                output = false;
                errorMessage += "يجب أن تكون الغرامة عدد حقيقي";
                errorMessage += "\n";
            }

            else if (!ValidateData.IsLateFeeValid(lateFeeValue.Text, selectedCar.PricePerDay))
            {
                output = false;
                errorMessage += $"يجب أن تكون الغرامة بين 0 و {2M*selectedCar.PricePerDay}";
                errorMessage += "\n";
            }

            if (!ValidateData.IsDecimal(earlyDiscountValue.Text))
            {
                output = false;
                errorMessage += "يجب أن يكون الخصم عدد حقيقي";
                errorMessage += "\n";
            }
            else if (!ValidateData.IsEarlyDiscountValid(earlyDiscountValue.Text, selectedCar.PricePerDay))
            {
                output = false;
                errorMessage += $"يجب أن يكون الخصم بين 0 و {selectedCar.PricePerDay}";
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

        private void DetermineSaveButtonState()
        {
            saveButton.Enabled = false;
            bool emptyData = string.IsNullOrEmpty(pickupDateTimePicker.Text) || string.IsNullOrEmpty(dropOffDateTimePicker.Text)
                || string.IsNullOrEmpty(lateFeeValue.Text) || string.IsNullOrEmpty(earlyDiscountValue.Text) || renterComboBox.SelectedItem == null || carComboBox.SelectedItem == null;
            if (!emptyData)
            {
                saveButton.Enabled = true;
            }
        }

        private void lateFeeValue_TextChanged(object sender, EventArgs e)
        {
            DetermineSaveButtonState();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                data.UpdateRentalModel(rentalModel, pickupDateTimePicker.Value, dropOffDateTimePicker.Value,
                    (CustomerModel)renterComboBox.SelectedItem, (CarModel)carComboBox.SelectedItem,
                    lateFeeValue.Text, earlyDiscountValue.Text);

                Close();
            }
        }
    }
}
