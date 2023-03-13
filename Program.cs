using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorConsoleAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            int a = 10; // deklarasi variabel a, dg nilai awal 10;
            int b = 6; // deklarasi variabel b, dg nilai awal 6;

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); //proses costing

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); //proses costing

            Console.WriteLine(); // tambahkan berkas kosong

            Console.WriteLine("hasil penambahan" + a + " + " + b + " = " + penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
