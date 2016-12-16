using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning 1
            string[] namn = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Mata in 10 namn: ");
                namn[i] = Console.ReadLine();
            }
            Console.WriteLine("Dina vänner: ");
            for (int i = 0; i < namn.Length; i++)
            {
                Console.Write(namn + ", ");
            }
        }
    }
}
