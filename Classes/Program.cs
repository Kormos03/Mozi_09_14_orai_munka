using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            
            Film f1 = new Film("Winnie the Pooh", "Cartoon", 10.0, 63);
            Film f2 = new Film("ET", "Fantasy", 10.0, 115);
            Film f3 = new Film("Go back to the future", "sci-fi", 10.0, 63);
            Film f4 = new Film("Go back to the future II", "scifi", 10.0, 63);
            Film f5 = new Film("Go back to the future III", "scifi", 10.0, 63);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f4);
            Mozi m = new Mozi("Winnie the pooh movie");
            m.Musorratuzes(f1);
            m.Musorratuzes(f2);
            m.Musorratuzes(f3);
            m.Musorratuzes(f4);
            m.Musorratuzes(f5);

            Jegy i1 = new Jegy(f1, 8, 6, 2500);
            Jegy i2 = new Jegy(f1, 8, 6, 2500);
            Jegy i3 = new Jegy(f1, 8, 6, 2500);
            Jegy i4 = new Jegy(f2, 8, 6, 2500);
            Jegy i5 = new Jegy(f2, 8, 6, 2500);
            Jegy i6 = new Jegy(f2, 8, 6, 2500);
            Jegy i7 = new Jegy(f2, 8, 6, 2500);
            m.Szabadhelyek();
            Console.WriteLine(m);
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                int x = r.Next(1, 8);
                int y = r.Next(1, 8);

                Console.WriteLine($"{x} sor, {y} szék foglalása {(m.Foglalas(x, y)?"sikeres":"sikertelen")}");
            }

        }
    }
}
