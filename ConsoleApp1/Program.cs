using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new SneakerLibrary();

            Console.WriteLine("Введите бренд кроссовок:");
            string brand = Console.ReadLine();

            var sneakers = library.GetModelsByBrand(brand);

            if (sneakers.Count > 0)
            {
                Console.WriteLine($"\nМодели кроссовок бренда {brand}:");
                foreach (var sneaker in sneakers)
                {
                    Console.WriteLine(sneaker);
                }
            }
        }
    }
}
