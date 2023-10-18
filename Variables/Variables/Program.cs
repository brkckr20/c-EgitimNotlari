using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "Burak Cakir";
            Console.WriteLine(name);
            

            bool isActive = false;
            Console.WriteLine(isActive);
            

            int yas = 32;
            Console.WriteLine(yas);
            Console.ReadKey();

            //tür dönüşümleri
            byte x = 12;
            short y = 10;
            //x = y; büyük değer küçük değere atanamaz
            y = x; // hata vermez
        }
    }
}
