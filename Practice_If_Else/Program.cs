using System;

namespace PracticeIfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen bir sayı giriniz: ");

            string strSayi = Console.ReadLine();

            int sayi = Convert.ToInt32(strSayi);

            if (sayi > 10)
            {  
                Console.WriteLine("Girilen sayi 10'dan buyuktur.");                                  
            }
            else
            { 
                Console.WriteLine("Girilen sayi 10'dan kucuktur.");
            }

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayi cifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayi tektir.");
            } 
        }

    }
}