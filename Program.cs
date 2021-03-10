using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cikis = false;
            while (cikis != true)
            {
                Console.Clear();
                Console.WriteLine("İşlemler; Toplama : +, Çıkartma : -, Çarpma : *, Bölme : / tuşlarına basınız.\n");
                int sayi1 = 0, sayi2 = 0;
                Console.Write("Birinci Sayıyı giriniz : ");
                sayi1 += Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci Sayıyı giriniz : ");
                sayi2 += Convert.ToInt32(Console.ReadLine());
                Console.Write("Yapacağınız İşlem : ");
                char islem = Convert.ToChar(Console.ReadLine());
                switch (islem)
                {
                    case '+':
                        Console.Write("Toplama Sonucu :{0}", (sayi1 + sayi2));
                        break;
                    case '-':
                        Console.Write("Çıkartma Sonucu :{0}", (sayi1 - sayi2));
                        break;
                    case '*':
                        Console.Write("Çarpma Sonucu :{0}", (sayi1 * sayi2));
                        break;
                    case '/':
                        Console.Write("Bölme Sonucu :{0}", (sayi1 / sayi2));
                        break;
                    default:
                        Console.Write("Geçerli bir işlem kodu girmediniz...");
                        break;
                }
                Console.Write("\n\nÇıkmak istiyormusunuz (E/H)");
                char cikmak = Convert.ToChar(Console.ReadLine());
                if (cikmak == 'e' || cikmak == 'E')
                {
                    cikis = true; return;
                }
                else
                {
                    cikis = false;
                }
            }
        }
    }
}

