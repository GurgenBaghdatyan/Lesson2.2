using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a, b, c, d;
            Console.Write("a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d= ");
            d = Convert.ToInt32(Console.ReadLine());
            //1
            if (a > b && a > c && a > d)
            {
                Console.WriteLine("a is biggest");
            }
            else if (b > c && b > d)
            {
                Console.WriteLine("b is biggest");
            }
            else if (c > d)
            {
                Console.WriteLine("c is biggest");

            }
            else { Console.WriteLine("d is biggest"); }
            //2
            if (a < b && a < c && a < d)
            {
                Console.WriteLine("a is smallest");
            }
            else if (b < c && b < d)
            {
                Console.WriteLine("b is smallest");
            }
            else if (c < d)
            {
                Console.WriteLine("c is smallest");

            }
            else { Console.WriteLine("d is smallest"); }
            //3
            if (a == 1 || b == 1 || c == 1 || d == 1)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            //4
            if (a + b == c + d || a + c == b + d || a + d == c + b)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
            //5
            if (a == b + c + d || b == a + c + d || c == a + b + d || d == a + c + b)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            //6
            if (a % 2 == 1 && b % 2 == 1 || a % 2 == 1 && c % 2 == 1 || a % 2 == 1 && d % 2 == 1 || c % 2 == 1 && b % 2 == 1 || d % 2 == 1 && b % 2 == 1 || c % 2 == 1 && d % 2 == 1)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            //7
            if (a - b == b - c && b - c == c - d) Console.WriteLine("true");
            else if (a - b == b - d && b - d == d - c) Console.WriteLine("true");
            else if (a - c == c - b && c - b == b - d) Console.WriteLine("true");
            else if (a - c == c - d && c - d == d - b) Console.WriteLine("true");
            else if (a - d == d - b && d - b == b - c) Console.WriteLine("true");
            else if (a - d == d - c && d - c == c - b) Console.WriteLine("true");
            else if (b - a == a - c && a - c == c - d) Console.WriteLine("true");
            else if (b - a == a - d && a - d == d - c) Console.WriteLine("true");
            else if (b - c == c - a && c - a == a - d) Console.WriteLine("true");
            else if (b - d == d - a && d - a == a - c) Console.WriteLine("true");
            else if (c - a == a - b && a - b == b - d) Console.WriteLine("true");
            else if (c - b == b - a && b - a == a - d) Console.WriteLine("true");
            else Console.WriteLine("false");
            //8
            if (a / b == b / c && b / c == c / d) Console.WriteLine("true");
            else if (a / b == b / d && b / d == d / c) Console.WriteLine("true");
            else if (a / c == c / b && c / b == b / d) Console.WriteLine("true");
            else if (a / c == c / d && c / d == d / b) Console.WriteLine("true");
            else if (a / d == d / b && d / b == b / c) Console.WriteLine("true");
            else if (a / d == d / c && d / c == c / b) Console.WriteLine("true");
            else if (b / a == a / c && a / c == c / d) Console.WriteLine("true");
            else if (b / a == a / d && a / d == d / c) Console.WriteLine("true");
            else if (b / c == c / a && c / a == a / d) Console.WriteLine("true");
            else if (b / d == d / a && d / a == a / c) Console.WriteLine("true");
            else if (c / a == a / b && a / b == b / d) Console.WriteLine("true");
            else if (c / b == b / a && b / a == a / d) Console.WriteLine("true");
            else Console.WriteLine("false");
            //9
            int k;
            if (b > a)
            {
                k = a;
                a = b;
                b = k;
            }
            if (c > a)
            {
                k = a;
                a = c;
                c = k;
            }
            if (d > a)
            {
                k = a;
                a = d;
                d = k;
            }
            if (c > b)
            {
                k = b;
                b = c;
                c = k;
            }
            if (d > b)
            {
                k = b;
                b = d;
                d = k;
            }
            if (d > c)
            {
                k = c;
                c = d;
                d = k;
            }
            Console.WriteLine(a + " " + b + " " + c + " " + d);

            //10
            if (a > b)
            {
                k = a;
                a = b;
                b = k;
            }

            if (a > c)
            {
                k = a;
                a = c;
                c = k;
            }

            if (a > d)
            {
                k = a;
                a = d;
                d = k;
            }

            if (b > c)
            {
                k = b;
                b = c;
                c = k;
            }

            if (b > d)
            {
                k = b;
                b = d;
                d = k;
            }

            if (c > d)
            {
                k = c;
                c = d;
                d = k;
            }
            Console.WriteLine(a + " " + b + " " + c + " " + d);

            Console.ReadKey();
        }
    }
}

