using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewCodes
{
    /**
     * Dependency injection is injecting the dependency of an object.
     *
     * PURPOSE: decrease coupling between classes and their dependencies.
     * By removing a client's knowledge of how its dependencies are implemented,
     * programs become more reusable, testable and maintainable.
     */
    public class Person
    {
        private Logger aLogger;
        public Person(Logger logger)
        {
            aLogger = logger;
        }
        public void SavePerson(Person aPerson)
        {
            //do the saving here...

            //following log has dependency on Logger class
            //new Logger().Log("Person created.");

            //instead we can pass the logger  through constructor injection and use here (see constructor)
            aLogger.Log("Person created");

        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
