using System.ComponentModel.Design;

namespace _19._10._2024_Deniz
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region ID-ŞİFRE

            //string username = "Deniz";
            //string password = "Aslı";
            //Console.WriteLine("KullanıcıAdı:");
            //string KullanıcıAdı = Console.ReadLine();
            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();
            //Console.WriteLine(username == KullanıcıAdı && password == sifre);




            //string name = "Deniz";
            //string phone = "5356846679";
            //string password = "Aslı";
            //Console.WriteLine("name / phone");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("sifre");
            //string sifre = Console.ReadLine();
            //Console.WriteLine(name == kullaniciAdi || phone == kullaniciAdi && password == sifre);




            //string name = "Deniz";
            //string sıfre = "Aslı";
            //string number = "1234";
            //Console.WriteLine("Name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Sıfre");
            //string Sıfre = Console.ReadLine();

            //if (name == Name && sıfre == Sıfre)
            //{
            //    Console.WriteLine("Number");
            //    string Number = Console.ReadLine();

            //    if (number == Number)
            //    {
            //        Console.WriteLine("Dogrulama Basarili");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dogrulama Kodu Yanlis");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hatali giris");
            //}



            #endregion



            #region Yaş Toplama
            //Console.WriteLine("ASLI VE DENİZİN YAŞLARI TOPLAMI");
            //int denizYas = 23;
            //int aslıYas = 22;
            //int yaslarToplamı = denizYas + aslıYas;
            //Console.WriteLine("Aslının Yaşı:" + aslıYas);
            //Console.WriteLine("Denizin Yaşı:" + denizYas);
            //Console.WriteLine("Yaşlar Toplamı:" + yaslarToplamı);
            #endregion


            //EGERHATAVARSA:
            //    Console.WriteLine("HAFTANIN BİR GÜNÜNÜ SEÇİNİZ");
            //    int gun = Convert.ToInt32(Console.ReadLine());
            //    if (gun == 1) { Console.WriteLine("PAZARTESİ"); }
            //    else if (gun == 2) { Console.WriteLine("SALI"); }
            //    else if (gun == 3) { Console.WriteLine("ÇARŞAMBA"); }
            //    else if (gun == 4) { Console.WriteLine("PERŞEMBE"); }
            //    else if (gun == 5) { Console.WriteLine("CUMA"); }
            //    else if (gun == 6) { Console.WriteLine("CUMARTESİ"); }
            //    else if (gun == 7) { Console.WriteLine("PAZAR"); }
            //    else
            //    {
            //        Console.WriteLine("YANLIŞ GÜN SEÇİMİ" +
            //        " LÜTFEN GEÇERLİ BİR GÜN SEÇİNİZ!! ");
            //        goto EGERHATAVARSA;
            //    }




            //** 2 ürün alınacak ürünler fiyatı toplamı 2500 tlyi geçerse ucuz olan ürüne %25 inidirim yapılacak



            //Console.WriteLine("Birinci Ürünün Fiyatını Giriniz");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci Ürünün Fiyatını Giriniz");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());
           
            //if ((fiyat1 + fiyat2) > 2500)
            //    if

            //        (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
                    
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
               
            //    }

            //Console.WriteLine("Toplam Ödeme Tutarı:" + (fiyat1 + fiyat2));







            Console.WriteLine("Birinci Ürünün Fiyatını Giriniz");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci Ürünün Fiyatını Giriniz");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());
            double indirimliFiyat;
            double toplam;

            if ((fiyat1 + fiyat2) > 2500)
            {
                if (fiyat1 < fiyat2)
                {
                    indirimliFiyat = fiyat1 - fiyat1 * 0.25;
                    toplam = fiyat2 + indirimliFiyat;
                    Console.WriteLine("indirimli toplam fiyat: " + toplam);
                }
                else if(fiyat2 < fiyat1)
                {
                    indirimliFiyat = fiyat2 - fiyat2 * 0.25;
                    toplam = fiyat1 + indirimliFiyat;
                    Console.WriteLine("İndirimli toplam fiyat: " + toplam);
                }

            }
           
            
            else
            {
                Console.WriteLine("ürün fiyat1:{0} , fiyat2: {1}",fiyat1,fiyat2);
            }





            Console.ReadLine();































































        }
    }
}
