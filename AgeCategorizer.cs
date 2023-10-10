using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AgeCategorizer
    {
        public string CategorizeAge(int age)
        {
            if (age >= 1 && age <= 14)
                return "Children";
            else if (age >= 15 && age <= 24)
                return "Youth";
            else if (age >= 25 && age <= 64)
                return "Adults";
            else if (age >= 65 && age <= 100)
                return "Seniors";
            else
                return"Invalid age input. Age must be a positive integer.";
        }

    }
}
