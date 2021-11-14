using System;

namespace BFCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double width; double length; double thickness;


            Console.WriteLine("Welcome to the board foot calculator in C#");
            Console.WriteLine("-----------------------------------------\n");

            Console.WriteLine("How wide would you like your piece of wood? Type your width in inches, then press Enter");
            width = Convert.ToDouble(Console.ReadLine());
            while (width == 0)
               
                    {
                        Console.WriteLine("Enter a non-zero number: ");
                        width = Convert.ToDouble(Console.ReadLine());
                 
                    }

            Console.WriteLine("How long would you like your piece of wood? Type your length in inches, then press Enter");
            length = Convert.ToDouble(Console.ReadLine()); ;

                while (length == 0)
                   
                    {
                        Console.WriteLine("Enter a non-zero number: ");
                       
                        length = Convert.ToDouble(Console.ReadLine());
                    }

            Console.WriteLine("How thick would you like your piece of wood in inches?");
            thickness = Convert.ToDouble(Console.ReadLine()); ;

                    while (thickness == 0)
                    {
                        Console.WriteLine("Enter a non-zero number: ");
                    
                        thickness = Convert.ToDouble(Console.ReadLine());
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
                    Console.WriteLine($"Your total cost is: {width / 12} * {length / 12} * {thickness} * {10} = " + ((width / 12) * (length / 12) * (thickness) * 10));
                  
                    break;
               
                case "b":
                    Console.WriteLine($"Your total cost is: {width / 12} * {length / 12} * {thickness} * {6} = " + ((width / 12) * (length / 12) * (thickness) * 6));
                   
                    break;
               
                case "c":
                    Console.WriteLine($"Your total cost is: {width / 12} * {length / 12} * {thickness} * {5} = " + ((width / 12) * (length / 12) * (thickness) * 5));
                   
                    break;
                
                case "d":
                    Console.WriteLine($"Your total cost is: {width / 12} * {length / 12} * {thickness} * {8} = " + ((width / 12) * (length / 12) * (thickness) * 8));
                    
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
    }

