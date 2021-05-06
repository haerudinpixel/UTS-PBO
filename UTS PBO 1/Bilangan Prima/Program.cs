using System;

namespace Bilangan_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prima = true;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Tugas Program Bilangan Prima C#");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nama        : Haerudin");
            Console.WriteLine("NPM         : 1101201008");
            Console.WriteLine("Prodi       : Teknik Informatika (Malam)");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Input Batas Bilangan Prima : ");

            int bilangan = int.Parse(Console.ReadLine());

            if (bilangan >= 2)
            {
                for (int i = 2; i <= bilangan; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }

                    if (prima)
                        Console.WriteLine("Bilangan Prima 12 = {0}", i);
                    prima = true;
                }
            }
            else
                Console.WriteLine("Tidak ada bilangan prima yang bisa dituliskan");
            Console.ReadLine();
        }
    }
}