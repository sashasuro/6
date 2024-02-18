using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 без параметров
            //static void Func()
            //{
            // Console.Write("Введите число:\t");
            // int x = int.Parse(Console.ReadLine());
            // Console.WriteLine("Вычисляем по формуле y = x^2");
            // int y = x * x;
            // Console.WriteLine($"{y}");
            // Console.ReadKey();
            //}
            //static void Main(string[]main)
            //{
            // Func();
            //}

            //2 с передачей параметров по значению
            //static void Main(string[] args)
            //{
            // Console.Write("Введите число:\t");
            // double x = int.Parse(Console.ReadLine());
            // Console.WriteLine("Вычисляем по формуле y = x^2");
            // double y = Func(x);
            // Console.WriteLine(y);
            // Console.ReadKey();
            //}
            //static double Func(double x)
            //{
            // double y = Math.Pow(x, 2);
            // return y;
            //}

            //3 с передачей по ссылке
            //static void Main(string[] args)
            //{
            // Console.Write("Введите число:\t");
            // double x = int.Parse(Console.ReadLine());
            // Console.WriteLine("Вычисляем по формуле y = x^2");
            // double y = Func(ref x);
            // Console.WriteLine(y);
            // Console.ReadKey();
            //}
            //static double Func(ref double x)
            //{
            // double y = Math.Pow(x, 2);
            // return y;
            //}
        }
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во людей:");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(163, 190);
                Console.Write("{0,4}", a[i]);
            }
            Console.ReadKey();
        }
        static int Sred(int[] omas)
        {
            int = sum = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                sum += omas[]
            }
        }
    }
}
