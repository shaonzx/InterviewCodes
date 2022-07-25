using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewCodes.AnotherNamespace;

namespace InterviewCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegates
            /*_Delegate d = new _Delegate();
            d.Start();*/

            PhotoProcessor processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            //using existing filters in below two lines
            PhotoProcessor.PhotoFilterHandler handler = filters.ApplyBrightness;
            handler += filters.Resize;

            //use developer developed filter below (no filters object)
            handler += RemoveRedEyeFilter;

            processor.Process("", handler);

            void RemoveRedEyeFilter(Photo photo)
            {
                Console.WriteLine("Red eye removed");
            }
            #endregion

            #region Tuple

            /*var person = Tuple.Create(1, "Steve", "Jobs", 322);
            Console.WriteLine(person.Item4);

            //Tuples can hold custom types
            Students aStudent = new Students();
            var stuRec = Tuple.Create(aStudent, 1, "Some string");

            //Tuple can hold eight items at most, following will throw an error.
            //var someOtherTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8, 9);
            */

            #endregion

            #region Dictionary

            /*Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Read all data
            Console.WriteLine("Authors List");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }*/

            #endregion

            #region IEnumerable - IEnumerator

            //array implements IEnumerable
            /*var arr = new int[] {1, 2, 3, 4, 5};
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            arr.GetEnumerator();

            //List implements IEnumerable
            List<Students> _students = new List<Students>();
            _students.Add(new Students(){Grade = 1, Name = "King Bob", TotalScore = 599});

            foreach (Students student in _students)
            {
                Console.WriteLine(student.Name);
            }*/

            #endregion

            //OhMyClass.AccessMethodFromOtherNamespace();

            #region Reflection

            /*_Reflection re = new _Reflection();
            re.SomeMethod(typeof(string), "ADDRESS");*/

            #endregion


            Console.ReadLine();
        }
    }
}
