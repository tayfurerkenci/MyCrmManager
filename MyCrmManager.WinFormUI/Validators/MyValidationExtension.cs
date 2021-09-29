using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.WinFormUI.Validators
{
    public static class MyValidationExtension
    {
        public static bool BeAValidNumber(string number)
        {
            return number.All(char.IsDigit);
        }

        public static bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsLetter);
        }
        public static bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int birthdateYear = date.Year;
            if (birthdateYear <= currentYear && birthdateYear > (currentYear - 120))
            {
                return true;
            }
            return false;
        }
    }
}
