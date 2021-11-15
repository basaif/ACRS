using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Models;
using ACRS.GuiClasses;

namespace ACRS.Forms
{
    public partial class RentalDetailsForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        private LayoutFunctions layout = new LayoutFunctions();

        RentalModel rental;

        public RentalDetailsForm(RentalModel rentalModel)
        {
            rental = rentalModel;
            InitializeComponent();
            
        }

        private void PopulateRentalDetails(RentalModel model)
        {
            layout.PopulateCustomerDetails(nameValueLabel, licenseNumberValueLabel, phoneNumberValueLabel, emailValueLabel, model.Renter);

            layout.PopulateCarDetails(carLabel, registerationNumberValue, categoryValue, pricePerDayValue, mileageValue,
                    peopleNumberValue, luggageNumberValue, featuresTextBox, model.RentedCar);

            layout.PopulateRentalDetails(pickupDateValueLabel, dropOffDateValueLabel, rentalPeriodValueLabel, estimatedPriceValueLabel, lateFeeLabelValue, earlyDiscountValueLabel,rentalStatusValueLabel,
                    rental);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.white_close_image_44x30;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_image_44x30;
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

        private void RentalDetailsForm_Load(object sender, EventArgs e)
        {
            PopulateRentalDetails(rental);
        }

        
    }
}
