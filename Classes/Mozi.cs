using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Mozi
    {
        private string nev;
        private List<Film> musor;
        private bool[,] helyek;
        private const int SOROKSZAMA = 8;
        private const int OSZLOPOKSZAMA = 8;

        public Mozi(string nev)
        {
            this.nev = nev;
            Musor = new List<Film>();
            this.Helyek = new bool[SOROKSZAMA1, OSZLOPOKSZAMA1];
        }
        public string Nev { get => nev; set => nev = value; }
        internal List<Film> Musor { get => musor; set => musor = value; }
        public bool[,] Helyek { get => helyek; set => helyek = value; }

        public static int SOROKSZAMA1 => SOROKSZAMA;

        public static int OSZLOPOKSZAMA1 => OSZLOPOKSZAMA;
        public void Musorratuzes(Film f)
        {
            musor.Add(f);
        }
        public void Torles(Film f)
        {
            musor.Remove(f);
        }
        public Film Keresesnevalapjan(string nev)
        {
            Film f = null;
            foreach (var item in this.musor)
            {
                if (item.Cim.Equals(nev))
                {
                    return item;
                }
            }
            return f;
        }

        public void Szabadhelyek()
        {

            Console.WriteLine(@"
                --------------
                Szabad helyek
                -------------
                ");

            for (int i = 0; i < SOROKSZAMA; i++)
            {
                for (int j = 0; j < OSZLOPOKSZAMA; j++)
                {
                    if (helyek[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("O");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }
        public bool Foglalas(int x, int y) //x sor, y oszlop
        {
            bool siker = false;
            if (helyek[x-1, y-1]) 
            {
                return false;
            }
            helyek[x-1, y-1] = true;
            return true;
        }
        public override string ToString()
        {

            string s = "";
            foreach (var item in musor)
            {
                
            }
            return s;
        }
    }
}
