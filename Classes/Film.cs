using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Film
    {

        private string cim;
        private string mufaj;
        private double ertekeles;
        private int hossz;
        //ctrl + . -> constructor make
        public Film(string cim, string mufaj, double ertekeles, int hossz)
        {
            this.Cim = cim;
            this.Mufaj = mufaj;
            this.Ertekeles = ertekeles;
            this.Hossz = hossz;
            
        }
        public string Cim { get => cim; set => cim = value; }
        public string Mufaj { get => mufaj; set => mufaj = value; }
        public double Ertekeles { get => ertekeles; set => ertekeles = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public override string ToString()
        {
            return $"{this.cim} {this.mufaj} {this.ertekeles} {this.hossz}";
        }
}
}
