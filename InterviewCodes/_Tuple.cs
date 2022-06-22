using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    class _Tuple
    {
        /**
         * A tuple is a data structure that contains a sequence of elements of different types.
         * It can be used where you want to have a data structure to hold an object with properties,
         * but you don't want to create a separate type for it.
         * CUSTOM TYPES CAN BE ADDED.
         * Examples in main function
         */
        private Tuple<int, string, string, int> myTuple = new Tuple<int, string, string, int>(1, "Name", "Address", 2);

        

        //private Tuple<int, string, string, int> myTuple = new Tuple<int, string, string, int>(1, "Name", "Address", 2);
    }
}
