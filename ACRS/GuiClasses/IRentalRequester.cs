using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace ACRS.GuiClasses
{
    public interface IRentalRequester
    {
        void RentalComplete(RentalModel model);
    }
}
