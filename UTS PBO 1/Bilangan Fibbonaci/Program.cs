using System;

namespace Bilangan_Prima
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Tugas Program Bilangan Fibonacci C#");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nama        : Haerudin");
            Console.WriteLine("NPM         : 1101201008");
            Console.WriteLine("Prodi       : Teknik Informatika (Malam)");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Input Bilangan Fibonacci  Ke - : ");

            int x = 1, y = 1, z = 1;
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine("Bilangan Fibonacci = {0}", z + " ");
                z = x + y;
                x = y;
                y = z;
            }
            Console.Read();
        }
    }
}