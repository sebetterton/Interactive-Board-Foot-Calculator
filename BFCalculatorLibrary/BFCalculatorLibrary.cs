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
            double result = double.NaN; //Default is 'not a number' if an operation could result in an error.
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(width);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(length);
            writer.WritePropertyName("Operand3");
            writer.WriteValue(thickness);
            writer.WritePropertyName("Operation");

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
                                writer.WriteValue("Walnut");
                            }
                    break;
                case "b":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 6.75);
                                writer.WriteValue("Oak");
                            }
                    break;
                case "c":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 6);
                                writer.WriteValue("Ash");
                            }
                    break;
                case "d":
                    // Ask the user to enter a non-zero number.
                    if (width != 0)
                        if (length != 0)
                            if (thickness != 0)
                            {
                                result = ((width / 12) * (length / 12) * (thickness) * 8);
                                writer.WriteValue("Maple");
                            }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
           
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();

            return result;
        }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}