using System;

namespace BFCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double width1; double length1; double thickness1;


            Console.WriteLine("Welcome to the board foot calculator in C#");
            Console.WriteLine("-----------------------------------------\n");

            Console.WriteLine("How wide would you like your piece of wood? Type your width in inches, then press Enter");
            width1 = Convert.ToDouble(Console.ReadLine());
            while (width1 == 0)
               
                    {
                        Console.WriteLine("Enter a non-zero number: ");
                        width1 = Convert.ToDouble(Console.ReadLine());
                 
                    }

            Console.WriteLine("How long would you like your piece of wood? Type your length in inches, then press Enter");
            length1 = Convert.ToDouble(Console.ReadLine()); ;

                while (length1 == 0)
                   
                    {
                        Console.WriteLine("Enter a non-zero number: ");
                       
                        length1 = Convert.ToDouble(Console.ReadLine());
                    }

            Console.WriteLine("How thick would you like your piece of wood in inches?");
            thickness1 = Convert.ToDouble(Console.ReadLine()); ;

                    while (thickness1 == 0)
                    {
                        Console.WriteLine("Enter a non-zero number: ");
                    
                        thickness1 = Convert.ToDouble(Console.ReadLine());
                    }

            Console.WriteLine("Now that we know what size you need, select a wood type to generate price:");
            Console.WriteLine("\ta - Walnut-$10 per board foot");
            Console.WriteLine("\tb - Oak-$6 per board foot");
            Console.WriteLine("\tc - Ash-$5 per board foot");
            Console.WriteLine("\td - Maple-$8 per board foot");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {

                case "a":
                    Console.WriteLine($"Your total cost is: {width1 / 12} * {length1 / 12} * {thickness1} * {10} = " + ((width1 / 12) * (length1 / 12) * (thickness1) * 10));
                  
                    break;
               
                case "b":
                    Console.WriteLine($"Your total cost is: {width1 / 12} * {length1 / 12} * {thickness1} * {6} = " + ((width1 / 12) * (length1 / 12) * (thickness1) * 6));
                   
                    break;
               
                case "c":
                    Console.WriteLine($"Your total cost is: {width1 / 12} * {length1 / 12} * {thickness1} * {5} = " + ((width1 / 12) * (length1 / 12) * (thickness1) * 5));
                   
                    break;
                
                case "d":
                    Console.WriteLine($"Your total cost is: {width1 / 12} * {length1 / 12} * {thickness1} * {8} = " + ((width1 / 12) * (length1 / 12) * (thickness1) * 8));
                    
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
    }

