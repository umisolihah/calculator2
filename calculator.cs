using System;

namespace Calculator
{
        class Calculator {

            static void Main(string[] args) { 

            Console.WriteLine("Pilih Menu Calculator");

            Console.WriteLine();

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();

            Console.Write("Input Nomor Menu = ");
            int opt = int.Parse(Console.ReadLine());

            Console.WriteLine();


            if(opt == 1 || opt ==  2 || opt == 3 || opt == 4 ) {
                Console.Write("Masukkan nilai 1 = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan nilai 2 = ");
                int b = int.Parse(Console.ReadLine());
                    if(opt == 1) {
                        Console.Write("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
                    } else if (opt == 2) {
                        Console.Write("Hasil Pengurangan : " + a + " - " + b + " = " + Pengurangan(a, b));
                    } else if (opt == 3)  {
                        Console.Write("Hasil Perkalian : " + a + " x " + b + " = " + Perkalian(a, b));
                    } else if (opt == 4) {
                        Console.Write("Hasil Pembagian : " + a + " : " + b + " = " + Pembagian(a, b));
                    }

            }  else {
                Console.Write("Maaf, Pilihan anda tidak tersedia!");
            }
            
            Console.WriteLine();

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
            }
            
            static int Penambahan (int a, int b) {
                return a + b;
            }

            static int Pengurangan (int a, int b) {
                return a - b;
            }

            static int Perkalian (int a, int b) {
                return a * b;
            }

            static int Pembagian (int a, int b) {
                return a / b;
            }

    }

    
}