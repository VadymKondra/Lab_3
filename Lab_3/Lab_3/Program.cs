using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Number
    {
        public int value = 0;
        public void getValue()
        {
            Console.WriteLine(this.value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Number> numbers = new List<Number>();
            numbers.Add(new Number());
            numbers.First().getValue();
            numbers.First().value = 10;
            numbers.First().getValue();
            numbers.Remove(numbers.First());
            Console.ReadKey();

        }
    }
}
