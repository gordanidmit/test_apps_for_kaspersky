using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5, 9, 9, 1, 1, 2, 5 };
            int sum = 10;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i<list.Count; i++)
            {
                if(!dict.ContainsKey(list[i]))
                {
                    dict[list[i]] = 0;
                }
                dict[list[i]]++;
            }

            Console.WriteLine("Исходная коллекция: {0}", String.Join(", ", list));
            Console.WriteLine("Сумма должна быть равна {0}", sum);
            Console.WriteLine("Результаты:");
            foreach(var x1 in list)
            {
                if (dict[x1] != 0 && dict[x1] > 0)
                {
                    dict[x1]--;
                    var x2 = sum - x1;

                    if (dict[x2] > 0)
                    {
                        Console.WriteLine("({0}, {1})", x1, x2);
                        dict[x2]--;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
