using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Kisi : IKimlik
    {
        private cinsiyet cinsiyet;
        public cinsiyet Cinsiyet
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }

        private din din;
        public din Din
        {
            get
            {
                return din;
            }
            set
            {
                din = value;
            }
        }

        private string tc;
        public string TcKimlikNo
        {
            get
            {
                return tc;
            }
            set
            {
                tc = value;
            }
        }

        private string dogumyeri;
        public string DogumYeri
        {
            get
            {
                return dogumyeri;
            }
            set
            {
                dogumyeri = value;
            }
        }

        private DateTime dogumtarih;
        public DateTime DogumTarihi
        {
            get
            {
                return dogumtarih;
            }
            set
            {
                dogumtarih = value;
            }
        }

        private string ad;
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }

        private string soyad;
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }

        private string babaadi;
        public string BabaAdi
        {
            get
            {
                return babaadi;
            }
            set
            {
                babaadi = value;
            }
        }

        private string telefon;
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }

        
        public string FullName()
        {
            return ad + " " + soyad;
        }
    }
}
