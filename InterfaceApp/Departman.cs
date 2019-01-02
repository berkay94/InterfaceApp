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

        
    }
}
