using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //VALUE TYPES
            //int, decimal, float, double, bool, enum
            //Value typelar sadece STACK'tedir.
            //Atamalar tamamen değerler üzerinden olur ve işlem bitince bütün bağlantı kopar.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);    //30


            //REFERENCE TYPES
            //array, class, interface
            //new dediğimiz anda HEAP'te bir adreste yer açılır.
            //Atamalar, referansın adresiyle yapılır.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);    //999
        }
    }
}
