using System;

namespace TasksLibrary
{
    public class MyClass
    {
        public static double GetSqrt(double value) // take square root
        {
            return Math.Sqrt(value);
        }

        public string SayHello(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Parameter name caanot be null");
            }

            return "Hello" + name;
        }
    }
}
