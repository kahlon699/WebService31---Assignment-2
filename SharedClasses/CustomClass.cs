using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses
{



    public class WordLength
    {

        public string word { get; set; }

        public int length { get; set; }
    }


    public class CustomClass
    {

        public List<string> StrList { get; set; }

        public string UpperCase { get; set; }
        public int StringLength { get; set; }

        public List<WordLength> WordLenList { get; set; }
    }

    public class MyError
    {
        public int Errorcode { get; set; }
        public string ErrorMsg { get; set; }
    }

}


