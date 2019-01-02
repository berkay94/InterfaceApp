using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Departman
    {
        private string departmanAdi;

        public string DepartmanAdi
        {
            get { return departmanAdi; }
            set { departmanAdi = value; }
        }

        private int butce;

        public int Butce
        {
            get { return butce; }
            set { butce = value; }
        }


        ArrayList personeller = new ArrayList();

        public int PersonelEkle(Personel p)
        {
            personeller.Add(p);
            return 1;
        }

        public Personel personelGetir(string tckimlikno)
        {
            Personel bulunan=new Personel();
            foreach (Personel p in personeller)
            {
                if(p.TcKimlikNo==tckimlikno)
                {
                    bulunan = p;
                    break;
                }
            }
            return bulunan;
        }

        public void PersonelListele()
        {
            Console.WriteLine("Personellerin Listesi");
            Console.WriteLine("---------------------");
            foreach (Personel p in personeller)
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
        }

        public override string ToString()
        {
            return $"Departman Adi :{DepartmanAdi} \nButcesi :{Butce} \n" +
                $"Personel Sayisi :{personeller.Count}";
        }

        public ArrayList CinsiyetGetir(cinsiyet c)
        {
            ArrayList personel = new ArrayList();
            foreach (Personel p in personeller)
            {
                
                if (p.Cinsiyet==c)
                {
                    personel.Add(p);
                }
            }


            return personel;
            
        }

    }
}
