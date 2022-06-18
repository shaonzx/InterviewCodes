using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    class _Delegate
    {
        private List<Students> _students;
        private Students aStudent;
        public _Delegate()
        {
            _students = new List<Students>();
            //populating data for this example
            _students.Add(new Students() {Grade = 1, Name = "Abul", TotalScore = 599});
            _students.Add(new Students() {Grade = 2, Name = "Babul", TotalScore = 850});
            _students.Add(new Students() {Grade = 3, Name = "Momen", TotalScore = 700});
            _students.Add(new Students() {Grade = 4, Name = "Alga", TotalScore = 433});
            _students.Add(new Students() {Grade = 3, Name = "Kusu", TotalScore = 532});
            _students.Add(new Students() {Grade = 5, Name = "Mlew", TotalScore = 725});
            _students.Add(new Students() {Grade = 2, Name = "Candy", TotalScore = 647});
            _students.Add(new Students() {Grade = 1, Name = "Habil", TotalScore = 482});
            _students.Add(new Students() {Grade = 3, Name = "Kabil", TotalScore = 992});
            _students.Add(new Students() {Grade = 4, Name = "Shamsu", TotalScore = 325});

        }

        /**
         * A delegate is a reference type which holds reference to a method.
         */

        //delegate - type - delegateName (params)
        delegate void Mydelegate(int a); //declaration

        public void Start()
        {
            //as long as a method match the return type and parameters of a delegate, we can make a reference to it.
            Mydelegate _mydelegate = Foo;
            _mydelegate.Invoke(5);

        }

        
        //delegate pattern match - return type + parameters
        public void Foo(int a)
        {
            Console.WriteLine(a);
        }

        //delegate pattern match - return type + parameters
        void Bar(int a)
        {
            //do something
        }

    }
}
