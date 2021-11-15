using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class RentalModel
    {
        /// <summary>
        /// The unique identifier of the rental.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The pickup date of the rental.
        /// </summary>
        public DateTime PickupDate { get; set; }

        /// <summary>
        /// The drop off date of the rental.
        /// </summary>
        public DateTime DropoffDate { get; set; }

        /// <summary>
        /// The actual drop off date of the rental.
        /// </summary>
        public DateTime ActualDropoffDate { get; set; }

        /// <summary>
        /// The estimated price of the rental.
        /// </summary>
        public decimal EstimatedPrice { get; set; }

        /// <summary>
        /// The status of the rental: New, Active, Late, Returned.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The customer who rented the car.
        /// </summary>
        public CustomerModel Renter { get; set; }

        /// <summary>
        /// The car the customer rented.
        /// </summary>
        public CarModel RentedCar { get; set; }

        /// <summary>
        /// The amount of money added to the price for each late day.
        /// </summary>
        public decimal LateFeePerDay { get; set; }

        /// <summary>
        /// The amount of money subtracted from the price for each early day.
        /// </summary>
        public decimal EarlyDiscountPerDay { get; set; }

        /// <summary>
        /// The pickup date, drop off date, and the car name respectively.
        /// </summary>
        public string DisplayName
        {
            get
            {
                return $"من {PickupDate.ToShortDateString()} إلى {DropoffDate.ToShortDateString()} ({RentedCar.CarName}) ";
            }
        }

    }
}
