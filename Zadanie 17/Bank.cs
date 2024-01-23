using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_17
{
    class Bank<T>
    {
        private T Schet { get; set; }
        private string Fio { get; set; }
        private int Balans { get; set; }

        public Bank(T schet, string fio, int balans)
        {
            Schet = schet;
            Fio = fio;
            Balans = balans;
        }
       
       public string GetInfo()
        {
        return $"{Schet} {Fio} {Balans}";
        }

    }
}
