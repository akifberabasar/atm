

Console.WriteLine("Atmye hoş geldiniz");

double bakiye = 25000;
string sifre = "ab18";
int hak = 3;

Console.WriteLine("İşlem türünü seçiniz");
Console.WriteLine("Kartlı işlem için -1");
Console.WriteLine("Kartsız işlem için -2");

int islemTur = Convert.ToInt32(Console.ReadLine());

switch (islemTur)
{
    case 1:
    login:
        Console.WriteLine("Şifre giriniz:");
        string yanit = Console.ReadLine();
        if (hak > 0)
        {
            if (yanit == sifre)
            {
                Console.WriteLine("Şifre doğru");
                Console.WriteLine("-----------------");
            islem:
                Console.WriteLine("Yapacağınız işlemi seçin");
                Console.WriteLine("1- Para yatırma");
                Console.WriteLine("2- Para çekme");
                Console.WriteLine("3- Para Transferi");
                Console.WriteLine("4- Eğitim Ödemeleri");
                Console.WriteLine("5- Ödemeler");
                Console.WriteLine("6- Bilgi Güncelleme");
                Console.WriteLine("7- Krediler");
                int islemsecim = Convert.ToInt32(Console.ReadLine());
                switch (islemsecim)
                {
                    case 1:
                        Console.WriteLine("Yatıracağınız para miktarı");
                        int yatanpara = Convert.ToInt32(Console.ReadLine());
                        bakiye += yatanpara;
                        Console.WriteLine("Toplam paranız: " + bakiye);
                        goto islem;

                        break;
                    case 2:
                        Console.WriteLine("Çekeceğiniz para miktarı");
                        int cekilenpara = Convert.ToInt32(Console.ReadLine());

                        if (cekilenpara > bakiye)
                        {
                            Console.WriteLine("Bakiyeniz yeterli değil");
                            Console.WriteLine("Ana menü için 9'a basınız");
                            Console.WriteLine("Çıkış için 0'a basınız");
                            int cikis = Convert.ToInt32(Console.ReadLine());

                            if (cikis == 9)
                            {
                                goto islem;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            bakiye -= cekilenpara;
                            Console.WriteLine("Toplam paranız: " + bakiye);
                            goto islem;

                        }
                        break;
                    case 3:
                        Console.WriteLine("İşlem yapacağınız ibanı giriniz");
                        string iban =Console.ReadLine();
                        Console.WriteLine("Göndereceğiniz miktarı giriniz");
                        int miktar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("TR "+iban+" hesabına " + miktar+ "tl gönderilmiştir.");
                        bakiye-=miktar;

                        goto islem;

                        break;
                    case 4:
                        Console.WriteLine("Eğitim türünü seçiniz");
                        Console.WriteLine("İlkokul sınavı: 100 tl");
                        Console.WriteLine("Oratokul sınavı: 200 tl");
                        Console.WriteLine("Lise sınavı: 300 tl");
                        Console.WriteLine("Üniversite sınavı: 400 tl");
                        int egitim = Convert.ToInt32(Console.ReadLine());
                        switch (egitim)
                        {
                            case 1:
                                Console.WriteLine("İlkokul sınav ücreti hesabınızdan tahsil edilecekir.");
                                bakiye -= 100;
                                Console.WriteLine(bakiye);
                        goto islem;

                                break;
                            case 2:
                                Console.WriteLine("Ortaokul sınav ücreti hesabınızdan tahsil edilecekir.");
                                bakiye -= 200;
                                Console.WriteLine(bakiye);
                                goto islem;

                                break;
                            case 3:
                                Console.WriteLine("Lise sınav ücreti hesabınızdan tahsil edilecekir.");
                                bakiye -= 300;
                                Console.WriteLine(bakiye);
                                goto islem;

                                break;
                            case 4:
                                Console.WriteLine("Üniveresite sınav ücreti hesabınızdan tahsil edilecekir.");
                                bakiye -= 400;
                                Console.WriteLine(bakiye);
                                goto islem;

                                break;
                        }
                        goto islem;

                        break;
                    case 5:
                        Console.WriteLine("Yapacağınız ödemeyi seçiniz");
                        Console.WriteLine("1- Fatura");
                        Console.WriteLine("2- Vergi");
                        int odeme = Convert.ToInt32(Console.ReadLine());

                        switch (odeme)
                        {
                            case 1:
                                Console.WriteLine("Ödeyeceğiniz faturayı seçiniz");
                                Console.WriteLine("1-Elektrik Faturası");
                                Console.WriteLine("2-Telefon Faturası");
                                Console.WriteLine("3-Otopark faturası");
                                int fatura = Convert.ToInt32(Console.ReadLine());
                                switch (fatura)
                                {
                                    case 1:
                                        int elektrik = 3;
                                        int elektrikfatura =0;
                                        Console.WriteLine("100 kj üzerinde aşırı tüketimden ceza kesilecektir");
                                        Console.WriteLine("Tüketim miktarını giriniz");
                                        int enerji = Convert.ToInt32(Console.ReadLine());
                                        if (enerji < 100)
                                        {
                                            elektrikfatura = enerji * elektrik;
                                            Console.WriteLine("Fatura tutarı:" + elektrikfatura);
                                        }
                                        else if (enerji > 100)
                                        {
                                            elektrikfatura = enerji * elektrik + 350;
                                            Console.WriteLine("Fatura tutarı:" + elektrikfatura);
                                        }
                                        bakiye -= elektrikfatura;
                                        Console.WriteLine(bakiye);
                                        goto islem;
                                        break;
                                    case 2:
                                    telefon:
                                        int telfatura = 500;
                                        Console.WriteLine("Telefon numarasını boşluksuz giriniz");
                                        string telno = Console.ReadLine();
                                        if (telno.Length == 11)
                                        {
                                            Console.WriteLine("Telefon numarası geçerlidir");
                                            bakiye -= telfatura;
                                            Console.WriteLine("Telefon faturanız ödenmiştir: "+bakiye);
                                            goto islem;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı girdiniz tekrar deneyin");
                                            goto telefon;
                                        }
                                        break;
                                    case 3:
                                        int gunlukucret = 100;
                                        int toplamucret = 0;
                                        Console.WriteLine("Gün sayısı giriniz");
                                        int gun = Convert.ToInt32(Console.ReadLine());
                                        if (gun < 30)
                                        {
                                            toplamucret = gun * gunlukucret;
                                            Console.WriteLine("Otopark ücretiniz: " + toplamucret);
                                            bakiye -= gun;
                                            Console.WriteLine("Ücret ödenmiştir:" + bakiye);

                                            goto islem;


                                        }
                                        else
                                        {
                                            toplamucret += gun * (gunlukucret / 10);
                                            Console.WriteLine("İndirimli ücretiniz: " + toplamucret);
                                            bakiye -= gun;
                                            Console.WriteLine("Ücret ödenmiştir:" +bakiye);
                                            goto islem;

                                        }
                                        break;
                                }

                                break;
                            case 2:
                                Console.WriteLine("Ödemek istediğiz vergiyi seçiniz");
                                Console.WriteLine("1- Araç vergisi");
                                Console.WriteLine("2- Ev vergisi");
                                int vergi = Convert.ToInt32(Console.ReadLine());
                                switch (vergi)
                                {
                                    case 1:
                                        Console.WriteLine("Araç değerinizi giriniz");
                                        int araba = Convert.ToInt32(Console.ReadLine());
                                        int arabavergi = 0;
                                        if (araba > 1000)
                                        {
                                            Console.WriteLine("Aracınız yüksek vergi segmentindedir");
                                            arabavergi += araba /2;
                                            Console.WriteLine("Vergi tutarı: " + arabavergi);
                                            if(arabavergi > bakiye)
                                            {
                                                Console.WriteLine("Bakiyenizi aşan tutar işlem yapılamıyor.");
                                                Console.WriteLine("Ana menü için 9'a basınız");
                                                Console.WriteLine("Krediler için 7'ye basınız");
                                                Console.WriteLine("Çıkış için 0'a basınız");
                                                int cikis = Convert.ToInt32(Console.ReadLine());

                                                if (cikis == 9)
                                                {
                                                    goto islem;
                                                }
                                                else if (cikis == 7)
                                                {
                                                    goto kredi;
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                bakiye -= arabavergi;

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Aracınız düşük vergi segmentindedir");

                                            arabavergi += araba / 10;
                                            Console.WriteLine("Vergi tutarı: " + arabavergi);
                                        bakiye -= arabavergi;

                                        }
                                        Console.WriteLine("Bakiye:" + bakiye);
                                        break;
                                    case 2:
                                        int evvergi = 0;
                                        Console.WriteLine("Ev değerini giriniz");
                                        int evfiyat = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ev m2 giriniz");
                                        int m2 = Convert.ToInt32(Console.ReadLine());
                                        if (evfiyat > 1000)
                                        {
                                            Console.WriteLine("Eviniz yüksek vergi segmentindedir");
                                            evvergi = evfiyat / m2;
                                        }
                                        else
                                        {
                                            evvergi = evfiyat / m2 / 2;
                                        }
                                        bakiye -= evvergi;
                                        Console.WriteLine("Vergi tutarı: " +evvergi);
                                        Console.WriteLine(bakiye);
                                        break;
                                }

                                break;

                        }


                        break;
                    case 6:
                        Console.WriteLine("Mevcut şifrenizi giriniz:");
                        string sifrekontrol = Console.ReadLine();

                        if(sifre== sifrekontrol)
                        {
                            Console.WriteLine("Yeni şifrenizi giriniz:");
                            string yenisifre = Console.ReadLine();
                            sifre = yenisifre;
                            goto islem;

                        }
                        else
                        {
                            Console.WriteLine("Hatalı şifre girdiniz tekrardan giriş yapınız");
                            goto login;
                        }
                        break;
                    case 7:
                        kredi:
                        Console.WriteLine("Kredi sayfasına hoşgeldiniz");
                        Console.WriteLine("Çekceğiniz kredi miktarını giriniz");
                        int kredimiktar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Vade giriniz:");
                        int vade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Statünüz:");
                        Console.WriteLine("1-Öğrenci");
                        Console.WriteLine("2-Çalışan:");
                        Console.WriteLine("3-Emekli:");

                        int statu = Convert.ToInt32(Console.ReadLine());

                        switch (statu)
                        {
                            case 1:
                                Console.WriteLine("Öğrenciler için kredi faizi indirimlidir.");
                                double ogrencikredi = kredimiktar + kredimiktar * 0.7;
                                Console.WriteLine("Geri ödemeniz: "+ogrencikredi);
                                bakiye += ogrencikredi;
                                Console.WriteLine("Bakiyeniz: " + bakiye);

                                double taksitogrenci = ogrencikredi / vade;
                                Console.WriteLine("Taksit tutarınız: "+ taksitogrenci);
                                goto islem;

                                break;
                            case 2:
                                double calisankredi = kredimiktar + kredimiktar;
                                Console.WriteLine("Geri ödemeniz: " + calisankredi);
                                bakiye += calisankredi;
                                Console.WriteLine("Bakiyeniz: " + bakiye);

                                double taksitcalisan = calisankredi / vade;
                                Console.WriteLine("Taksit tutarınız: " + taksitcalisan);
                                goto islem;


                                break;
                            case 3:
                                double emeklikredi = kredimiktar + kredimiktar*0.6;
                                Console.WriteLine("Geri ödemeniz: " + emeklikredi);
                                bakiye += emeklikredi;
                                Console.WriteLine("Bakiyeniz: " +bakiye);

                                double taksitemekli = emeklikredi / vade;
                                Console.WriteLine("Taksit tutarınız: " +taksitemekli );
                                goto islem;


                                break;
                        }


                        break;
                    default:
                        Console.WriteLine("Hatalı seçim  yeniden deneyiniz.");
                        goto islem;
                }

            }
            else
            {
                Console.WriteLine("Şifre hatalı yeniden deneyiniz");
                hak--;
                goto login;
            }
        }
        break;

    case 2:

        break;
}





























#region BANKAMATİK
//            /*   
//             *   25000 tl parası olacak 
//            Bir bankamatik düşünülerek tasarlanacak bir program  için 
//            Kartlı işlem    1
//            Kartsız işlem   2
//            //********Kartlı işlem bölümü
//            Şifre istenecek=> Şifre:ab18
//            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
//            //*******************Ana Menü 
//            Para Çekmek için    1
//            Para yatırmak için  2
//            Para Transferleri   3
//            Eğitim Ödemeleri    4
//            Ödemeler            5
//            Bilgi Güncelleme    6
//            //*********************Seçim 1************
//            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
//            Ana meüye dönmek için   9
//            Çıkmak için             0
//            //******************Seçim 2***********************
//            Kredi Kartına   1
//            Kendi Hesabınıza yatırmak için  2
//            Ana Menü        9
//            Çıkmak için     0
//            //------------------------------------
//            //----1
//            Kredi kardı için en az 12 haneli kart numarasını girsin
//            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
//            Ana Menü        9
//            Çıkmak için     0
//            //--------------------------
//            //---2
//            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
//            Ana Menü        9
//            Çıkmak için     0
//            //*****************************Seçim 3
//            Başka Hesaba EFT    1
//            Başka Hesaba Havale 2
//            //---------------------------------
//            //--1
//            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
//            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
//            Ana Menü        9
//            Çıkmak için     0
//            //-----------------------------
//            //---2
//            hesap için 11 haneli hesap numarası işlemler doğru ise
//            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
//            Ana Menü        9
//            Çıkmak için     0
//            //****************Seçim 4
//            Eğitim Ödemeleri sayfası arızalı
//            Ana Menü        9
//            Çıkmak için     0
//            //****************************Seçim 5
//            Elektrik Faturası       1
//            Telefon Faturası        2
//            İnternet faturası       3
//            Su Faturası             4
//            OGS Ödemeleri           5
//            //-----------------------------------------
//            //---1 => bütün faturala için aşağıdaki şart yeterli
//            fatura tutarı istenir, hesap uygun ise yatırılır değilse
//            Ana Menü        9
//            Çıkmak için     0
//            //-----------------------------------
//            //***************Seçim 6
//            Şifre değiştirmek için 1
//            Şifre değiştirme işlemi gerçekleştirilir
//            Ana Menü        9
//            Çıkmak için     0
//*/


#endregion