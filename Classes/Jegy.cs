using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Jegy
    {
        private Film film;
        private int sor;
        private int szek;
        private int ar;

        public Jegy(Film film, int sor, int szek, int ar)
        {
            this.film = film;
            this.sor = sor;
            this.szek = szek;
            this.ar = ar;
        }

        public int Sor { get => sor; set => sor = value; }
        public int Szek { get => szek; set => szek = value; }
        public int Ar { get => ar; set => ar = value; }
        internal Film Film { get => film; set => film = value; }
        public override string ToString()
        {
            return $"{film.Cim} sor: {sor}, szék {szek},\n\t\tÁra: {this.ar} Ft";
        }
    }
}
