using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatika
{
    class Ucenik
    {
        public string _ime { get; set; }
        public string _prezime { get; set; }
        public string _razred { get; set; }
        public int n { get; set; }
        List<int> ocjene = new List<int>();

        public Ucenik()
        {
            Console.Write("Unesite ime:");
            _ime = Console.ReadLine();
            Console.Write("Unesite prezime:");
            _prezime = Console.ReadLine();
            Console.Write("Unesite razred:");
            _razred = Console.ReadLine();
            Console.Write("Unesite broj ocjena:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Unesite ocjene ucenika:");
            for (int i = 0; i < n; i++)
            {
                ocjene[i] = int.Parse(Console.ReadLine());

            }

        }
        public double Prosjek(int n)
        {
            double _sum = 0, _prosjek;
            foreach (int i in ocjene)
            {
                _sum = _sum + ocjene[i];
            }
            _prosjek = _sum / n;
            return _prosjek;
        }
        public void Ispis(double prosjek, int m)
        {
            foreach (int i in ocjene)
            {
                Console.Write("{0} ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Ucenik ucenik1 = new Ucenik();
            Console.Write("Unesite broj uičenika:");
            int m = int.Parse(Console.ReadLine());
        }
    }
}
