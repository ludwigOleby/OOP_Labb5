using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb5
{
    public class Check <Unknown>
    {
        public bool ToCheck(Unknown value1, Unknown value2)
        {
            if (value1.Equals(value2))
            {
                Console.WriteLine("True!");
                
                return true;
            }
            else
            {
                Console.WriteLine("False!");
                return false;
            }
        }
    }

    
}
