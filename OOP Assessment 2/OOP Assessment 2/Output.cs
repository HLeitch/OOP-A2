using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_2
{
    public static class Output
    {
        public static string Diff(bool result)
        {
            if (result== true)
            {
                return ("Files are NOT different");
            }
            else
                {
                return ("Files are different");
                }
        }

    }
}
