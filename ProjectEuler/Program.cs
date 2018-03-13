using System;
using ProjectEuler.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var (a, b, c) = Problem9.GetPythagoreanTripletWhichSumsTo(1000);
            Console.Out.WriteLine(a * b * c);
        }
    }
}
