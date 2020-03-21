using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_2
{
    public static class Test
    {
        /// <summary>
        /// Compares each character and returns true if all are identical
        /// </summary>
        /// <param name="f1"></param>
        /// First File to compare
        /// <param name="f2"></param>
        /// Second File to compare
        /// <returns></returns>
        public static bool GitDiff(File f1, File f2)
        {
          int index = 0;

            foreach (string c1 in f1.contents)
            {
               string c2 = f2.contents[index];

                if (c1==c2)
                {
                    index++;
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
