using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    class _Namespace
    {
        /**
         * Namespace is a block of code. Namespace is designed to keep one set of names separate from another. 
         */

        public _Namespace()
        {
            
        }
    }

    class AnotherClass
    {
        public static void PrintCrap()
        {
            Console.WriteLine("This is crap!");
        }
    }


    //nested namespace is possible
    namespace AnotherNamespace
    {
        public class OhMyClass
        {
            public static void AccessMethodFromOtherNamespace()
            {
                AnotherClass.PrintCrap();
            }
        }
    }

}
