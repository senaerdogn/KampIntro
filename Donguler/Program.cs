using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array tanımlama
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs", "Java Kursu" };

            for(int i=0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("********************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("********************");

            for (int i = 0; i < length; i++)
            {

            }

            Console.ReadLine();
        }
    }
}
