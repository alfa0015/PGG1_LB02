using System;
using System.Linq;

namespace Lb02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] m = new int[50];
            int[] t = new int[80];
            int[] n = new int[65];
            for (int i = 0; i < 50; i++)
            {
                int years = rnd.Next(1, 30);
                m[i] = years;
            }
            Console.WriteLine("Promedio de edades turno mañana");
            int prom1 = m.Sum(x => Convert.ToInt32(x)) / m.Length;
            Console.WriteLine(prom1);
            for (int i = 0; i < 80; i++)
            {
                int years = rnd.Next(1, 30);
                t[i] = years;
            }
            Console.WriteLine("Promedio de edades turno tarde");
            int prom2 = t.Sum(x => Convert.ToInt32(x)) / t.Length;
            Console.WriteLine(prom2);
            for (int i = 0; i < 65; i++)
            {
                int years = rnd.Next(1, 30);
                n[i] = years;
            }
            Console.WriteLine("Promedio de edades turno tarde");
            int prom3 = n.Sum(x => Convert.ToInt32(x)) / n.Length;
            Console.WriteLine(prom3);
            if (prom1 > prom2 && prom1 > prom3)
            {
                Console.WriteLine("El promedio mayor es del turno de la mañana");
            }
            else if (prom2 > prom1 && prom2 > prom3)
            {
                Console.WriteLine("El promedio mayor es del turno de la tarde");
            }
            else
            {
                Console.WriteLine("El promedio mayor es del turno de la noche");
            }
            Console.ReadKey();
        }
    }
}
