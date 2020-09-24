using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Q1
    {

        public int getNumberFamily(int Number)
        {
            string numberString = Number.ToString();
            List<int> Numbers = numberString.Select(digit => Convert.ToInt32(digit.ToString())).ToList();
            Numbers.Sort();
            Numbers.Reverse();

            var value = int.Parse(string.Join(",", Numbers).Replace(",", ""));

            int numberFamily = value > 100000000 ? -1 : value;


            return numberFamily;
        }
    }
}
