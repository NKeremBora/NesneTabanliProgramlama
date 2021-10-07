using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace odev
{
    public static class Hesapla
    {
         public enum Islem
        {
            TekSayi,
            CiftSayi,
            AsalSayi,
            MukemmelSayi
        }
        public  static List<int> Calistir(Islem islem,int baslangic, int bitis)
        {
            List<int> list = new List<int>();
           
            if (islem == Islem.CiftSayi)
                for (int i = baslangic; i < bitis; i++)
                    if (i % 2 == 0)
                        list.Add(i);

            if (islem == Islem.TekSayi)
                for (int i = baslangic; i < bitis; i++)
                    if (i % 2 == 1)
                        list.Add(i);
            
            if (islem == Islem.AsalSayi)
                for (int i = baslangic; i < bitis; i++)
                {
                    bool sonuc = AsalSayiKontrol(i);
                    if (sonuc && i != 1)
                        list.Add(i);
                }

            if (islem == Islem.MukemmelSayi)
                for (int i = baslangic; i < bitis; i++)
                {
                    bool sonuc = MukemmelSayiKontrol(i);
                    if (sonuc)
                        list.Add(i);
                }

            return list;
        }

        private static bool MukemmelSayiKontrol(int sayi)
        {
            int toplam = 0;

            for (int i = 1; i < sayi; i++)
                if (sayi % i == 0)
                    toplam += i;
            if (sayi == toplam)
                return true;
            else
                return false;
        }

        private static bool AsalSayiKontrol(int sayi)
        {
            bool sonuc = true;
            for (int i = 2; i < sayi; i++)
                if (sayi % i == 0)
                    sonuc = false;
            return sonuc;
        }

        public static int Topla(List<int> liste)
        {
            int toplam = 0;
            foreach (int sayi in liste)
                toplam += sayi;
            return toplam;
        }
        public static BigInteger Carp(List<int> list)
        {
            BigInteger result = BigInteger.Parse("1"); 
            foreach (int sayi in list)
              result *=  (BigInteger)sayi;
            
            return result;
        }
    } 
}
