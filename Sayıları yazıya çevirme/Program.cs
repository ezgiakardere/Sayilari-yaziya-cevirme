using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sayıları_yazıya_çevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi,i=0;
            
            while (true)
            {
                do
                {
                    Console.WriteLine("\nSayıyı gir: ");
                    sayi = Convert.ToInt32(Console.ReadLine());

                   while (sayi > 999 || sayi < 0)
                    {
                        Console.WriteLine("Hatalı sayı girdiniz.Tekrar girin");
                        Console.ReadKey();
                        Console.WriteLine("Sayıyı gir:");
                        sayi = Convert.ToInt32(Console.ReadLine());
                    }
                     break;


                } while (i == 1);
              
                int yüzler = sayi / 100;
                Console.WriteLine("Yüzler basamağı= " + yüzler);
                Console.ReadKey();

                int onlar = (sayi / 10) % 10;
                Console.WriteLine("Onlar basamağı= " + onlar);
                Console.ReadKey();

                int birler = sayi % 10;
                Console.WriteLine("Birler basamağı= " + birler);
                Console.ReadKey();


                switch (yüzler)
                {
                    case 1:
                        Console.Write("Yüz");

                        break;
                    case 2:
                        Console.Write("İki yüz");

                        break;
                    case 3:
                        Console.Write("Üç Yüz");

                        break;
                    case 4:
                        Console.Write("Dört Yüz");

                        break;
                    case 5:
                        Console.Write("Beş Yüz");
                        break;
                    case 6:
                        Console.Write("Altı Yüz");

                        break;
                    case 7:
                        Console.Write("Yedi Yüz");
                        break;
                    case 8:
                        Console.Write("Sekiz Yüz");
                        break;
                    case 9:
                        Console.Write("Dokuz Yüz ");
                        break;

                    default: break;
                }


                switch (onlar)
                {
                    case 1:
                        Console.Write(" On");

                        break;
                    case 2:
                        Console.Write(" Yirmi");
                        break;
                    case 3:
                        Console.Write(" Otuz");
                        break;
                    case 4:
                        Console.Write(" Kırk");
                        break;
                    case 5:
                        Console.Write(" Elli");
                        break;
                    case 6:
                        Console.Write(" Altmış");
                        break;
                    case 7:
                        Console.Write(" Yetmiş");
                        break;
                    case 8:
                        Console.Write(" Seksen");
                        break;
                    case 9:
                        Console.Write(" Doksan");

                        break;
                    default: break;
                }
                switch (birler)
                {
                    case 1:
                        Console.Write(" Bir");

                        break;
                    case 2:
                        Console.Write(" İki");

                        break;
                    case 3:
                        Console.Write(" Üç");

                        break;
                    case 4:
                        Console.Write(" Dört");
                        break;
                    case 5:
                        Console.Write(" Beş");
                        break;
                    case 6:
                        Console.Write(" Altı");
                        break;
                    case 7:
                        Console.Write(" Yedi");
                        break;
                    case 8:
                        Console.Write(" Sekiz");
                        break;
                    case 9:
                        Console.Write(" Dokuz");
                        break;
                    default: break;
                }
                if (sayi == 0)
                {
                    Console.WriteLine("Sıfır ");
                    Console.ReadKey();
                }

               
            }
            
        }
      
    }
}
