using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, Sum, Sub, Multi, Div;

            Console.Write("Enter No. 1:");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No. 2:");
            n2=Convert.ToInt32(Console.ReadLine());
            Sum=n1+ n2;
            Console.WriteLine("Sum is:" + Sum);
            Console.ReadLine();

            Console.Write("Enter No. 3:");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No. 4:");
            n4 = Convert.ToInt32(Console.ReadLine());
            Sub = n3 - n4;
            Console.WriteLine("Sub is:" + Sub);
            Console.ReadLine();

            Console.Write("Enter No. 5:");
            n5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No. 6:");
            n6 = Convert.ToInt32(Console.ReadLine());
            Multi = n5 * n6;
            Console.WriteLine("Multi is:" + Multi);
            Console.ReadLine();

            Console.Write("Enter No. 7:");
            n7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No. 8:");
            n8 = Convert.ToInt32(Console.ReadLine());
            Div = n7 / n8;
            Console.WriteLine("Div is:" + Div);
            Console.Read();
        }
    }
}
