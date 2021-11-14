using System;


namespace BFCalculatorProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            bool endApp = false;
            //Title displayed as the C# Board Foot Calculator App
            Console.WriteLine("C# Board Foot Calculator\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                //Variables declared and set to empty
                string widthInput = "";
                string lengthInput = "";
                string thicknessInput = "";
                double result = 0;

                //Request the user to input the desired width in inches
                Console.WriteLine("How Wide would you like your piece of wood?  Enter a width in inches, then press 'Enter'.");
                widthInput = Console.ReadLine();

                double cleanWidth = 0;
                while (!double.TryParse(widthInput, out cleanWidth))
                {
                    Console.WriteLine("This is not a valid input.  Please enter an integer value: ");
                    widthInput = Console.ReadLine();
                }
                //Request the user to input the desired length in inches
                Console.WriteLine("How long would you like your piece of wood?  Enter a length in inches, then press 'Enter'.");
                lengthInput = Console.ReadLine();

                double cleanLength = 0;
                while (!double.TryParse(lengthInput, out cleanLength))
                {
                    Console.WriteLine("This is not a valid input.  Please enter an integer value: ");
                    lengthInput = Console.ReadLine();
                }
                //Request the user to input the desired width in inches
                Console.WriteLine("How thick would you like your piece of wood? Enter a thickness in inches, then press 'Enter'.");
                thicknessInput = Console.ReadLine();

                double cleanThickness = 0;
                while (!double.TryParse(thicknessInput, out cleanThickness))
                {
                    Console.WriteLine("This is not a valid input.  Please enter an integer value: ");
                    thicknessInput = Console.ReadLine();
                }
                // Ask the user to choose an operator.
                Console.WriteLine("Choose a wood type from the following list:");
                Console.WriteLine("\ta - Walnut- $10 per board foot");
                Console.WriteLine("\tb - Oak - $6.75 per board foot");
                Console.WriteLine("\tc - Ash - $6 per board foot");
                Console.WriteLine("\td - Maple - $8 per board foot");
                Console.Write("Your option? ");

                string WoodType = Console.ReadLine();

                try
                {
                        Calculator calculator = new Calculator();
                    result = calculator.DoOperation(cleanWidth, cleanLength, cleanThickness, WoodType);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("That species of wood in that size will cost: $ {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
    
}

