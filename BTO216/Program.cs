using System;

namespace BTO216
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tek satırlık yorum

            /*
            Birden fazla yorum
            satırı
            */

            //Örnek for döngüsü
            for (int i = 0; i < 10; i++)
            {
                Console.Write("A");                
            }            

            //Konsola yazdırma
            Console.WriteLine("Test");

            //Konsoldan veri okuma
            string aa = Console.ReadLine();

            Console.Clear(); //Konsolu temizler
            Console.Beep(); //Beep sesi çıkar
        }
    }
}