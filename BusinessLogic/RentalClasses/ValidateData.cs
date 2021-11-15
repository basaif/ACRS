using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessLogic.RentalClasses
{
    public class ValidateData
    {
        public bool IsNameValid(string name)
        {
            bool output = false;
            string[] notAllowed = "1 2 3 4 5 6 7 8 9 0 ` ~ ! @ # $ % ^ & * ( ) _ + = [ ] { } \\ | / ? . , > < \" ; :".Split(' ');
            foreach (string character in notAllowed)
            {
                if (name.Contains(character))
                {
                    return output;
                }
            }
            output = true;
            return output;
        }

        public bool IsPhoneNumberValid(string number)
        {
            bool output = false;
            if (number.Length > 15)
            {
                return output;
            }

            if (!int.TryParse(number, out int result))
            {
                return output;
            }

            output = true;
            return output;

        }
        public bool IsAlphanumeric(string number)
        {
            bool output = false;
            string regex = @"^[a-zA-Z0-9]*$";
            if (Regex.IsMatch(number, regex))
            {
                output = true;
            }
            return output;
        }
        public bool IsEmailAddressValid(string email)
        {
            bool output = false;
            string regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            if (Regex.IsMatch(email, regex, RegexOptions.IgnoreCase))
            {
                output = true;
            }
            return output;
        }
        public bool IsInteger(string number)
        {
            bool output = int.TryParse(number, out int result);

            return output;

        }
        public bool IsYear(string number)
        {
            bool output = false;

            if (IsInteger(number) && number.Length == 4)
            {
                output = true;
            }

            return output;
        }
        public bool IsDecimal(string number)
        {
            bool output = decimal.TryParse(number, out decimal result);

            return output;
        }
        public bool IsStartDateValid(DateTime startDate)
        {
            bool output = false;

            if (startDate >= DateTime.Today)
            {
                double period = Math.Ceiling(startDate.Subtract(DateTime.Today).TotalDays);
                if (period <= 30)
                {
                    output = true;
                }

            }

            return output;
        }
        public bool IsPeriodValid(DateTime startDate, DateTime endDate)
        {
            bool output = false;

            if (startDate < endDate)
            {
                double period = Math.Ceiling(endDate.Subtract(startDate).TotalDays);
                if ((period >= 1) && (period <= 365))
                {
                    output = true;
                }
            }
            return output;
        }

        public bool IsLateFeeValid(string fee, decimal carPrice)
        {
            decimal value = decimal.Parse(fee);

            if (value >= 0 && value <= 2M * carPrice)
            {
                return true;
            }
            return false;

        }

        public bool IsEarlyDiscountValid(string discount, decimal carPrice)
        {
            decimal value = decimal.Parse(discount);

            if (value >= 0 && value <= carPrice)
            {
                return true;
            }
            return false;

        }

        public bool IsPriceValid(string price)
        {
            decimal value = decimal.Parse(price);

            if (value >= 100)
            {
                return true;
            }
            return false;
        }

    }
}
