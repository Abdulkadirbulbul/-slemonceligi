using System;

namespace odev_3hafta_uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aşağıda verilen ifadeler için sonuçları hesaplayarak operatörleri işlem önceliğini belirleyiniz.
               48/6/4 
                24/3*2
                2^2+5-1+4
                (7+4)*21+8/2
                (5-1)*2-1+7^2/2
            */


            //Soru 1    48/6/4 
            {
                /// işlem önceliği en soldan başlar. yani (48/6) işlemi önceliklidir.
                int sonuc = 48 / 6 / 4;
                Console.WriteLine(sonuc);
            }
            // Soru 2  24/3*2
            {
                // işlem önceliği en soldan başlar. yani (24/3) işlemi önceliklidir.
                int sonuc = (24 / 3) * 2;
                Console.WriteLine(sonuc);
            }
            // Soru 3   2^2+5-1+4
            {
                // Bu tarz durumlarda ilk önce çarpma ve bölme işlermleri yapılır.
                int a = 2 * 2;
                int sonuc = a + 51 + 4;
                Console.WriteLine(sonuc);
            }
            // Soru 4   (7+4)*21+8/2
            {
                // Bu tarz durumlarda öncelik parantez içlerinindir. Daha sonrasında çarpma ve bölme işlemleri
                //toplama çıkarmaya akrşı önceliklidir.
                int a = 7 + 4;
                int b = a * 21;
                int c = 8 / 2;
                int sonuc = b + c;
                Console.WriteLine(sonuc);
            }
            // Soru 5  (5-1)*2-1+7^2/2
            {
                // İlk 5 soruda uyguladıklarımızı yine yapacağız.
                int a = 5 - 1;
                int b = a * 2;
                int c = 7 * 7;
                int d = c / 2;
                int sonuc = b - 1 + d;
                Console.WriteLine(sonuc);
            }
            Console.ReadKey();
        }
    }
}
