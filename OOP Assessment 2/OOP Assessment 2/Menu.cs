using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_2
{
    public static class Menu
    {

        public static File Choose(List<File> list)
        {
            int index = 1;
            Console.WriteLine("\nPlease choose a value \n");
            foreach (File f in list)
            {
                Console.WriteLine(index + ": " + f.name);
                index++;
            }

            int userChoice = -1;
            File output = null;
            while (userChoice < 0)
            {
                try
                {

                    userChoice = Int32.Parse(Console.ReadLine());
                    output = list[userChoice - 1];
                }
                catch (ArgumentOutOfRangeException a)
                {
                    Console.WriteLine("Please enter a valid choice");
                    userChoice = -1;
                }
                catch (FormatException f)
                {
                    Console.WriteLine("Please enter a valid choice");
                    userChoice = -1;
                }
            }

            return output;
        }
    }
}
