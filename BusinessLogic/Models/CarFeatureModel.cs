using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class CarFeatureModel
    {
        /// <summary>
        /// The unique identifer for the car feature.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The car feature name.
        /// </summary>
        public string CarFeatureName { get; set; }

    }
}
