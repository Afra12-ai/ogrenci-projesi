using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci_projesi
{
    public class ogrenci
    {
        private int ogrenciNo;
        private string ogrenciName;
        private string ogrenciSurname;          //DEĞİŞKENLERİ TANIMLADIK AMA İÇİNE DEĞER ATAMADIK
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public ogrenci(int _ogrenciNo,string _ogrenciName,string _ogrenciSurname,int _vize1,int _vize2,int _final,string _okulismi)
        {
            ogrenciNo = _ogrenciNo;
            ogrenciName = _ogrenciName;
            ogrenciSurname = _ogrenciSurname;       //YAPICI METOTDA TANIMLADIĞIMIZ DEĞERLERE GİRİŞ YAPARIZ
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;

        }

        public void ogrencibilgileri()
        {
            Console.WriteLine("öğrencinin numarası:" + ogrenciNo);
            Console.WriteLine("öğrencinin ismi:" + ogrenciName);
            Console.WriteLine("öğrencinin soyadı:" + ogrenciSurname);
        }

        public double ogrenciortalamasıhesapla()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
                return ortalama;
        }
        public void okulgetir()
        {
            Console.WriteLine("ogrencinin okulu:" + okulismi);
        }


        
    }
    internal class Program
    {
        static void islemlerigoster()
        {
            Console.WriteLine("öğrenci bilgileri için 1");
            Console.WriteLine("öğrenci ortlaması için 2");
            Console.WriteLine("öğrenci okul bilgileri için 3");
            Console.WriteLine("çıkış için 4'ü tuşlayınız");
        }
        static void Main(string[] args)
        {
            bool kontrol = true;
            ogrenci ogrenci1 = new ogrenci(1, "afra", "duman", 68, 55, 79, "selçuk üniverstesi");
            Console.WriteLine("UYGULAMAYA HOŞGELDİNİZ...Yapmak istediğiniz işlemi seçiniz");
            islemlerigoster();

            while (kontrol)
            {
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrencibilgileri();
                        break;
                    case "2":
                        double ogrenciortalama = ogrenci1.ogrenciortalamasıhesapla();
                        Console.WriteLine("öğrencinin ortalaması:" + ogrenciortalama);
                        break;
                    case "3":
                        ogrenci1.okulgetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;
                }
            }
            Console.Read();
            

        }
    }
}
