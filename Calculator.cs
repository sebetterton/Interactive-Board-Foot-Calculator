using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFCalculator
{
    class Calculator
    {
        public static double DoOperation(double width, double length, double thickness, string WoodType)
        {
            double result = double.NaN; //Default is 'not a number' if an operation could result in an error.

            //utilizing switch statements for caluclations.
            switch (WoodType)
            {
                case "a":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 10);
                            }
                    break;
                case "b":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 6);
                            }
                    break;
                case "c":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 5);
                            }
                    break;
                case "d":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 8);
                            }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;

        }

    }
}