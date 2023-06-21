// Kullanicidan alinan degerlere göre ve switch-case yapisi kullanarak mini atm uygulamasi yaptik
/* 1-Bakiye goruntuleme
   2-Para cekme
   3-Para yatirma
   4-Cikis yapma
   1-2-3-4 disinda girilen deger- Hata
*/

namespace SwitchCaseIleAtm
{
   class Program
   {
      static void Main(string[] args)
      {
         int bakiye = 800;
         
         Console.WriteLine("ATM'ye Hoşgeldiniz...");
         Console.WriteLine("Lütfen bir islem seciniz");
         Console.WriteLine("1- Bakiye goruntule");
         Console.WriteLine("2- Para cek");
         Console.WriteLine("3- Para Yatir");
         Console.WriteLine("4- Cikis yap");

         string secim = Console.ReadLine();

         switch (secim)
         {
            case "1":
               Console.WriteLine("Bakiyeniz:" +bakiye);
               Console.ReadLine();
               break;
            case "2":
               Console.WriteLine("Cekmek istediginiz tutar:");
               int cekilecek_tutar = Convert.ToInt32((Console.ReadLine()));

               if (cekilecek_tutar > bakiye)
               {
                  Console.WriteLine("Bakiyeden fazla para cekemezsiniz");
                  Console.ReadLine();
               }
               else
               {
                  Console.WriteLine("Kalan Bakiyeniz:"+ (bakiye-cekilecek_tutar));
                  Console.ReadLine();
               }
               break;
            case "3":
               Console.WriteLine("Yatirmak istediginiz tutar:");
               int yatirilacak_tutar = Convert.ToInt32((Console.ReadLine()));
               
               Console.WriteLine("Yeni tutar:"+(bakiye+yatirilacak_tutar));
               Console.ReadLine();
               break;
            case"4":
               Console.WriteLine("Hesabınızdan cikis yapildi");
               Console.ReadLine();
               break;
            default:
               Console.WriteLine("Lütfen gecerli bir deger giriniz");
               Console.ReadLine();
               break;
         }
      }
   }
}

