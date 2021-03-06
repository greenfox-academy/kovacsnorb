﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            Console.Write("Give me a base: ");
            int userBase = int.Parse(Console.ReadLine());
            Console.Write("Give me a power: ");
            int userPower = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(userBase,userPower));
            Console.ReadLine();
        }

        public static int Power(int baseInput, int powerInput)
        {
            if (powerInput == 0)
            {
                return 1;
            }
            else
            {
                return baseInput * Power(baseInput, powerInput - 1);
            }
        }
    }
}
