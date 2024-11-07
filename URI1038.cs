using System;
using System.Globalization;
namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {

            double item, quantidade, preco, total;

            string[] valores = Console.ReadLine().Split(' ');

            item = double.Parse(valores[0]);
            quantidade = double.Parse(valores[1]);



            if (item == 1)
            {
                preco = 4.0;
                total = preco * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            }

            else if (item == 2)
            {
                preco = 4.50;
                total = preco * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (item == 3)
            {
                preco = 5.00;
                total = preco * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else if (item == 4)
            {
                preco = 2.00;
                total = preco * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else {
                total = 1.5 * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }                     
        }
    }
}
