﻿using System;

namespace _23_IWontCheatOnTheExams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
        

        for (int i = 0; i < 100; i++)
            {
                Console.WriteLine((i + 1) + " - I won't cheat on the exam!");
            }

            Console.ReadLine();

        }
    }
}
