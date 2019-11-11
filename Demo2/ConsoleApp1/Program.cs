using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hello World!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred. Error message as follows:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
