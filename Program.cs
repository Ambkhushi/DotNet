using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @out
{
    public class Calc
    {
        public void Add(params double[] numbers)
        {
            double sum = 0;
            foreach(double number in numbers)
            {
               sum += number;
            }
            Console.WriteLine("Total of Number is : \t" + sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
