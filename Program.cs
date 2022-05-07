using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcBulucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hangi gün doğduğunuzu yazınız ");
            int gun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Hangi ay dogdugunuzu yazınız ");
            int ay = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (gun >= 1 && gun <= 20 && ay == 1)
                {
                    Console.WriteLine(" Oğlak");
                }
                else if (gun >= 20 && gun <= 31 && ay == 1)
                {
                    Console.WriteLine(" Kova");
                }
                else if (gun >= 1 && gun <= 19 && ay == 2)
                {
                    Console.WriteLine(" Kova");
                }
                else if (gun >= 19 && gun <= 29 && ay == 2)
                {
                    Console.WriteLine(" Balık");
                }
                else if (gun >= 1 && gun <= 20 && ay == 3)
                {
                    Console.WriteLine(" Balık");
                }
                else if (gun >= 21 && gun <= 31 && ay == 3)
                {
                    Console.WriteLine(" Koc");
                }
                else if (gun >= 1 && gun <= 21 && ay == 4)
                {
                    Console.WriteLine(" Koc");
                }
                else if (gun >= 22 && gun <= 30 && ay == 4)
                {
                    Console.WriteLine(" Boga");
                }
                else if (gun >= 1 && gun <= 20 && ay == 5)
                {
                    Console.WriteLine(" Boga");
                }
                else if (gun >= 21 && gun <= 31 && ay == 5)
                {
                    Console.WriteLine(" İkizler");
                }
                else if (gun >= 1 && gun <= 21 && ay == 6)
                {
                    Console.WriteLine(" İkizler");
                }
                else if (gun >= 22 && gun <= 30 && ay == 6)
                {
                    Console.WriteLine(" Yengeç");
                }
                else if (gun >= 1 && gun <= 22 && ay == 7)
                {
                    Console.WriteLine(" Yengeç");
                }
                else if (gun >= 23 && gun <= 31 && ay == 7)
                {
                    Console.WriteLine(" Aslan");
                }
                else if (gun >= 1 && gun <= 23 && ay == 8)
                {
                    Console.WriteLine(" Aslan");
                }
                else if (gun >= 24 && gun <= 31 && ay == 8)
                {
                    Console.WriteLine(" Başak");
                }
                else if (gun >= 1 && gun <= 24 && ay == 9)
                {
                    Console.WriteLine(" Başak");
                }
                else if (gun >= 25 && gun <= 30 && ay == 9)
                {
                    Console.WriteLine(" Terazi");
                }
                else if (gun >= 1 && gun <= 23 && ay == 10)
                {
                    Console.WriteLine(" Terazi");
                }
                else if (gun >= 24 && gun <= 31 && ay == 10)
                {
                    Console.WriteLine(" Akrep");
                }
                else if (gun >= 1 && gun <= 22 && ay == 11)
                {
                    Console.WriteLine(" Akrep");
                }
                else if (gun >= 23 && gun <= 30 && ay == 11)
                {
                    Console.WriteLine(" Yay");
                }
                else if (gun >= 1 && gun <= 21 && ay == 12)
                {
                    Console.WriteLine(" Yay");
                }
                else if (gun >= 22 && gun <= 31 && ay == 12)
                {
                    Console.WriteLine(" Oğlak");
                }
            } while (false);
            Console.ReadLine();
        }
    }
    
}
