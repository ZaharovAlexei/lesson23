using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson23
{
    //Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое значение: ");
            ulong n = Convert.ToUInt64(Console.ReadLine());
            FactorialAsync(n);
            Factorial(n);
            Console.ReadKey();

        }
        static void Factorial(ulong a)
        {
            ulong rezult = 1;
            for (uint i = 1; i < a + 1; i++)
            {
                rezult = rezult * i;
            }
            Console.WriteLine("{0}!={1}", a, rezult);
        }
        static async Task FactorialAsync(ulong n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
