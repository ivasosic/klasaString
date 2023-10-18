using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Danas radimo s klasom string. \n";
            //ispis stringa 
            Console.WriteLine(tekst);

            //broj znakova u stringu
            Console.WriteLine("Broj znakova je: " + tekst.Length);
            
            //Ispis velikim slovima
            Console.WriteLine("Velika slova: " + tekst.ToUpper());

            //Ispis malim slovima
            Console.WriteLine("Mala slova: " + tekst.ToLower());

            //substring metoda
            Console.WriteLine("\n -- Substring metoda --");
            Console.WriteLine(tekst.Substring(0,5));
            Console.WriteLine(tekst.Substring(13, tekst.Length - 13));

            //zamjena znakova
            Console.WriteLine(tekst.Replace("Danas","Sutra"));

            //Razdvajanje stringa
            Console.WriteLine("\n -- Razdvajanje --");
            string[] rijeci = tekst.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }
            foreach(string rijec in rijeci)
            {
                Console.WriteLine(rijec);
            }

            //umetanje znakova u string
            Console.WriteLine("\n -- Umetanje __");
            Console.WriteLine(tekst.IndexOf("radimo"));
            
            Console.WriteLine(tekst.Insert(tekst.IndexOf("radimo"), "intenzino "));

            Console.ReadKey();
        }
    }
}
