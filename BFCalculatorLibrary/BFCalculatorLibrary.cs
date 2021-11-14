using System.IO;
using System.Diagnostics;
using System;

namespace BFCalculatorProgram
{
    public class Calculator

    {
        public Calculator()
        {
            StreamWriter logFile = File.CreateText("BFcalculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting BFCalculator Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        public double DoOperation(double width, double length, double thickness, string WoodType)
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
                                Trace.WriteLine(String.Format("({0}/12 * {1}/12 * {2} * 10)", width, length, thickness, result));
                            }
                    break;
                case "b":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 6.75);
                                Trace.WriteLine(String.Format("({0}/12 * {1}/12 * {2} * 6.75)", width, length, thickness, result));
                            }
                    break;
                case "c":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 6);
                                Trace.WriteLine(String.Format("({0}/12 * {1}/12 * {2} * 6)", width, length, thickness, result));
                            }
                    break;
                case "d":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 8);
                                Trace.WriteLine(String.Format("({0}/12 * {1}/12 * {2} * 8)", width, length, thickness, result));
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