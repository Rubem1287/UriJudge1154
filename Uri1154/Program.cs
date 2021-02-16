using System;
using System.Globalization;
namespace Uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, total,cont;
            double media;
            cont = 0;
            total = 0;
            media = 0;
           

            a = int.Parse(Console.ReadLine());
            total += +a;

            while (a > 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a > 0)
                {
                    total += +a;
                    cont += +1;
                }
            }

            

            if (cont == 0)
            {
                Console.WriteLine();
                Console.WriteLine(a);
            }
            else
            {
                cont += +1;
                media = (double)total / cont;
                Console.WriteLine();
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

           
          
        }
    }
}
