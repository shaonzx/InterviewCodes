using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    public class MySingleton    
    {
        //parameterless private constructor prevents creation of instances.
        private MySingleton() {/*implementions not necessary*/}

        //Initialize private instance which can access private constructor
        //private static MySingleton _instance = null; -- for lazy loading implemention
        private static MySingleton _instance = new MySingleton();

        //a public property to access the created instance
        public static MySingleton Instance
        {
            get
            {
                //following if condition implements lazy loading ensuring that Instance is accessed first
                /*if (_instance == null)
                {
                    _instance = new MySingleton();
                }*/
                return _instance;
            }
        }

        public void PrintCrap()
        {
            Console.WriteLine("This is crap from Singleton class!");
        }
    }
}
