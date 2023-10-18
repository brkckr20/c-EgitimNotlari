using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firtsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World!\n");
            //Console.WriteLine("İlk uygulamam");
            //Console.ReadKey();


            /*
                read ve readline

             */
            Console.WriteLine("Adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz Sayın " + ad + ".");
            Console.ReadKey();
        }
    }
}
