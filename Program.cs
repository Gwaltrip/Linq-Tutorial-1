using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq l = new Linq();

            Console.WriteLine("The max is " + l.arrayMax());
            Console.WriteLine("Does 6 exists in the arr? " + l.exists(6));
            Console.WriteLine("Does 5 exists in the arr? " + l.exists(5));
            Console.WriteLine("How many times does 5 exists in the arr? " + l.amount(5));
            Console.Write("What numbers are less than 5? " );
            foreach (int i in l.whereLessThan(5))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("What nubmers are greater than 5? ");
            foreach (int i in l.whereGreaterThan(5))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Attempting to add 6, was it added? " + l.addIfNotExists(6));

            Console.WriteLine("Attempting to add 5, was it added? " + l.addIfNotExists(5));


            Console.ReadKey();
        }
    }
}
