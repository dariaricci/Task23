using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисления факториала приветствует вас");
            int Fact=FactorialAsync().Result;
            Console.WriteLine("Факториал числа={0}",Fact);
             
            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            int S = 1;
            Console.WriteLine("Метод Factorial начал работу");
            for (int i = 0; i < n; i++)
            {
                S *= n - i;

            }
           
            Console.WriteLine("Метод Factorial закончил работу");
            return (S);
        }
        static async Task<int> FactorialAsync()
        {
            Console.WriteLine("Метод FactorialAsync начал работу");
            Console.WriteLine("Введите число");
            int Number = Convert.ToInt32(Console.ReadLine());
            int R=await Task.Run(() => Factorial(Number));
            Console.WriteLine("Метод FactorialAsync закончил работу");
            return (R);
        }
    }
}
