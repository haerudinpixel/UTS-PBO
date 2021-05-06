using System;

namespace Desimal_To_Heksa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Tugas Program Konversi Bilangan Desimal Ke Heksadesimal C#");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Nama        : Haerudin");
            Console.WriteLine("NPM         : 1101201008");
            Console.WriteLine("Prodi       : Teknik Informatika (Malam)");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Input Bilangan Desimal : ");

            int bilangan, hasilbagi;
            int x = 1, y, temp = 0;
            char[] heksadesimal = new char[100];
            char temp1;
            bilangan = int.Parse(Console.ReadLine());
            hasilbagi = bilangan;
            while (hasilbagi != 0)
            {
                temp = hasilbagi % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                heksadesimal[x++] = temp1;
                hasilbagi = hasilbagi / 16;
            }
            Console.Write("Hasil Konversi Ke Bilangan Heksadesimal : ");
            for (y = x - 1; y > 0; y--)
                Console.Write(heksadesimal[y]);
            Console.Read();
        }
    }
}