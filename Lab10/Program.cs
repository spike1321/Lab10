using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Corner corner;
            try
            {
               // do
               // {
                    Console.Write("Введите градусы: ");
                    double gradus = double.Parse(Console.ReadLine());
                    Console.Write("Введите минуты: ");
                    double min = double.Parse(Console.ReadLine());
                    Console.Write("Введите секунды: ");
                    double sec = double.Parse(Console.ReadLine());

                    corner = new Corner(gradus, min, sec);
               // }
               // while (corner.bug >0);
                  Console.WriteLine("Радианый угол равен: {0:0.00}", double.TryParse(corner.ToRadians(), out double q) ? q : throw new Exception(corner.ToRadians()));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
