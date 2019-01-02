using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        delegate int MyDelegate(int a);
        static void Main(string[] args)
        {
           // kareAl adında metotla yapıldı
            Console.WriteLine($"5'in karesi: {kareAl(5)}");

            //1.Adim
            MyDelegate del = new MyDelegate(kareAl);
            Console.WriteLine($"5'in karesi: {del(5)}");

            //2.Adim
            MyDelegate my = delegate (int a) { return (a * a); };
            Console.WriteLine($"3'un karesi: {my(3)}");

            //3.Adim
            MyDelegate kare = (int sayi) => { return (sayi * sayi); };
            Console.WriteLine($"4'un karesi: {kare(4)}");

            //4.Adimda 3.Adimdan farklı olarak return yok
            MyDelegate kare2 = (int sayi) => (sayi * sayi);
            Console.WriteLine($"6'nin karesi: {kare2(6)}");

            //5.Adim
            MyDelegate kare3 = I => (I * I);
            Console.WriteLine($"7'nin karesi: {kare3(7)}");

            LambdaKullanimi();

            Console.ReadLine();
        }

        public static int kareAl(int a)
        {
            return (a * a);
        }

        static void LambdaKullanimi()
        {
            int[] tumRakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int> tekRakamlar = tumRakamlar.Where(x => x % 2 == 1);

            Console.Write("Tek Rakamlar:");
            

            foreach (int rakam in tekRakamlar)
            {
                Console.Write(" "+rakam);
                
            }

            Console.WriteLine();

            IEnumerable<int> ciftRakamlar = tumRakamlar.Where(x => x % 2 == 0);

            Console.Write("Cift Rakamlar:");

            foreach (int rakam in ciftRakamlar)
            {
                Console.Write(" "+rakam);
            }

            Console.ReadKey();
            

            
        }
    }
}
