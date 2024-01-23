using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadanie_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер");
            int schetInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите фио");
            string fio = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            int balans = Convert.ToInt32(Console.ReadLine());
            Bank<int> bank1 = new Bank<int>(schetInt, fio, balans);
            Console.WriteLine(bank1.GetInfo());
            Console.WriteLine("Введите строковый номер");
            string schetString = Console.ReadLine();
            Console.WriteLine("Введите фио");
            fio = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            balans = Convert.ToInt32(Console.ReadLine());
            Bank<string> bank2 = new Bank<string>(schetString, fio, balans);
            Console.WriteLine(bank2.GetInfo());
            Console.ReadKey();
        }
    }
}
