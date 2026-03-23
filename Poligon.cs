using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace poligon_3_9b_2026
{
    internal class Poligon
    {
        public int br_temena;
        public Tacka[] teme;
        public Poligon(int n)
        {
            br_temena = n;
            teme = new Tacka[n];
        }
        public static Poligon unos() 
        {
            Console.WriteLine("Koliko temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                Console.WriteLine("T[{0}].x =", i+1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y koord tacke T({0})=", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon ima {0} temena", br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("Koordinate {0}. tacke su x={1} i y={2}", i + 1, teme[i].x, teme[i].x);
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        public static Poligon ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                novi.teme[i].x = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i].y = Convert.ToDouble(ulaz.ReadLine());
            }
            return novi;
        }
    }
}
