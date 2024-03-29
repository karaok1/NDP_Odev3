﻿/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3 - Proje Ödevi
**				ÖĞRENCİ ADI............: Abdullah Akçam
**				ÖĞRENCİ NUMARASI.......: g140910076
**                         DERSİN ALINDIĞI GRUP...: 2. Öğretim A
****************************************************************************/

using System;
using System.Collections.Generic;
using NDP_Proje.UrunTurleri;

namespace NDP_Proje
{
    // Örnek verilerin oluşturulduğu sınıf
    // Veriler rastgele oluşturulup atanmaktadır

    public static class VeriOlustur
    {
        // Buradaki sayıyı değiştirerek istediğimiz kadar ürün oluşturabiliriz
        private const int OlusturulacakUrunAdedi = 20;
        public static List<Musteri> musteriler;

        public static List<Urun> UrunleriOlustur()
        {
            var urunler = new List<Urun>();
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            var index = rnd.Next(0, 3);
            for (var i = 0; i < OlusturulacakUrunAdedi; i++)
            {
                switch (index)
                {
                    case 0:
                        urunler.Add(new Cocuk());
                        break;
                    case 1:
                        urunler.Add(new Bayan());
                        break;
                    case 2:
                        urunler.Add(new Erkek());
                        break;
                }

                index = rnd.Next(0, 3);
            }

            // Oluşturulan listeyi geri dönder
            return urunler;
        }
    }
}