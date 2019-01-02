using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeData;

namespace InterfaceApp
{
    class Program
    {
        static Personel p;
        static Departman dep;


        static void Main(string[] args)
        {
            DataEkle();
            dep.PersonelListele();
            Console.WriteLine("---------Bayan Personeller----------");
            foreach (Personel p in dep.CinsiyetGoreGetir(cinsiyet.Bayan))
            {
                
                Console.WriteLine($"TcKimlikNo     :{p.TcKimlikNo}");
                Console.WriteLine($"Ad             :{p.Ad}");
                Console.WriteLine($"Soyad          :{p.Soyad}");
                Console.WriteLine($"Telefon        :{p.Telefon}");
                Console.WriteLine($"Dogum Tarihi   :{p.DogumTarihi}");
                Console.WriteLine($"Dogum Yeri     :{p.DogumYeri}");
                Console.WriteLine($"Cinsiyet       :{p.Cinsiyet}");
                Console.WriteLine($"Din            :{p.Din}");
                Console.WriteLine($"Email          :{p.Email}");
                Console.WriteLine("---------------------------------");
                

            }
            Console.WriteLine(dep.ToString());
            Console.ReadKey();
        }

        static void DataEkle()
        {
            p = new Personel();
            p.Ad = "Ali";
            p.Soyad = "Yilmaz";
            p.TcKimlikNo = "123456789";
            p.Telefon = "12345677889";
            p.DogumTarihi = new DateTime(1900, 1, 1);
            p.DogumYeri = "Istanbul";
            p.Cinsiyet = cinsiyet.Erkek;
            p.Din = din.Para;
            p.Email = "aliyilmaz@email.com";

            dep = new Departman();
            dep.Butce = 10000;
            dep.DepartmanAdi = "IT";
            dep.PersonelEkle(p);

            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi= FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Bayan;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "4899844815";
            dep.PersonelEkle(p);

            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Erkek;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "1235699489";
            dep.PersonelEkle(p);

            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Erkek;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "9658475452";
            dep.PersonelEkle(p);

            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Bayan;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "6597848224";
            dep.PersonelEkle(p);

            
            
        }


    }
    
   
}
