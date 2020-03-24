using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Object_Oriented_Assessment_Two_Code
{
    class Program
    {
        public static string Menu(Dictionary<int, string> dictionary)
        {
            Console.WriteLine();

            int counter = 1;
            foreach (var dictionary_values in dictionary)
            {
                Console.WriteLine(string.Format(counter + " - " + dictionary_values.Value));
                counter++;
            }

            int menu_choice = -1;
            while (menu_choice < 0)
            {
                try
                {
                    Console.Write("\r\nChoose an option: ");
                    menu_choice = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input format was wrong");
                }
                if (menu_choice < 1 || menu_choice > 6)
                {
                    Console.WriteLine("Index was out of range");
                    menu_choice = -1;
                }
                else break;
            }

            string filename = dictionary[menu_choice];

            return filename;
        }
        

        public static void Main(string[] args)
        {

            var dictionary_of_text_files = new Dictionary<int, string>
            {
                {1, "GitRepositories_1a" },
                {2, "GitRepositories_1b" },
                {3, "GitRepositories_2a" },
                {4, "GitRepositories_2b" },
                {5, "GitRepositories_3a" },
                {6, "GitRepositories_3b" }
            };

            string file_one = Menu(dictionary_of_text_files);
            string file_two = Menu(dictionary_of_text_files);
            
            string[] file_one_data = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + file_one + ".txt");
            string[] file_two_data = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + file_two + ".txt");

            for (int index = 0; index < file_one_data.Length; index++)
            {
                if (file_one_data[index] != file_two_data[index])
                {
                    Console.WriteLine(file_one + " and " + file_two + " are different");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine(file_one + " and " + file_two + " are the same");
        }
    }
}
