using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write The Prime Number from n1 to n2");
            Console.Write("Enter The Number1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter The Number2 : ");
            int n2 = int.Parse(Console.ReadLine());
            for (; n1 <= n2; n1++)
            {
                if (n1 % 2 != 0 && n1 % 3 != 0)
                {
                    Console.WriteLine(n1);
                }




            }
        }
    }
}
    

