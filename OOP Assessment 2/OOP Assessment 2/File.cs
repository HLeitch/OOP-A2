using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_2
{
    public class File
    {
        //
        public File(string name, string[] cont)
        {
            _name = name;
            _contents = cont;
        }

        private string[] _contents;

        private string _name;
        public string name { get { return _name; } set { _name = value; } }


        public string[] contents { get { return _contents; }set { _contents = value; } }



    }
}
