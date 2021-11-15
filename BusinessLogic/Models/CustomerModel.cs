using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class CustomerModel
    {
        /// <summary>
        /// The unique identifier of the customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The customer's driver's license number.
        /// </summary>
        public string LicenseNumber { get; set; }

        /// <summary>
        /// The customer's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The customer's status NotRenting, Renting, Obsolete.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The customer's first name followed by their last name.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
