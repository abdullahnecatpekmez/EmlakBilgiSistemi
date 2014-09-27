using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proje
{
    class urun
    {
        public string eşya;
        public int fiyat;
    }
    class agaç
    {
        public urun veri;
        public agaç sagkol;
        public agaç solkol;
        public void displayNode() { Console.Write(" " + veri.eşya + " "+veri.fiyat); }

    }
    class tree
    {
        public agaç kok;
        public tree () {kok=null; }
        public agaç kokal() { return kok;}
        public void ekle(urun sayi)
        {
            agaç yeni = new agaç();
            yeni.veri =sayi;
            if (kok == null)
                kok.veri = sayi;
            else
            {
                agaç simdiki=kok;
                agaç sonraki;
                while(true)
                {
                    sonraki = simdiki;
                  if(sayi.eşya.CompareTo(sayi.eşya)<0)
                    {
                      simdiki=simdiki.solkol;
                      if(simdiki==null)
                         {
                         sonraki.solkol=yeni;
                         return;
                         }
                     }
                 else 
                    {
                    simdiki=simdiki.sagkol;
                        if(simdiki==null)
                        {
                        sonraki.sagkol=yeni;
                            return;

                        }

                    }
                }
                 


            
            }

                  
        }
    }
    
    class Program
    {
        
       
        static void Main(string[] args)
        {
            string []ürünler = {" Masa", "Sandalye"," Dolap", "TV", "Süpürge", "Fırın", "Bulaşık M.", "Çamaşır M.", "Ütü", "Kanepe" };
            int [] fiyatlar= { 100, 40, 70, 450, 80, 120, 450, 550, 50, 95};
            urun[] urunler = new urun[10];
            tree agaç = new tree();
            for (int i = 0; i < 10; i++)
            {
                urunler[i] = new urun();
                urunler[i].fiyat=fiyatlar[i];
                urunler[i].eşya=ürünler[i];
                agaç.ekle(urunler[i]);
              
            }
            Console.ReadKey();
        }
    }
}
