using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class CarModel
    {
        /// <summary>
        /// The uniqure identifier for the car.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The registration number of the car.
        /// </summary>
        public string RegisterationNumber { get; set; }

        /// <summary>
        /// The name of the make of the car.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// The name of the model of the car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The year of the car.
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// The category of the car.
        /// </summary>
        public CarCategoryModel Category { get; set; }

        /// <summary>
        /// The mileage of the car.
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// The price per day of the car.
        /// </summary>
        public decimal PricePerDay { get; set; }

        /// <summary>
        /// A list of the features of the car.
        /// </summary>
        public List<CarFeatureModel> Features { get; set; }

        /// <summary>
        /// The status of the car: Available, NotAvailable, Obsolete
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The registration number followed by the year, make and model respectively.
        /// </summary>
        public string DisplayName
        {
            get
            {
                return $"({RegisterationNumber}) {Year} {Make} {Model}";
            }
        }

        /// <summary>
        /// The year, make and model of the car respectively.
        /// </summary>
        public string CarName
        {
            get
            {
                return $"{Year} {Make} {Model}";
            }
        }
    }
}
