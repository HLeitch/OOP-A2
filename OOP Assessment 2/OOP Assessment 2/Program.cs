using System;
using System.Collections.Generic;

namespace OOP_Assessment_2
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            List<File> listOfFiles = new List<File> { };
            string fileLocation = (System.IO.Directory.GetCurrentDirectory()+"/Assessment 2 Files/");
            
            string[] fileNames = System.IO.Directory.GetFiles(fileLocation);

            bool repeat = true;

                
                // string[] fileNames = new string[] { "GitRepositories_1a.txt", "GitRepositories_1b.txt", "GitRepositories_2a.txt", "GitRepositories_2b.txt", "GitRepositories_3a.txt", "GitRepositories_3b.txt", };
                foreach (string name in fileNames)
                {
                    string[] contents;
                    contents = System.IO.File.ReadAllLines(name);
                    string nameOfFile = name.Remove(0, fileLocation.Length);

                    File f = new File(nameOfFile, contents);
                    listOfFiles.Add(f);

                }

            // Menu presented to user
            while (repeat == true)
            {
                File File1 = Menu.Choose(listOfFiles);
                File File2 = Menu.Choose(listOfFiles);

                bool result = Test.GitDiff(File1, File2);
                Console.WriteLine(Output.Diff(result));

                Console.WriteLine( "\n1: Repeat"+
                    "\n2: End program");
                
                if (Console.ReadLine() == "1")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}
