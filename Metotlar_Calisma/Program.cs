namespace Metotlar_Calisma
{
    class Program
    {
        static string ayrac = new string('-', 20);
        public static void Main(string[] args)
        {
            anamenu();
        }
        public static void anamenu()
        {
            string islem;
            Console.Write("{0} Hoşgeldiniz! {1}\n Yapmak İstediğiniz işlemi seçiniz... \n 1 - Temel İşlemler \n 2 - Mod 3 İşlemi \n 3 - Bir sayının Küpünü Alma İşlemi \n", ayrac, ayrac);
            islem = Console.ReadLine();
            switch (islem)
            {
                case "1":
                    hesapMakinesi();
                    break;
                case "2":
                    mod();
                    break;
                case "3":
                    kupAlma();
                    break;
            }
        }
            public static void hesapMakinesi()
            {
                Console.Clear();
                string islem;
                int birinciSayi, ikinciSayi;
                Console.WriteLine("{0} Hesap Makinesine Hoşgeldiniz {1} \n Yapabileceğim işlemler\n  1- Toplama İşlemi \n 2- Çıkarma İşlemi \n 3- Çarpma İşlemi \n 4- Bölme İşlemi",ayrac,ayrac);
                islem=Console.ReadLine();
                if (islem == "1" || islem == "+")
                {
                    Console.WriteLine("{0}İlk değeri giriniz: ", ayrac);
                    birinciSayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} İkinci değeri giriniz: ", ayrac);
                    ikinciSayi = Convert.ToInt32(Console.ReadLine());
                    Console.Write(ayrac);
                    Console.WriteLine("{0} Birinci Değer: {1} \n İkinci Değer: {2} \n Sonuç= {3}", ayrac, birinciSayi, ikinciSayi, birinciSayi + ikinciSayi);
                }
                else if (islem == "2" || islem == "-")
                {
                    Console.WriteLine("{0} İlk değeri giriniz: ", ayrac);
                    birinciSayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} İkinci değeri giriniz: ", ayrac);
                    ikinciSayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(ayrac);
                    Console.WriteLine("{0} Birinci Değer: {1} \n İkinci Değer: {2} \n Sonuç= {3}",ayrac,birinciSayi,ikinciSayi,birinciSayi-ikinciSayi);
                }
                else if(islem == "3" || islem == "*")
                {
                    Console.WriteLine("{0} İlk değeri giriniz: ",ayrac);
                    birinciSayi=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} İkinci sayiyi giriniz: ",ayrac);
                    ikinciSayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(ayrac);
                    Console.WriteLine("{0} Birinci Değer: {1} \n İkinci Değer: {2} \n Sonuç: {3}",ayrac,birinciSayi,ikinciSayi,birinciSayi*ikinciSayi);
                }
                else if(islem=="4" || islem == "/")
                {
                    Console.WriteLine("{0} İlk değeri giriniz: ",ayrac);
                    birinciSayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} İkinci değeri giriniz: ",ayrac);
                    ikinciSayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(ayrac);
                    Console.WriteLine("{0} Birinci değer: {1} \n İkinci değer: {2} \nSonuç: {3}",ayrac,birinciSayi,ikinciSayi,birinciSayi/ikinciSayi);
                }
                else
                {
                    Console.WriteLine("{0} Geçersiz bir değer girdiniz... {1}", ayrac, ayrac);
                }

            }

            public static void mod()
            {
                int sayi;
                Console.WriteLine("{0} Modunu almak istediğiniz değeri giriniz: ",ayrac);
                sayi = Convert.ToInt32(Console.ReadLine());
                
                if (sayi % 3 == 0)
                {
                    Console.WriteLine("3'e tam bölünen bir tam sayıdır.");
                }
                else
                {
                    Console.WriteLine("3'e tam bölünmez.");
                }
            }
        public static void kupAlma()
        {
            int sayi1,sonuc;
            Console.WriteLine(" {0} Kup alma işlemi için sayi giriniz: ", ayrac);
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi1 * sayi1 * sayi1;
            Console.WriteLine("Sonuc: {0}", sonuc);
        }
        
    }
}
