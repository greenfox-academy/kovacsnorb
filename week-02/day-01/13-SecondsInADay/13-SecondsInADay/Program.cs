﻿using System;

namespace _13_SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables

            int secondsInADay = 24 * 60 * 60;
            int secondsElapsed = (currentHours * 60 + currentMinutes) * 60 + currentSeconds;
            int secondsRemaining = secondsInADay - secondsElapsed;

            Console.WriteLine("Remaining seconds from the day: " + secondsRemaining);
            Console.ReadLine();
        }
    }
}
