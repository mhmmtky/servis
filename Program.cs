using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SERSİ UYGULAMASI
            
            List<string> isimler = new List<string>();
            int kisiSayisi = 0;
            string karar;

            while (true) 
            {
                Console.WriteLine("Öğrenci adı giriniz.");
                kisiSayisi++;
                string isim = Console.ReadLine();
                isimler.Add(isim);
                Console.WriteLine("Başka bir isim girmek istiyormusunuz? E - H");
                karar = Console.ReadLine();
                if(karar == "E") {  }
                else if (karar == "H")
                {
                    Console.WriteLine("Kayıtlı kişi = "+ kisiSayisi);
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz değer girdiniz. Tekrar deneyin");
                }
            }

            Console.WriteLine("Otobüs Koltuk sayısını girin.");
            int koltuk = Convert.ToInt32(Console.ReadLine());
            if (kisiSayisi > koltuk)
            {
                Console.WriteLine("Koltuk sayısı yeterli değil!");
            }
            else
            {
                Console.WriteLine("Koltuk sayısı yeterli!");
            }

            Console.ReadKey();
        }
    }
}
