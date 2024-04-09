using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unos putenje mape
            Console.WriteLine("Unesi putanju mape: ");
            string putanja = Console.ReadLine();
            //provjera postojanja mape
            if(Directory.Exists(putanja))
            {
                Console.WriteLine("Mapa postoji!");
                //ako postoji ispisuje sve datoteke
                Console.WriteLine("Ispis datoteka: ");
                foreach(string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }

                string putanjaPodMape = putanja + "\\bla";

                if (!Directory.Exists(putanjaPodMape))
                {
                    Directory.CreateDirectory(putanjaPodMape);
                    Console.WriteLine("Mapa " + putanjaPodMape + " je napravljena");
                }
                Console.WriteLine("Ispis podmapa: ");
                foreach (string podmapa in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(podmapa);
                }

                Directory.Delete(putanjaPodMape);
                Console.WriteLine("Ispis podmapa nakon brisanja: ");
                foreach (string podmapa in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(podmapa);
                }
            }
            //ako ne postoji kreiramo mapu
            else
            {
                Directory.CreateDirectory(putanja);
                Console.WriteLine("Mapa " + putanja + " je napravljena");
            }

            Console.ReadKey();
        }
    }
}
