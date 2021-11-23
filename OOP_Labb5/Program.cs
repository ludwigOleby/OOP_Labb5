using System;
using System.Collections.Generic;

namespace OOP_Labb5
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckOne co1 = new CheckOne();
            co1.ToCheck(1, 5);
            CheckOne co2 = new CheckOne();
            co2.ToCheck(4, 4);

            CheckTwo ct1 = new CheckTwo();
            ct1.ToCheck("String1", "String2");
            CheckTwo ct2 = new CheckTwo();
            ct1.ToCheck("String1", "String1");
        }
    }
}
