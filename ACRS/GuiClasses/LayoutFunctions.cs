using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;

namespace ACRS.GuiClasses
{
    class LayoutFunctions
    {
        private static RentalLogic logic = new RentalLogic();

        public void PopulateCarDetails (Label displayNameLabel, Label registerationNoLabel, Label categoryLabel,
           Label pricePerDayLabel, Label mileageLabel, Label peopleNoLabel, Label luggageNoLabel, TextBox featuresTextBox, CarModel car)
        {
            ChangeLabelTextPosistion(displayNameLabel, car.CarName);
            ChangeLabelTextPosistion(registerationNoLabel, car.RegisterationNumber);
            ChangeLabelTextPosistion(categoryLabel, car.Category.CarCategoryName);
            ChangeLabelTextPosistion(pricePerDayLabel, "$ "+ car.PricePerDay.ToString());
            ChangeLabelTextPosistion(mileageLabel, car.Mileage.ToString());
            ChangeLabelTextPosistion(peopleNoLabel, car.Category.PeopleNumber.ToString());
            ChangeLabelTextPosistion(luggageNoLabel, car.Category.LuggageNumber.ToString());

            string features = "";
            foreach (CarFeatureModel feature in car.Features)
            {
                features += feature.CarFeatureName;
                features += "  -  ";
                
            }

            featuresTextBox.Text = features.Substring(0, features.Length - 3);
        }
        public void PopulateCarDetails(Label displayNameLabel, Label registerationNoLabel, Label categoryLabel,
           Label pricePerDayLabel, Label mileageLabel, Label peopleNoLabel, Label luggageNoLabel, Label statusLabel, TextBox featuresTextBox, CarModel car)
        {
            string status = "";
            if (car.Status.Equals("Not Available"))
            {
                status = "نعم";
            }
            else if (car.Status.Equals("Available"))
            {
                status = "لا";
            }

            ChangeLabelTextPosistion(displayNameLabel, car.CarName);
            ChangeLabelTextPosistion(registerationNoLabel, car.RegisterationNumber);
            ChangeLabelTextPosistion(categoryLabel, car.Category.CarCategoryName);
            ChangeLabelTextPosistion(pricePerDayLabel, "$ " + car.PricePerDay.ToString());
            ChangeLabelTextPosistion(mileageLabel, car.Mileage.ToString());
            ChangeLabelTextPosistion(peopleNoLabel, car.Category.PeopleNumber.ToString());
            ChangeLabelTextPosistion(luggageNoLabel, car.Category.LuggageNumber.ToString());
            ChangeLabelTextPosistion(statusLabel, status);

            string features = "";
            foreach (CarFeatureModel feature in car.Features)
            {
                features += feature.CarFeatureName;
                features += "  -  ";

            }

            featuresTextBox.Text = features.Substring(0, features.Length - 3);
        }

        public void PopulateRentalDetails(Label pickupLabel, Label dropoffLabel, Label periodLabel, Label priceLabel,
            Label lateFeeLabel, Label earlyDiscountLabel, Label statusLabel,
            DateTime startDate, DateTime endDate, string lateFee, string earlyDiscount, CarModel car)
        {
            string state = "New";
            double startDateTodayDifference = Math.Floor(startDate.Subtract(DateTime.Today).TotalDays);
            if (startDateTodayDifference <= 0)
            {
                state = "Active";
            }
            double totalDays = Math.Ceiling(endDate.Subtract(startDate).TotalDays);
            string status = logic.RentalStatus(state, startDate, endDate, DateTime.Today);
            string period = logic.RentalPeriod(startDate, endDate);
            ChangeLabelTextPosistion(pickupLabel, startDate.ToShortDateString());
            ChangeLabelTextPosistion(dropoffLabel, endDate.ToShortDateString());
            ChangeLabelTextPosistion(periodLabel, period);
            ChangeLabelTextPosistion(priceLabel, logic.EstimatePrice(totalDays, car.PricePerDay).ToString() + " $ ");
            ChangeLabelTextPosistion(lateFeeLabel, lateFee + " $ ");
            ChangeLabelTextPosistion(earlyDiscountLabel, earlyDiscount + " $ ");
            ChangeLabelTextPosistion(statusLabel, status);

        }

        public void PopulateRentalDetails(Label pickupLabel, Label dropoffLabel, Label periodLabel, Label priceLabel,
            Label lateFeeLabel, Label earlyDiscountLabel, Label statusLabel,
            RentalModel rental)
        {
            string status = logic.RentalStatus(rental.Status, rental.PickupDate, rental.DropoffDate, rental.ActualDropoffDate);
            string period = logic.RentalPeriod(rental.PickupDate, rental.DropoffDate);

            ChangeLabelTextPosistion(pickupLabel, rental.PickupDate.ToShortDateString());
            ChangeLabelTextPosistion(dropoffLabel, rental.DropoffDate.ToShortDateString());
            ChangeLabelTextPosistion(periodLabel, period);
            ChangeLabelTextPosistion(priceLabel, rental.EstimatedPrice + " $ ");
            ChangeLabelTextPosistion(lateFeeLabel, rental.LateFeePerDay + " $ ");
            ChangeLabelTextPosistion(earlyDiscountLabel, rental.EarlyDiscountPerDay + " $ ");
            ChangeLabelTextPosistion(statusLabel, status);
        }

        public void PopulateCustomerDetails(Label nameLabel, Label licenseLabel, Label phoneLabel, Label emailLabel, CustomerModel customer)
        {
            ChangeLabelTextPosistion(nameLabel, customer.FullName);
            ChangeLabelTextPosistion(licenseLabel, customer.LicenseNumber);
            ChangeLabelTextPosistion(phoneLabel, customer.PhoneNumber);
            ChangeLabelTextPosistion(emailLabel, customer.EmailAddress);
        }

        public void PopulateCustomerDetails(Label nameLabel, Label licenseLabel, Label phoneLabel, Label emailLabel, Label statusLabel, CustomerModel customer)
        {
            string status = "";
            if (customer.Status.Equals("Renting"))
            {
                status = "نعم";
            }
            else if (customer.Status.Equals("Not Renting"))
            {
                status = "لا";
            }

            ChangeLabelTextPosistion(nameLabel, customer.FullName);
            ChangeLabelTextPosistion(licenseLabel, customer.LicenseNumber);
            ChangeLabelTextPosistion(phoneLabel, customer.PhoneNumber);
            ChangeLabelTextPosistion(emailLabel, customer.EmailAddress);
            ChangeLabelTextPosistion(statusLabel, status);
        }

        private void ChangeLabelTextPosistion(Label label, string newValue)
        {
            int currentWidth = label.Size.Width;
            int currentLocationX = label.Location.X;
            int currentLocationY = label.Location.Y;
            label.Text = newValue;
            int newWidth = label.Size.Width;
            label.Location = new Point(currentLocationX - (newWidth - currentWidth), currentLocationY);
        }
    }
}
