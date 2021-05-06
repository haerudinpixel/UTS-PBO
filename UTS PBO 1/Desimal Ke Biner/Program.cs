using System;

namespace Desimal_To_Biner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Tugas Program Konversi Dari Bilangan Desimal Ke Biner C#");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Nama        : Haerudin");
            Console.WriteLine("NPM         : 1101201008");
            Console.WriteLine("Prodi       : Teknik Informatika (Malam)");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Input Angka Desimal Yang akan di Konversi : ");


            int bilangan, sisa;
            string hasil = "";
            bilangan = Convert.ToInt32(Console.ReadLine());
            while (bilangan > 0)
            {
                sisa = bilangan % 2;
                bilangan /= 2;
                hasil = sisa.ToString() + hasil;
            }
            Console.WriteLine("Hasil Konversi Ke Biner : {0}", hasil);
            Console.Read();
        }
    }
}
