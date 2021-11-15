using System;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace BFCalculatorLibrary
{
    public class Calculator

    {
        JsonWriter writer;
        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }
        public double DoOperation(double width, double length, double thickness, string WoodType)
        {
            double TotalCost = double.NaN; //Default is 'not a number' if an operation could result in an error.
            writer.WriteStartObject();
            writer.WritePropertyName("Width");
            writer.WriteValue(width);
            writer.WritePropertyName("Length");
            writer.WriteValue(length);
            writer.WritePropertyName("Thickness");
            writer.WriteValue(thickness);
            writer.WritePropertyName("Wood Species");

            //utilizing switch statements for calculations.
            switch (WoodType)
            {
                case "a":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                TotalCost = ((width / 12) * (length / 12) * (thickness) * 10);
                                writer.WriteValue("Walnut");
                            }
                    break;
                case "b":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                TotalCost = ((width / 12) * (length / 12) * (thickness) * 6.75);
                                writer.WriteValue("Oak");
                            }
                    break;
                case "c":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                TotalCost = ((width / 12) * (length / 12) * (thickness) * 6);
                                writer.WriteValue("Ash");
                            }
                    break;
                case "d":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                TotalCost = ((width / 12) * (length / 12) * (thickness) * 8);
                                writer.WriteValue("Maple");
                            }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
           
            writer.WritePropertyName("Total Cost");
            writer.WriteValue(TotalCost);
            writer.WriteEndObject();

            return TotalCost;
        }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}