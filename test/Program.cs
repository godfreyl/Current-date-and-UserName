﻿using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine("UserName: {0}", Environment.UserName);
            Console.WriteLine(now);
            Console.ReadLine();
        }
    }
}
