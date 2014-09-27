using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace calisma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ahmet Yeşil", "Deniz Derya", "Okan Kurum", "Victoria Dexter", "Murat Aslan", "Zeynep Demir", "Yasemin Er" };
            string[] adresler = { "2183 Sok. No: 13 Bayraklı/İzmir", "Irmak Apt. No:12/1 Gölcük/Kocaeli", "Güzelhan Cad. No:1 Bornova/İzmir", "Neville St Yorkshine Leeds/UK", "Filiz Apt. No:3/2 Merzifon/Amasya", "Ankara Cad. No:2 Beykoz/İstanbul", "1875/2 sok. no:7 Sincan/Ankara" };
            string[] tel_no = { "03224543242", "02142452523", "05033464396", "011323252", "05551114341", "02129992334", "05432389434" };
            string[] e_posta = { "ahmetyesil@yahoo.com", "dderya@mynet.com", "okankurum@gmail.com", "vdexter@gmail.com", "murataslan@mynet.com", "zeynepdemir@msn.com", "yaseminer@msn.com" };
            string[] uyruk = { "TC", "TC", "TC", "UK", "TC", "TC", "TC" };
            string[] d_yer = { "İzmir", "Bursa", "Antalya", "Leeds", "Amasya", "Erzurum", "Trabzon" };
            string[] d_tarih = { "13.11.1967", "12.01.1982", "01.09.1988", "20.12.1974", "19.09.1999", "24.03.1960", "23.04.1966" };
            string[] medeni_durum = { "E", "B", "B", "E", "B", "E", "E" };
            string[] cinsiyet = { "E", "K", "E", "K", "E", "K", "K" };
            string[] ogr_durum = { "H", "E", "E", "H", "E", "H", "H" };

            int[] bilgi_say = { 1, 1, 2, 0, 0, 1, 2 };
            string[] kira = { "E", "E", "E", "E", "H", "E", "H" };
            string[] il_bilgi = { "İzmir", "İstanbul", "İzmir", "İzmir", "İstanbul", "İzmir", "Ankara" };
            string[] ilce_bilgi = { "Bornova", "Tuzla", "Buca", "Evka-4", "Beykoz", "Menemen", "Sincan" };
            double[] fiyat_bilgi = { 400, 500, 300, 350, 0, 300, 0 };
            double[] metrekare_bilgi = { 120, 110, 90, 80, 100, 100, 130 };
            int[] yapimyili_bilgi = { 2000, 2008, 1998, 2003, 1980, 1990, 2004 };



            int[] ilanno = { 312, 244, 643, 145, 734, 431, 846, 519, 644, 926 };
            string[] satildiMi = { "H", "H", "H", "H", "H", "H", "H", "H", "H", "H" };
            string[] il = { "İzmir", "İzmir", "Muğla", "İstanbul", "Ankara", "Aydın", "Erzurum", "Mardin", "Adana", "Kayseri" };
            string[] ilçe = { "Bornova", "Bayraklı", "Fethiye", "Beşiktaş", "Çankaya", "Merkez", "İspir", "Merkez", "Seyhan", "Talas" };
            int[] fiyat = { 15000, 200000, 550000, 200000, 300000, 100000, 70000, 85000, 40000, 35000 };
            string[] yapıtipi = { "H", "H", "V", "M", "H", "H", "M", "H", "H", "H" };
            int[] m_kare = { 120, 125, 250, 90, 130, 120, 100, 130, 148, 160 };
            int[] yapım_yılı = { 2010, 2009, 2005, 2000, 2008, 2010, 2000, 2008, 2007, 2010 };
            string[] yapı_durum = { "S", "İ", "İ", "İ", "İ", "S", "İ", "İ", "İ", "S" };
            int[] bulundugu_kat = { 1, 7, 1, 2, 4, 1, 1, 2, 4, 7 };
            int[] oda_say = { 3, 4, 7, 2, 4, 3, 2, 3, 3, 4 };
            int[] banyo_say = { 1, 1, 2, 1, 2, 1, 1, 1, 1, 2 };
            string[] balkon = { "E", "E", "E", "H", "E", "E", "H", "E", "E", "E" };
            string[] kullanım_durum = { "B", "K", "M", "K", "B", "B", "M", "K", "M", "B" };
            int[] bina_kat_say = { 8, 10, 1, 2, 8, 10, 1, 5, 4, 15 };
            string[] bahçe = { "E", "E", "E", "E", "E", "E", "E", "H", "H", "E" };
            string[] ogr_uygunluk = { "H", "H", "H", "E", "H", "E", "H", "H", "H", "H" };
            string[] aciklama = { "Merkezde sıfır daire", "Manavkuyuda satılık lüks daire", "Deniz manzaralı süperlüks dubleks villa", "Üniversiteye yakın müstakil daire", "Ankara merkezde ve acil İhtiyaçtan satılıktır", "Aydın merkezde ulaşım hatlarına yakın sıfır daire", "Acil ihtiyaçtan satılık tek katlı müstakil daire", "Mardinin en güzel ve nezih bölgesinde Yay Sitelerinde", "Dairemiz Tokiden alınmadır. Aylık ödemeleri devam etmektedir.", "Maliyetine satacağım. Lütfen ciddi alıcılar arasın." };

            string[] ADSL = { "E", "E", "H", "E", "E", "H", "H", "H", "E", "E" };  // ic donanim elemanlari
            string[] asansor = { "E", "E", "H", "H", "E", "E", "H", "E", "E", "E" };
            string[] celik_kapi = { "E", "E", "E", "H", "E", "E", "E", "E", "E", "E" };
            string[] dusakabin = { "E", "E", "E", "E", "E", "E", "E", "E", "E", "E" };
            string[] isicam = { "E", "E", "E", "E", "E", "H", "E", "E", "E", "E" };
            string[] kartonpiyer = { "H", "H", "E", "H", "E", "H", "H", "E", "E", "E" };
            string[] laminant = { "E", "E", "E", "H", "E", "H", "H", "H", "E", "E" };
            string[] PVC = { "E", "E", "E", "H", "E", "E", "E", "E", "E", "E" };


            Tree agac = new Tree();
            int j = 0;
            for (int i = 0; i < 7; i++)
            {
                Musteri must = new Musteri();
                must.ad = isimler[i];
                must.adres = adresler[i];
                must.tel = tel_no[i];
                must.e_posta = e_posta[i];
                must.uyruk = uyruk[i];
                must.dogum_yer = d_yer[i];
                must.dogum_tar = d_tarih[i];
                must.medeni_durum = medeni_durum[i];
                must.cinsiyet = cinsiyet[i];
                must.ogr_mi = ogr_durum[i];

                for (int k = 0; k < bilgi_say[i]; k++)
                {
                    Bilgi bilgii = new Bilgi();
                    bilgii.kira_mı = kira[j];
                    bilgii.il = il_bilgi[j];
                    bilgii.ilçe = ilce_bilgi[j];
                    bilgii.fiyat = fiyat_bilgi[j];
                    bilgii.metrekare = metrekare_bilgi[j];
                    bilgii.yapim_yili = yapimyili_bilgi[j];
                    must.bilgiler.Add(bilgii);
                    j++;
                }
                agac.insert(must);
            }

            Hashtable emlak_hash = new Hashtable();
            Heap heap = new Heap();

            for (int i = 0; i < 10; i++)
            {
                Satilik_Bilgi emlak = new Satilik_Bilgi();
                emlak.ilanno = ilanno[i];
                emlak.satildi_mi = satildiMi[i];
                emlak.il = il[i];
                emlak.ilçe = ilçe[i];
                emlak.fiyat = fiyat[i];
                emlak.yapi_tipi = yapıtipi[i];
                emlak.metrekare = m_kare[i];
                emlak.yapim_yili = yapım_yılı[i];
                emlak.yapinin_durumu = yapı_durum[i];
                emlak.kat_no = bulundugu_kat[i];
                emlak.oda_say = oda_say[i];
                emlak.banyo_say = banyo_say[i];
                emlak.balkon = balkon[i];
                emlak.kullanim_durumu = kullanım_durum[i];
                emlak.bina_kat_say = bina_kat_say[i];
                emlak.bahçe_var_mi = bahçe[i];
                emlak.ogr_uygunluk = ogr_uygunluk[i];
                emlak.aciklama = aciklama[i];
                emlak.ic_donanim.Add(ADSL[i]);
                emlak.ic_donanim.Add(asansor[i]);
                emlak.ic_donanim.Add(celik_kapi[i]);
                emlak.ic_donanim.Add(dusakabin[i]);
                emlak.ic_donanim.Add(isicam[i]);
                emlak.ic_donanim.Add(kartonpiyer[i]);
                emlak.ic_donanim.Add(laminant[i]);
                emlak.ic_donanim.Add(PVC[i]);
                emlak.k = emlak.fiyat / emlak.metrekare;

                emlak_hash.Add(emlak.ilanno, emlak);   // oluşturulan emlak bilgisi hash tablosına ekleniyor...
                heap.ekle(emlak);                     //  oluşturulan emlak bilgisi heap e ekleniyor...
            }

            int secim, secim2;
            ana_menu();
            Console.Write("\n Lutfen seciminizi giriniz : ");
            secim = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
            while (secim < 4  &&  secim > 0)
            {
                switch (secim)
                {
                    case 1:
                        menu1();
                        Console.Write("\n Lutfen seciminizi giriniz : ");
                        secim2 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("\n");
                        switch (secim2)
                        {
                            case 1:
                                Musteri mus1 = new Musteri();
                                musteri_kayit_ve_guncelleme(mus1, 0);
                                agac.insert(mus1);
                                Console.WriteLine("\n\n\t" + mus1.ad + " adli kullanicinin kaydi başariyla gerceklestirilmistir...\n\n");
                                break;
                            case 2:
                                Console.Write("Bilgilerini guncellemek istediginiz kullanıcının \n\n\tAdini ve Soyadini giriniz :");
                                string guncellenecek = Console.ReadLine();
                                Musteri mus2 = new Musteri();
                                mus2 = agac.ara(agac.getRoot(), guncellenecek);
                                if (mus2 != null)
                                {
                                    musteri_kayit_ve_guncelleme(mus2, 1);
                                    Console.WriteLine(guncellenecek + " adli kullanicinin bilgileri basariyla guncellenmistir...\n\n");
                                }
                                else
                                    Console.WriteLine("  Sistemde " + guncellenecek + " adinda bir kullanici mevcut degildir!\n\n\a");
                                break;
                            case 3:
                                Console.Write("Sistemden bilgilerini silmek istediginiz kullanıcının \n\n\tAdini ve Soyadini giriniz :");
                                string silinecek = Console.ReadLine();
                                Musteri mus3 = new Musteri();
                                mus3 = agac.ara(agac.getRoot(), silinecek);
                                if (mus3 != null)
                                {
                                    agac.silme(silinecek);
                                    Console.WriteLine( silinecek + " adli kullanici sistemden basariyla silinmistir...\n\n");
                                }
                                else
                                    Console.WriteLine("  Sistemde " + silinecek + " adinda bir kullanici mevcut degildir!\n\n\a");
                                break;
                            case 4:
                                Console.Write("\tAramanizi hangi ilce icin gerceklestireceksiniz : "); string ilce = Console.ReadLine();
                                Console.Write("  Alt fiyat siniri giriniz : "); int alt = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Ust fiyat siniri giriniz : "); int ust = Convert.ToInt32(Console.ReadLine());

                                Satilik_Bilgi a = new Satilik_Bilgi();
                                IDictionaryEnumerator enumerator = emlak_hash.GetEnumerator();
                                char ch='f';
                                while (enumerator.MoveNext())
                                {
                                    a = (Satilik_Bilgi)emlak_hash[enumerator.Key];//casting işlemi ile hash table içindeki nesnenin elemanlarına erişebiliyoruz.Hash table'ı sırayla dolaşıyor.
                                    if (a.ilçe == ilce && a.fiyat < ust && a.fiyat > alt)
                                    {
                                        emlak_bilgi_listele(a);
                                        ch='t';
                                    }
                                }
                                if (ch == 'f')
                                    Console.WriteLine("Aradiginiz Kriterlere uygun hicbir ev bulunmamaktadir!\n\n\a");
                                break;
                            case 5:
                                Console.Write("Aramanizi hangi il icin gerceklestireceksiniz :");
                                string aranan_il = Console.ReadLine();

                                Satilik_Bilgi a2 = new Satilik_Bilgi();
                                IDictionaryEnumerator enumerator2 = emlak_hash.GetEnumerator();// bu ne işe yarıyor

                                while (enumerator2.MoveNext())
                                {
                                    a2 = (Satilik_Bilgi)emlak_hash[enumerator2.Key];//casting işlemi ile hash table içindeki nesnenin elemanlarına erişebiliyoruz.Hash table'ı sırayla dolaşıyor.
                                    if (a2.il == aranan_il && a2.kat_no > 1 && a2.kat_no != a2.bina_kat_say)
                                        emlak_bilgi_listele(a2);
                                }
                                break;
                            case 6:
                                Console.WriteLine("\n\n Bu secenekte Hash Tablosunda bulunan elemanlar sirayla dolasilacak.\n Dolasma esnasinda eğer musteri listelenmekte olan emlağı almak isterse \n satis islemi gerceklestirilir.");
                                Musteri m = new Musteri();
                                Satilik_Bilgi a3 = new Satilik_Bilgi();
                                IDictionaryEnumerator enumerator3 = emlak_hash.GetEnumerator();
                                
                                Console.Write("\n\tKullanici adi : "); string girilen_ad = Console.ReadLine();
                                m = agac.ara(agac.getRoot(), girilen_ad);
                                
                                if (m != null)
                                {
                                    Console.WriteLine("\nEmlaklar listeleniyor...\n\n");
                                    char sorgu = 'h';
                                    while (enumerator3.MoveNext() &&  ( sorgu == 'h' || sorgu == 'H' ) )
                                    {
                                        a3 = (Satilik_Bilgi)emlak_hash[enumerator3.Key];//casting işlemi ile hash table içindeki nesnenin elemanlarına erişebiliyoruz.Hash table'ı sırayla dolaşıyor.
                                        emlak_bilgi_listele(a3);
                                        Console.Write(a3.ilanno + " No'lu ilana sahip listelenen emlağı almak istiyor musunuz ( E / H )? : ");
                                        sorgu = Convert.ToChar(Console.ReadLine());
                                        if (sorgu == 'e' || sorgu == 'E')
                                        {
                                            m.satin_alinanlar.Add(a3.ilanno);
                                            emlak_hash.Remove(a3.ilanno);
                                            Console.WriteLine( "\n\t" + a3.ilanno + " ilan nuumarasina sahip ev " + m.ad + " adli kisi tarafindan\n   satin alinarak, sistem bilgilerine eklenmistir...\n\n");
                                            break;
                                        }
                                    }
                                }
                                else
                                    Console.WriteLine("\n\t\t\tGecersiz kullanici adi! \n\n\a");
                                
                                break;

                            case 7:
                                Musteri m1 = new Musteri();
                                Console.Write("\n\tKullanici adi : "); string k_ad = Console.ReadLine();
                                m1 = agac.ara(agac.getRoot(), k_ad);
                                if (m1 != null)
                                {
                                    Console.Write("Almak istediginiz emlagin ilan numarasini giriniz :");
                                    int girilen_no = Convert.ToInt32(Console.ReadLine());
                                    Satilik_Bilgi a4 = new Satilik_Bilgi();
                                    IDictionaryEnumerator enumerator4 = emlak_hash.GetEnumerator();
                                    int kont = 0;
                                    while (enumerator4.MoveNext())
                                    {
                                        a = (Satilik_Bilgi)emlak_hash[enumerator4.Key];//casting işlemi ile hash table içindeki nesnenin elemanlarına erişebiliyoruz.Hash table'ı sırayla dolaşıyor.
                                        if (a4.ilanno == girilen_no)
                                        {
                                            m1.satin_alinanlar.Add(a4.ilanno);
                                            heap.aradansil(a4.k);
                                            emlak_hash.Remove(a4.ilanno);
                                            Console.WriteLine("Satis islemleri basariyla gerceklestirilmistir...");
                                            kont = 1;
                                        }
                                    }
                                    if (kont != 1)
                                        Console.WriteLine("Girmis oldugunuz ilan numarasina uygun bir emlak bulunamamistir!\n\n");
                                }
                                else
                                    Console.WriteLine("  Sistemde " + k_ad + " adinda bir kullanici mevcut degildir!\n\n\a");
                                break;
                            case 8:
                                Musteri m2 = new Musteri();
                                Console.Write("\n\tKullanici adi : "); string kul_ad = Console.ReadLine();
                                m2 = agac.ara(agac.getRoot(), kul_ad);
                                if (m2 != null)
                                {
                                    Console.Write("Yatırım derecesi en iyi olan kac tane ev almak isityorsunuz :");
                                    int n = Convert.ToInt32(Console.ReadLine());

                                    if (emlak_hash.Count >= n)
                                    {
                                        for (int y = 0; y < n; y++)
                                        {
                                            Satilik_Bilgi satilan = new Satilik_Bilgi();
                                            satilan = heap.sil();
                                            m2.satin_alinanlar.Add(satilan.ilanno);
                                            emlak_hash.Remove(satilan.ilanno);
                                            Console.WriteLine(satilan.ilanno + " ilan numarasina sahip emlak satilmistir. ( k=" + satilan.k + " )\n\n");
                                        }
                                    }
                                    else
                                        Console.WriteLine("\n\tGirmis oldugunuz sayida emlak bulunmamaktadir!\n\n");
                                }
                                else
                                    Console.WriteLine("  Sistemde " + kul_ad + " adinda bir kullanici mevcut degildir!\n\n\a");
                                    break;
                            case 9:
                                double toplam = 0; int say = 0;
                                Satilik_Bilgi a5 = new Satilik_Bilgi();
                                IDictionaryEnumerator enumerator5 = emlak_hash.GetEnumerator();

                                while (enumerator5.MoveNext())
                                {
                                    a5 = (Satilik_Bilgi)emlak_hash[enumerator5.Key];//casting işlemi ile hash table içindeki nesnenin elemanlarına erişebiliyoruz.Hash table'ı sırayla dolaşıyor.
                                    toplam += a5.fiyat; say++;
                                }
                                Console.WriteLine("Butun ilcelerdeki ogrenciye uygun konutlarin ort fiyati = " + (float)toplam / say + " TL 'dir");
                                break;
                        }
                        break;
                    case 2:
                        menu2();
                        Console.Write("\n Lutfen seciminizi giriniz : ");
                        secim2 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("\n");
                        switch (secim2)
                        {
                            case 1:
                                Satilik_Bilgi yeni_emlak = new Satilik_Bilgi();
                                emlak_kayit_ve_guncelleme(yeni_emlak, 0);
                                emlak_hash.Add(yeni_emlak.ilanno, yeni_emlak);
                                heap.ekle(yeni_emlak);
                                Console.WriteLine( yeni_emlak.ilanno + " ilan numarasina sahip konut sisteme basariyla kaydedilmistir...\n\n");
                                break;
                            case 2:
                                Console.Write("Bilgilerini guncellemek istediginiz emlagin ilan numarasini giriniz :");
                                int ilanNo = Convert.ToInt32(Console.ReadLine());
                                if (emlak_hash[ilanNo] != null)
                                {
                                    Satilik_Bilgi s = new Satilik_Bilgi();
                                    s = (Satilik_Bilgi)emlak_hash[ilanNo];
                                    heap.aradansil(s.k);
                                    emlak_kayit_ve_guncelleme((Satilik_Bilgi)emlak_hash[ilanNo], 1);
                                    heap.ekle(s);
                                    Console.WriteLine("\n\n\tGuncelleme islemleri basariyla tamamlanmistir...\n\n");
                                }
                                else
                                    Console.WriteLine("\a\n\n\tAradiginiz ilan koduna uygun emlak bilgisi mevcut degildir!\n\n");
                                break;
                            case 3:
                                Console.Write("Bilgilerini silmek istediginiz emlagin ilan numarasini giriniz :");
                                int silinecek = Convert.ToInt32(Console.ReadLine());
                                if (emlak_hash[silinecek] != null)
                                {
                                    Satilik_Bilgi s = new Satilik_Bilgi();
                                    s = (Satilik_Bilgi)emlak_hash[silinecek];
                                    emlak_hash.Remove(silinecek);
                                    heap.aradansil(s.k);
                                    Console.WriteLine(silinecek + " no'lu emlak sistemden basariyla silinmistir!");
                                }
                                else
                                    Console.WriteLine(silinecek + "\a\n\n\t no'lu emlak sistem kayitlarinda bulunamamistir!\n\n");
                                break;
                        }
                        break;
                    case 3:
                        menu3();
                        Console.Write("\n Lutfen seciminizi giriniz : ");
                        secim2 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("\n");
                        switch (secim2)
                        {
                            case 1:
                                Console.Write("Bilgilerini görmek istediginiz kullanicinin adini giriniz : ");
                                string aranan = Console.ReadLine();
                                Musteri kullanici = new Musteri();
                                kullanici = agac.ara(agac.getRoot(), aranan);
                                if (kullanici != null)
                                    kullanici_bilgi_listele(kullanici);
                                else
                                    Console.WriteLine("\n  Sistemde " + aranan + " adinda bir kullanici mevcut degildir!\n\n\a");
                                break;
                            case 2:
                                int o = agac.ogr_top_oturulan(agac.getRoot(),1), ogr_sayisi = agac.ogr_top_oturulan(agac.getRoot(),0);
                                if (ogr_sayisi != 0)
                                {
                                    Console.WriteLine(" Ogrencilerin oturdugu top ev sayisi = " + o + "\n Toplam Ogr say                      = " + ogr_sayisi);
                                    Console.WriteLine("\n\t Ortalama = " + (float)o / ogr_sayisi + "\n\n");
                                }
                                else
                                    Console.WriteLine("sistemde kayıtlı hicbir ogrenci bulunmamaktadir!\n\n\a");
                                
                                break;
                            case 3:
                                Console.WriteLine("\n  Agacın InOrder Dolasılması : ");
                                agac.inOrder(agac.getRoot());
                                Console.WriteLine("\n  Agacın PreOrder Dolasılması : ");
                                agac.preOrder(agac.getRoot());
                                Console.WriteLine("\n  Agacın PostOrder Dolasılması : ");
                                agac.postOrder(agac.getRoot());
                                Console.WriteLine();

                                int top_eleman = agac.eleman_say(agac.getRoot(), -1);// top_dugum_say hesaplaniyor
                                float top_derinlik = agac.derinlik_toplami(agac.getRoot(), -1); // dugumlerin derinlikleri toplami hesaplaniyor.
                                Console.WriteLine("\nAgactaki toplam eleman sayisi : " + top_eleman + "\n");
                                Console.WriteLine("Agactaki max duzey sayisi (derinligi) : " + agac.max_duzey(agac.getRoot(), -1) + "\n");
                                Console.WriteLine("Agactaki dugumlerin derinlik ortalaması : " + (float)(top_derinlik / top_eleman) + "\n");

                                agac.düzeyListele(agac.getRoot(), -1);
                                break;
                        }
                        break;
                }
                ana_menu();
                Console.Write("\n Lutfen seciminizi giriniz : ");
                secim = Convert.ToInt32(Console.ReadLine());
            }
        }

        class Musteri               // musteri dugumlerinin olusturulmasi
        {
            public string ad;
            public string adres;
            public string tel;
            public string e_posta;
            public string uyruk;
            public string dogum_yer;
            public string dogum_tar;
            public string medeni_durum;
            public string cinsiyet;
            public string ogr_mi;
            public ArrayList bilgiler = new ArrayList();
            public ArrayList satin_alinanlar = new ArrayList();
            public Musteri leftChild;
            public Musteri rightChild;
            public void displayNode() { Console.WriteLine("\t" + ad ); }
        }

        class Bilgi
        {
            public string kira_mı;
            public string il;
            public string ilçe;
            public double fiyat;
            public double metrekare;
            public int yapim_yili;
        }

        class Satilik_Bilgi
        {
            public int ilanno;
            public string satildi_mi;
            public string il;
            public string ilçe;
            public double fiyat;
            public string yapi_tipi;
            public double metrekare;
            public int yapim_yili;
            public string yapinin_durumu;
            public int kat_no;
            public int oda_say;
            public int banyo_say;
            public string balkon;
            public string kullanim_durumu;
            public int bina_kat_say;
            public string bahçe_var_mi;
            public string ogr_uygunluk;
            public string aciklama;
       	    public double k;
            public ArrayList ic_donanim = new ArrayList();
        }

        class Heap
        {
            ArrayList dizi = new ArrayList();
            public void ekle(Satilik_Bilgi yeni)
            {
                Satilik_Bilgi newNode = new Satilik_Bilgi();
                newNode = yeni;
                dizi.Add(newNode);
                trickleup(dizi.Count - 1);
            }
            public void trickleup(int i)//bu fonksiyon ne işe yarıyor
            {
                int parent = 0;
                if (i != 0)
                    parent = (i - 1) / 2;
                Satilik_Bilgi dip = (Satilik_Bilgi)dizi[i];
                Satilik_Bilgi bas = (Satilik_Bilgi)dizi[parent];

                while (i > 0 && bas.k > dip.k)
                {
                    dizi[i] = dizi[parent];
                    i = parent;
                    parent = (parent - 1) / 2;
                    bas = (Satilik_Bilgi)dizi[parent];
                }
                dizi[i] = dip;
            }
            public Satilik_Bilgi sil()
            {
                Satilik_Bilgi sil = new Satilik_Bilgi();
                sil = (Satilik_Bilgi)dizi[0];
                dizi[0] = dizi[dizi.Count - 1];
                dizi.RemoveAt(dizi.Count - 1);
                if (dizi.Count != 0)
                    trickledown(0);
                return sil;
            }
            public void trickledown(int i)// bu ne işe yarıyor
            {
                int min;
                Satilik_Bilgi top = (Satilik_Bilgi)dizi[i];
                Satilik_Bilgi soll = new Satilik_Bilgi();
                Satilik_Bilgi sagg = new Satilik_Bilgi();
                while (i < (dizi.Count - 1) / 2)
                {
                    int sol = 2 * i + 1;
                    int sağ = sol + 1;
                    soll = (Satilik_Bilgi)dizi[sol];
                    if (sağ < dizi.Count)
                        sagg = (Satilik_Bilgi)dizi[sağ];
                    if (sağ < dizi.Count && soll.k > sagg.k)
                        min = sağ;
                    else
                        min = sol;
                    Satilik_Bilgi minn = (Satilik_Bilgi)dizi[min];
                    if (top.k < minn.k)
                        break;
                    dizi[i] = dizi[min];
                    dizi[min] = top;
                    i = min;
                }
            }
            public void aradansil(double k)
            {
                Satilik_Bilgi s = new Satilik_Bilgi();
                int i;
                for (i = 0; i < dizi.Count; i++)
                {
                    s = (Satilik_Bilgi)dizi[i];
                    if (s.k == k)
                        break;
                }
                dizi.RemoveAt(i);
            }
        }
	
        class Tree
        {
            private Musteri root;
            public int top = 0;
            public int düzey;
            public int el_say = 0;
            public int ogr_say = 0;
            public int max = 0;
            public float derinlik_top = 0;

            public Tree() { root = null; }

            public Musteri getRoot()
            { return root; }

            public void preOrder(Musteri localRoot)     // Agacın preOrder Dolasılması
            {
                if (localRoot != null)
                {
                    localRoot.displayNode();
                    preOrder(localRoot.leftChild);
                    preOrder(localRoot.rightChild);
                }
            }

            public void inOrder(Musteri localRoot)      // Agacın inOrder Dolasılması
            {
                if (localRoot != null)
                {
                    inOrder(localRoot.leftChild);
                    localRoot.displayNode();
                    inOrder(localRoot.rightChild);
                }
            }

            public void postOrder(Musteri localRoot)    // Agacın postOrder Dolasılması
            {
                if (localRoot != null)
                {
                    postOrder(localRoot.leftChild);
                    postOrder(localRoot.rightChild);
                    localRoot.displayNode();
                }
            }

            public void insert(Musteri yeni)           // Agaca bir dügüm eklemeyi saglayan metot
            {
                Musteri newNode = new Musteri();
                newNode = yeni;
                if (root == null)
                    root = newNode;
                else
                {
                    Musteri current = root;
                    Musteri parent;
                    while (true)
                    {
                        parent = current;
                        if (String.Compare(yeni.ad, current.ad) == -1)
                        {
                            current = current.leftChild;
                            if (current == null)
                            {
                                parent.leftChild = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.rightChild;
                            if (current == null)
                            {
                                parent.rightChild = newNode;
                                return;
                            }
                        }
                    } 
                } 
            } 

            public void düzeyListele(Musteri etkin, int d)
            {
                if (etkin != null)
                {
                    d = d + 1;
                    düzeyListele(etkin.leftChild, d);
                    Console.WriteLine(" " + etkin.ad + " " + d + ". düzeyde");
                    düzeyListele(etkin.rightChild, d);
                }
            }

            public Musteri ara(Musteri etkin, string ad)
            {
                if (etkin == null) return null;
                if (String.Compare(etkin.ad, ad) == 1)
                    return ara(etkin.leftChild, ad);
                else if (String.Compare(etkin.ad, ad) == -1)
                    return ara(etkin.rightChild, ad);
                else
                    return etkin;
            }

            public int ogr_top_oturulan(Musteri localRoot,int s)    // Agacın postOrder Dolasılması
            {

                if (localRoot == root)
                {
                    top = 0;
                    ogr_say = 0;
                }
                if (localRoot != null)
                {
                    if (localRoot.ogr_mi == "E")
                    {
                        top += localRoot.bilgiler.Count;
                        ogr_say++;
                    }
                    ogr_top_oturulan(localRoot.leftChild,s);
                    ogr_top_oturulan(localRoot.rightChild,s);
                }
                if (s == 0)
                    return ogr_say;
                else
                    return top;
            }

            public int eleman_say(Musteri localRoot,int d) // agactaki toplam dugum sayisini bulup donduren metod
            {
                if (localRoot == root)
                    el_say = 0;
                if (localRoot != null)
                {
                    el_say++;
                    eleman_say(localRoot.leftChild,d);
                    eleman_say(localRoot.rightChild,d);
                }
                return el_say;
            }

            public int max_duzey(Musteri etkin, int d) // max duzeyi bulup donduren metod
            {
                if (etkin == root)
                    max = 0;
                if (etkin != null)
                {
                    d = d + 1;
                    if (d > max)
                        max = d;
                    max_duzey(etkin.leftChild, d);
                    max_duzey(etkin.rightChild, d);
                }
                return max;
            }
            public float derinlik_toplami(Musteri etkin, int d)  //agaçtaki butun elemanlarin derinlikleriin toplamini bulup donduren metod
            {
                if (etkin == root)
                    derinlik_top = 0;
                if (etkin != null)
                {
                    d = d + 1;
                    derinlik_top += d;
                    derinlik_toplami(etkin.leftChild, d);
                    derinlik_toplami(etkin.rightChild, d);
                }
                return derinlik_top;
            }

            public bool silme(string sil)
            {
                Musteri önceki = root;
                Musteri gecici = root;
                bool sol = true;
                while (gecici.ad != sil)
                {
                    önceki = gecici;
                    if (String.Compare(sil, gecici.ad) == -1)
                    {
                        sol = true;
                        gecici = gecici.leftChild;
                    }
                    else
                    {
                        sol = false;
                        gecici = gecici.rightChild;
                    }
                    if (gecici == null)
                        return false;
                }
                if (gecici.leftChild == null && gecici.rightChild == null)
                {
                    if (gecici == root)
                        root = null;
                    else if (sol)
                        önceki.leftChild = null;
                    else
                        önceki.rightChild = null;
                }
                else if (gecici.rightChild == null)
                    if (gecici == root)
                        root = gecici.leftChild;
                    else if (sol)
                        önceki.leftChild = gecici.leftChild;
                    else
                        önceki.rightChild = gecici.leftChild;
                else if (gecici.leftChild == null)
                    if (gecici == root)
                        root = gecici.rightChild;
                    else if (sol)
                        önceki.leftChild = gecici.rightChild;
                    else
                        önceki.rightChild = gecici.rightChild;
                else
                {
                    Musteri successor = getSuccessor(gecici);
                    if (gecici == root)
                        root = successor;
                    else if (sol)
                        önceki.leftChild = successor;
                    else
                        önceki.rightChild = successor;
                    // connect successor to current’s left child
                    successor.leftChild = gecici.leftChild;
                }
                return true;
            }
            private Musteri getSuccessor(Musteri delNode)//bu ne işe yarıyor
            {
                Musteri successorParent = delNode;
                Musteri successor = delNode;
                Musteri current = delNode.rightChild; // go to right child
                while (current != null) // until no more
                { // left children,
                    successorParent = successor;
                    successor = current;
                    current = current.leftChild; // go to left child
                }
                // if successor not
                if (successor != delNode.rightChild) // right child,
                { // make connections
                    successorParent.leftChild = successor.rightChild;
                    successor.rightChild = delNode.rightChild;
                }
                return successor;
            }
        }

        static void ana_menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\t\t***********  ANA MENU  *************");
            Console.WriteLine("\t\t 1. Satilik konut arayan kisiler");
            Console.WriteLine("\t\t 2. Emlak Sahipleri");
            Console.WriteLine("\t\t 3. Agac Islemleri");
            Console.WriteLine("\t\t 4. Cikis");
            Console.WriteLine("\t\t************************************");
            Console.ResetColor();
        }

        static void menu1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t************************  MENU 1  ****************************");
            Console.WriteLine("\t1. Yeni kullanici kaydi");
            Console.WriteLine("\t2. Kullanici bilgi guncelleme");
            Console.WriteLine("\t3. Kullanici kaydi silme");
            Console.WriteLine("\t4. Bir ilcede belirlenen fiyat araligindaki konutlari listeleme");
            Console.WriteLine("\t5. Herhangi bir ildeki arakatlarda ogrenciye uygun tüm konutların\t\t   listelenmesi (Hash Table dolaşılarak)");
            Console.WriteLine("\t6. Satin alma islemleri( Hash Table dolaşilarak)");
            Console.WriteLine("\t7. Ilan No ile ev alinmasi");
            Console.WriteLine("\t8. En iyi n adet konutun alinmasi");
            Console.WriteLine("\t9. Ogr ye uygun konutlarin fiyat ortalamsinin bulunmasi");
            Console.ResetColor();
        }

        static void menu2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t*******  MENU 2  ****************");
            Console.WriteLine("\t1. Yeni satilik konut ilanı verme");
            Console.WriteLine("\t2. Ilan bilgisi guncelleme");
            Console.WriteLine("\t3. Kayitli ilan bilgisi silme\n");
            Console.ResetColor();
        }

        static void menu3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t**************  MENU 3  *******************");
            Console.WriteLine("\t1. Kisi bilgileri listeleme");
            Console.WriteLine("\t2. Ogrencilerin oturdugu ortalama ev sayisi");
            Console.WriteLine("\t3. Butun kisileri listeleme");
            Console.ResetColor();
        }

        static void musteri_kayit_ve_guncelleme(Musteri mus, int n)
        {

            Console.WriteLine(" Musterinin\n");
            if (n == 0)
                Console.Write("\t\t Adi ve Soyadi: "); mus.ad = Console.ReadLine();
            Console.Write("\t\tAdresi .............: "); mus.adres = Console.ReadLine();
            Console.Write("\t\tTelefon No .........: "); mus.tel = Console.ReadLine();
            Console.Write("\t\tE-Posta : ..........: "); mus.e_posta = Console.ReadLine();
            Console.Write("\t\tUyrugu .............: "); mus.uyruk = Console.ReadLine();
            Console.Write("\t\tDogum yeri .........: "); mus.dogum_yer = Console.ReadLine();
            Console.Write("\t\tDogum tarihi .......: "); mus.dogum_tar = Console.ReadLine();
            Console.Write("\t\tMedeni Durumu ......: "); mus.medeni_durum = Console.ReadLine();
            Console.Write("\t\tCinsiyet : "); mus.cinsiyet = Console.ReadLine();
            Console.Write("\t\tOgrenci misiniz(E/H): "); mus.ogr_mi = Console.ReadLine();
            if (n != 0)
                Console.WriteLine("Sisteme daha önce oturmus oldugunuz evlerden kac tane daha eklemek istiyorsunuz :");
            else
                Console.Write("Daha once kac farklı evde oturdunuz? : ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i > 0)  // daha once oturulan evlerin bilgileri kullanicidan aliniyor.
            {
                Console.WriteLine("Sırasiyla daha once oturdugunuz ev(ler)in bilgilerini giriniz:");
                for (int k = 1; k <= i; k++)
                {
                    Bilgi b=new Bilgi();
                    Console.WriteLine("\n\tOturdugunuz "+ k +". ev");
                    Console.Write(" Kira miydi (E/H) : "); b.kira_mı = Console.ReadLine();
                    Console.Write(" Bulunduğu İl ....: "); b.il = Console.ReadLine();
                    Console.Write(" Bulunduğu İlce ..: "); b.ilçe = Console.ReadLine();
                    Console.Write(" Fiyat : .........: "); b.fiyat = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Kaç metrekare ...: "); b.metrekare = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Yapım yılı ......: "); b.yapim_yili = Convert.ToInt16(Console.ReadLine());
                    mus.bilgiler.Add(b);
                }
            }
        }

        static void emlak_kayit_ve_guncelleme(Satilik_Bilgi emlak,int g)
        {
            string str;
            Console.WriteLine("YENI Emlak Bilgilerini Sirayla Giriniz ");
            if (g == 0)
             { Console.Write("\t\tIlan No : "); emlak.ilanno = Convert.ToInt32(Console.ReadLine()); }
            Console.Write("\tIl ...................................: "); emlak.il = Console.ReadLine();
            Console.Write("\tIlce .................................: "); emlak.ilçe = Console.ReadLine();
            Console.Write("\tFiyat ................................: "); emlak.fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tYapi Tipi (D:Daire/M:Mustakil/V:Villa): "); emlak.yapi_tipi = Console.ReadLine();
            Console.Write("\tMetrekare ............................: "); emlak.metrekare = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tYapim Yili ...........................: "); emlak.yapim_yili = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tYapinin Durumu (İ:İkinci El / S:Sifir): "); emlak.yapinin_durumu = Console.ReadLine();
            Console.Write("\tBulundugu Kat ........................: "); emlak.kat_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tOda Sayisi ...........................: "); emlak.oda_say = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tBanyo Sayisi .........................: "); emlak.banyo_say = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tBalkon (E:Var / H:Yok) ...............: "); emlak.balkon = Console.ReadLine();
            Console.Write("\tKullanim Durumu (K:Kiraci/ M:Mülk Sahibi Oturuyor/ B:Boş): "); emlak.kullanim_durumu = Console.ReadLine();
            Console.Write("\tBinadaki Kat Sayisi ..................: "); emlak.bina_kat_say = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tBahçe (E:Var / H:Yok) ................: "); emlak.bahçe_var_mi = Console.ReadLine();
            Console.Write("\tOgrenciye Uygunluk (E:Var / H:Yok) ...: "); emlak.ogr_uygunluk = Console.ReadLine();
            Console.WriteLine("\t\tSirayla ic donanim bilgilerini giriniz :");
            emlak.ic_donanim.Clear();
            Console.Write("\t\tADSL (E:Var / H:Yok) ...............: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\t\tAsansor (E:Var / H:Yok) ............: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\t\tCelik Kapi (E:Var / H:Yok) .........: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\t\tDusakabin (E:Var / H:Yok) ..........: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\t\tIsicam (E:Var / H:Yok) .............: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\t\tKartonpiyer (E:Var / H:Yok) ........: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\t\tLaminant (E:Var / H:Yok) ...........: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\t\tPVC Dograma (E:Var / H:Yok) ........: "); str = Console.ReadLine(); emlak.ic_donanim.Add(str);
            Console.Write("\tAciklama : "); emlak.aciklama = Console.ReadLine();
            emlak.satildi_mi = "H";
            emlak.k = emlak.fiyat / emlak.metrekare;
        }

        static void kullanici_bilgi_listele(Musteri etkin)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tMusteri kayitlarina erisildi.Bilgileri...");
            Console.WriteLine("\n  Musterinin\n");
            Console.WriteLine("\t\tAdi ve Soyadi: " + etkin.ad);
            Console.WriteLine("\t\tAdresi       : " + etkin.adres);
            Console.WriteLine("\t\tTelefon No   : " + etkin.tel);
            Console.WriteLine("\t\tE-Posta      : " + etkin.e_posta);
            Console.WriteLine("\t\tUyrugu       : " + etkin.uyruk);
            Console.WriteLine("\t\tDogum yeri   : " + etkin.dogum_yer);
            Console.WriteLine("\t\tDogum tarihi : " + etkin.dogum_tar);
            Console.WriteLine("\t\tMedeni Durumu: " + etkin.medeni_durum);
            Console.WriteLine("\t\tCinsiyet     : " + etkin.cinsiyet);
            Console.WriteLine("\t\tOgrenci mi?  : " + etkin.ogr_mi);
            if (etkin.bilgiler.Count > 0)
            {
                Console.WriteLine("\n\tKullanicinin daha once oturmus oldugu -" + etkin.bilgiler.Count + "- eve ait bilgiye ulasilmistir.\n\n Bu evlere ait bilgiler asagida listelenmistir.\n");
                for (int s = 0; s < etkin.bilgiler.Count; s++)
                {
                    Bilgi b = new Bilgi();
                    b = (Bilgi)etkin.bilgiler[s];
                    Console.WriteLine("\t" + (s + 1) + ". Ev hakkında bilgiler");
                    Console.WriteLine("\t\tKira miydi?  : " + b.kira_mı);
                    Console.WriteLine("\t\tIl           : " + b.il);
                    Console.WriteLine("\t\tIlce         : " + b.ilçe);
                    Console.WriteLine("\t\tFiyat        : " + b.fiyat);
                    Console.WriteLine("\t\tMetrekare    : " + b.metrekare);
                    Console.WriteLine("\t\tYapim Yili   : " + b.yapim_yili + "\n\n");
                }
            }
            else
                Console.WriteLine("Sistemde kullanicinin daha once oturdugu evlere dair hicbir bilgi bulunmamaktadir!");
            Console.ResetColor();
        }

        static void emlak_bilgi_listele(Satilik_Bilgi a3)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tIlan No : " + a3.ilanno);
            Console.WriteLine("\tIl ...................................: " + a3.il);
            Console.WriteLine("\tIlce .................................: " + a3.ilçe);
            Console.WriteLine("\tFiyat ................................: " + a3.fiyat);
            Console.WriteLine("\tYapi Tipi (D:Daire/M:Mustakil/V:Villa): " + a3.yapi_tipi);
            Console.WriteLine("\tMetrekare ............................: " + a3.metrekare);
            Console.WriteLine("\tYapim Yili ...........................: " + a3.yapim_yili);
            Console.WriteLine("\tYapinin Durumu (İ:İkinci El / S:Sifir): " + a3.yapinin_durumu);
            Console.WriteLine("\tBulundugu Kat ........................: " + a3.kat_no);
            Console.WriteLine("\tOda Sayisi ...........................: " + a3.oda_say);
            Console.WriteLine("\tBanyo Sayisi .........................: " + a3.banyo_say);
            Console.WriteLine("\tBalkon (E:Var / H:Yok) ...............: " + a3.balkon);
            Console.WriteLine("\tKullanim Durumu (K:Kiraci/ M:Mülk Sahibi Oturuyor/ B:Boş): " + a3.kullanim_durumu);
            Console.WriteLine("\tBinadaki Kat Sayisi ..................: " + a3.bina_kat_say);
            Console.WriteLine("\tBahçe (E:Var / H:Yok) ................: " + a3.bahçe_var_mi);
            Console.WriteLine("\tOgrenciye Uygunluk (E:Var / H:Yok) ...: " + a3.ogr_uygunluk);
            Console.WriteLine("\n\t\t---Binanın ic donanim bilgileri ---");
            Console.WriteLine("\t\tADSL (E:Var / H:Yok) ...............: " + a3.ic_donanim[0]);
            Console.WriteLine("\t\tAsansor (E:Var / H:Yok) ............: " + a3.ic_donanim[1]);
            Console.WriteLine("\t\tCelik Kapi (E:Var / H:Yok) .........: " + a3.ic_donanim[2]);
            Console.WriteLine("\t\tDusakabin (E:Var / H:Yok) ..........: " + a3.ic_donanim[3]);
            Console.WriteLine("\t\tIsicam (E:Var / H:Yok) .............: " + a3.ic_donanim[4]);
            Console.WriteLine("\t\tKartonpiyer (E:Var / H:Yok) ........: " + a3.ic_donanim[5]);
            Console.WriteLine("\t\tLaminant (E:Var / H:Yok) ...........: " + a3.ic_donanim[6]);
            Console.WriteLine("\t\tPVC Dograma (E:Var / H:Yok) ........: " + a3.ic_donanim[7]);
            Console.WriteLine("\tAciklama : " + a3.aciklama + "\n\n");
            Console.ResetColor();
        }
    } 
}
