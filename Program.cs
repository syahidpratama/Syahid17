using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kalkulator
{
 class program
 {
 static void Main(string[] args)
 {
 string pilih;
 string ulang;
 int angka1;
 int angka2;
 lang:
 Console.WriteLine("=====KALKULATOR=====");
 Console.WriteLine("1. perjumlahan");
 Console.WriteLine("2. pengurangan");
 Console.WriteLine("3. perkalian");
 Console.WriteLine("4. pembagian");
 Console.Write("silahkan masukan nomer pilihan anda = ");
 pilih = Console.ReadLine();
 Console.WriteLine("");
 if (pilih == "1")
 {
 Console.Write("angka ke 1 = ");
 angka1 = Convert.ToInt32 (Console.ReadLine());
 Console.Write("angka ke 2 = ");
 angka2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("hasil perjumlahan dari "+ angka1 +" + "+ angka2 
+" = "+ penambahan(angka1,angka2));
 } else if (pilih == "2")
 {
 Console.Write("angka ke 1 = ");
 angka1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("angka ke 2 = ");
 angka2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("hasil perjumlahan dari " + angka1 + " - " + 
angka2 + " = " + pengurangan(angka1, angka2));
 } else if (pilih == "3")
 {
 Console.Write("angka ke 1 = ");
 angka1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("angka ke 2 = ");
 angka2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("hasil perjumlahan dari " + angka1 + " * " + 
angka2 + " = " + perkalian(angka1, angka2));
 } else if (pilih == "4")
 {
 Console.Write("angka ke 1 = ");
 angka1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("angka ke 2 = ");
 angka2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("hasil perjumlahan dari " + angka1 + " / " + 
angka2 + " = " + pembagian(angka1, angka2));
 }
 Console.Write("Apakah anda ingin mengulang (y/n) = ");
 ulang = Console.ReadLine();
 if (ulang == "y")
 {
 Console.WriteLine("");
 goto lang;
 
 }
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
