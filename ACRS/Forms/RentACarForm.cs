using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;
using ACRS.GuiClasses;

namespace ACRS.Forms
{
    public partial class RentACarForm : Form , ICustomerRequester, ICarRequester
    {
        private bool mouseDown;
        private Point lastLocation;

        private int activePanel = 1;

        private LayoutFunctions layout = new LayoutFunctions();

        ValidateData ValidateData = new ValidateData();
        IDataPresenter data = new ManipulateModels();

        List<CustomerModel> rentersList;
        List<CarModel> carsList;

        IRentalRequester callingForm;

        public RentACarForm(IRentalRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            rentersList = data.GetNotRentingCustomerModels();
            carsList = data.GetAvailableCarModels();

            WireUpRentersLists();
            WireUpCarsLists();

            dropOffDateTimePicker.Value = pickupDateTimePicker.Value.AddDays(1.0);

            lateFeeValue.Text = "0";
            earlyDiscountValue.Text = "0";
        }

        private void WireUpCarsLists()
        {
            carslistBox.DataSource = null;

            carslistBox.DataSource = carsList;
            carslistBox.DisplayMember = "DisplayName";


        }

        private void WireUpRentersLists()
        {
            renterComboBox.DataSource = null;

            renterComboBox.DataSource = rentersList;
            renterComboBox.DisplayMember = "FullName";


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

        private void newRenterButton_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm(this);
            addNewCustomerForm.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (ValidateRentalDetails())
            {
                activePanel += 1;
                determinePanelVisibility(activePanel);
                nextButton.Enabled = false;
                if(carslistBox.SelectedItem != null)
                {
                    nextButton.Enabled = true;
                    ShowReviewDetails();
                }
            }
        }
        private void determinePanelVisibility(int panelNumber)
        {
            if (panelNumber == 1)
            {
                rentalDetailsHeaderPanel.Visible = true;
                rentalDetailsPanel.Visible = true;

                nextButton.Visible = true;
                previousButton.Visible = false;
                saveButton.Visible = false;

                carHeaderPanel.Visible = false;
                carPanel.Visible = false;

                reviewHeaderPanel.Visible = false;
                reviewPanel.Visible = false;

            }
            if (panelNumber == 2)
            {
                rentalDetailsHeaderPanel.Visible = false;
                rentalDetailsPanel.Visible = false;

                nextButton.Visible = true;
                previousButton.Visible = true;
                saveButton.Visible = false;

                carHeaderPanel.Visible = true;
                carPanel.Visible = true;

                reviewHeaderPanel.Visible = false;
                reviewPanel.Visible = false;
            }
            if (panelNumber == 3)
            {
                rentalDetailsHeaderPanel.Visible = false;
                rentalDetailsPanel.Visible = false;

                nextButton.Visible = false;
                previousButton.Visible = true;
                saveButton.Visible = true;

                carHeaderPanel.Visible = false;
                carPanel.Visible = false;

                reviewHeaderPanel.Visible = true;
                reviewPanel.Visible = true;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            activePanel -= 1;
            determinePanelVisibility(activePanel);
            nextButton.Enabled = true;
        }

        private void newCarButton_Click(object sender, EventArgs e)
        {
            AddNewCarForm addNewCarForm = new AddNewCarForm(this);
            addNewCarForm.Show();
        }

        private bool ValidateRentalDetails()
        {
            bool output = true;
            string errorMessage = "";

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


            if (!ValidateData.IsDecimal(earlyDiscountValue.Text))
            {
                output = false;
                errorMessage += "يجب أن يكون الخصم عدد حقيقي";
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

        private bool ValidateRental()
        {
            bool output = true;
            string errorMessage = "";

            CarModel selectedCar = (CarModel)carslistBox.SelectedItem;

            if (!ValidateData.IsDecimal(lateFeeValue.Text))
            {
                output = false;
                errorMessage += "يجب أن تكون الغرامة عدد حقيقي";
                errorMessage += "\n";
            }
            else if (!ValidateData.IsLateFeeValid(lateFeeValue.Text, selectedCar.PricePerDay))
            {
                output = false;
                errorMessage += $"يجب أن تكون الغرامة بين 0 و {2M * selectedCar.PricePerDay}";
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

        private void DetermineNextButtonState()
        {
            nextButton.Enabled = false;
            bool emptyData = string.IsNullOrEmpty(pickupDateTimePicker.Text) || string.IsNullOrEmpty(dropOffDateTimePicker.Text)
                || string.IsNullOrEmpty(lateFeeValue.Text) || string.IsNullOrEmpty(earlyDiscountValue.Text) || renterComboBox.SelectedItem == null;
            if (!emptyData)
            {
                nextButton.Enabled = true;
            }
        }

        private void pickupDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DetermineNextButtonState();
        }

        public void CustomerComplete(CustomerModel model)
        {
            rentersList.Add(model);
            WireUpRentersLists();

            renterComboBox.SelectedItem = model;
        }

        private void carslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarModel selectedCar = (CarModel)carslistBox.SelectedItem;
            if (selectedCar != null)
            {
                layout.PopulateCarDetails(firstCarLabel, firstCarRegisterationValue, firstCarCategoryValue, firstPricePerDayValue, firstMileageValue,
                    firstPeopleNumberValue, firstLuggageNumberValue, featuresTextBox, selectedCar);
                nextButton.Enabled = true;
            }
            
            
        }

        private void ShowReviewDetails()
        {
            CustomerModel selectedRenter = (CustomerModel)renterComboBox.SelectedItem;
            CarModel selectedCar = (CarModel)carslistBox.SelectedItem;

            if (selectedRenter != null)
            {
                layout.PopulateCustomerDetails(nameValueLabel, licenseNumberValueLabel, phoneNumberValueLabel, emailValueLabel, selectedRenter);
            }
            
            if (selectedCar != null)
            {
                layout.PopulateCarDetails(reviewCarLabel, reviewRegisterationNumberValue, reviewCategoryValue, reviewPricePerDayValue, reviewMileageValue,
                    reviewPeopleNumberValue, reviewLuggageNumberValue, reviewFeaturesTextBox, selectedCar);
                nextButton.Enabled = true;

                layout.PopulateRentalDetails(pickupDateValueLabel, dropOffDateValueLabel, rentalPeriodValueLabel, estimatedPriceValueLabel, lateFeeLabelValue, earlyDiscountValueLabel, rentalStatusValueLabel,
                    pickupDateTimePicker.Value, dropOffDateTimePicker.Value, lateFeeValue.Text, earlyDiscountValue.Text, selectedCar);
            }

        }

        public void CarComplete(CarModel model)
        {
            carsList.Add(model);
            WireUpCarsLists();

            carslistBox.SelectedItem = model;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateRental())
            {
                RentalModel r = data.CreateRentalModel(pickupDateTimePicker.Value, dropOffDateTimePicker.Value, lateFeeValue.Text, earlyDiscountValue.Text,
                        (CustomerModel)renterComboBox.SelectedItem, (CarModel)carslistBox.SelectedItem);

                callingForm.RentalComplete(r);

                Close(); 
            }
        }
    }
}
