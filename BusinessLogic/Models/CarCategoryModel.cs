using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class CarCategoryModel
    {
        /// <summary>
        /// The unique identifier for the car category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The car category name.
        /// </summary>
        public string CarCategoryName { get; set; }

        /// <summary>
        /// The number of people per car category.
        /// </summary>
        public int PeopleNumber { get; set; }

        /// <summary>
        /// The number of bags per car category.
        /// </summary>
        public int LuggageNumber { get; set; }

    }
}
