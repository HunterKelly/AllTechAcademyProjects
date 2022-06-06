using System;

namespace methodClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            methodclass method1 = new methodclass();

            method1.Math(5, 10);

            //set variables to call by name.
            int x = 7;
            int y = 14;
            method1.Math(x, y);

        }
    }
}
