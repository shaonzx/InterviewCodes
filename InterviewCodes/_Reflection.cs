using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    class _Reflection
    {
        /**
         * D-SIMPLE
         * Dynamically SEE & Invoke Members & Properties for Loading an Examination
         */

        public void SomeMethod(Type type, string address)
        {
            /*object result = null;

            if (type == typeof(double))
            {
                result = Memory.Read<double>(address);
            }
            else if (type == typeof(int))
            {
                result = Memory.Read<int>(address);
            }
            else if (type == typeof(string))
            {
                result = Memory.Read<string>(address);
            }
            else if (type == typeof(bool))
            {
                result = Memory.Read<bool>(address);
            }*/

            /**
             * In this example, I wrote only 4 types but in real life it could be far more.
             * So writing else if statements  for all those could be a mess.
             * This is where Reflection comes handy.
             * we could replace the above code with just three lines.
             */
            var methodInfo = typeof(Memory).GetMethod(nameof(Memory.Read));
            var genericMethodInfo = methodInfo.MakeGenericMethod(type);
            var result = genericMethodInfo.Invoke(null, new object[] {address});

            Console.WriteLine("Result value is " + result);
            Console.WriteLine("Result type is " + result.GetType());
        }

        //writing it as an example. In real life we may not control it
        class Memory
        {
            public static T Read<T>(string address)
            {
                var type = typeof(T);

                if (type == typeof(double))
                {
                    return ConvertType<T>(150.53);
                }
                else if (type == typeof(int))
                {
                    return ConvertType<T>(237);
                }
                if (type == typeof(string))
                {
                    return ConvertType<T>("This is a string value");
                }
                if (type == typeof(bool))
                {
                    return ConvertType<T>(true);
                }

                return default(T);
            }
        }

        static T ConvertType<T>(object value)
        {
            return (T) Convert.ChangeType(value, typeof(T));
        }
    }
}
