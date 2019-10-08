﻿using ProjectEuler.Tasks;
using System;
using System.Diagnostics;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExecuteAndMeasure(() => Problem22.Calculate(@"C:\Temp\p022_names.txt"));
        }

        private static void ExecuteAndMeasure<TResult>(Func<TResult> func)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine(func());

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
