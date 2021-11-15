using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.RentalClasses
{
    public class RentalLogic
    {
        
        public decimal EstimateRentalPrice(RentalModel rental)
        {
            DateTime startDate = rental.PickupDate;
            DateTime endDate = rental.DropoffDate;
            DateTime actualEndDate = rental.ActualDropoffDate;
            DateTime todayDate = DateTime.Today;

            decimal pricePerDay = rental.RentedCar.PricePerDay;
            decimal lateFee = rental.LateFeePerDay;
            decimal earlyDiscount = rental.EarlyDiscountPerDay;

            double totalDays = Math.Ceiling(endDate.Subtract(startDate).TotalDays);
            decimal price = ((decimal)totalDays * pricePerDay) - ((Math.Floor((decimal)totalDays / 30M)) * ((30M * pricePerDay) / 3M));

            if (rental.Status.Equals("Late"))
            {
                double lateDays = Math.Ceiling(todayDate.Subtract(endDate).TotalDays);
                price += (decimal)lateDays * lateFee;
            }
            else if (rental.Status.Equals("Returned"))
            {
                if (endDate > actualEndDate)
                {
                    double earlyDays = Math.Ceiling(endDate.Subtract(actualEndDate).TotalDays);
                    price -= (decimal)earlyDays * earlyDiscount;
                }
                else if (endDate < actualEndDate)
                {
                    double lateDays = Math.Ceiling(actualEndDate.Subtract(endDate).TotalDays);
                    price += (decimal)lateDays * lateFee;
                }
            }

            return price;
        }

        public char DetermineRentalStatus(RentalModel model)
        {
            char statusFlag = '0';
            bool isLate = Math.Floor(DateTime.Today.Subtract(model.DropoffDate).TotalDays) > 0;
            bool isNew = model.PickupDate > DateTime.Today;
            bool isReturned = (model.ActualDropoffDate <= DateTime.Today) && ((model.ActualDropoffDate > model.PickupDate));
            bool isActive = (model.PickupDate <= DateTime.Today) && (DateTime.Today <= model.DropoffDate) && !isReturned;

            if (isNew)
            {
                statusFlag = '0';
            }
            else if (isReturned)
            {
                statusFlag = '3';
            }
            else if (isLate)
            {
                statusFlag = '2';
            }
            else if (isActive)
            {
                statusFlag = '1';
            }
            else
            {
                statusFlag = '3';
            }

            return statusFlag;
        }

        public string RentalPeriod(DateTime startDate, DateTime endDate)
        {
            double totalDays = Math.Ceiling(endDate.Subtract(startDate).TotalDays);
            string period = totalDays.ToString() + " يوم ";



            return period;
        }

        public string RentalStatus(string status, DateTime startDate, DateTime endDate, DateTime returnDate)
        {

            if (status.Equals("New"))
            {
                return "(حديثة)  " + "تبدأ بعد  " + Math.Floor(startDate.Subtract(DateTime.Today).TotalDays).ToString() + " يوم ";
            }
            else if (status.Equals("Late"))
            {
                return "(متأخرة)  " + "تأخر  " + Math.Floor(DateTime.Today.Subtract(endDate).TotalDays).ToString() + " يوم ";
            }
            else if (status.Equals("Active"))
            {
                return "(نشطة)  " + "تنتهي بعد  " + Math.Floor(endDate.Subtract(DateTime.Today).TotalDays).ToString() + " يوم ";
            }
            else
            {
                return "(معادة)  " + "تاريخ الإعادة  " + returnDate.ToShortDateString();
            }
        }

        public decimal EstimatePrice(double totalDays, decimal pricePerDay)
        {
            decimal price = ((decimal)totalDays * pricePerDay) - ((Math.Floor((decimal)totalDays / 30M)) * ((30M * pricePerDay) / 3M));
            return price;
        }
    }
}
