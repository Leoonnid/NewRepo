﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 2 * Math.Cos(x);
        }
    }
}
