using System;
using System.IO;

namespace ismetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

        static int gepNyer = 0;
        static int jatekosNyer = 0;
        static int menet = 0;

        static int GepValasztas()
        {
            Random vel = new Random();
            return vel.Next(0, 3);
        }
        static int JatekosValaszt()
        {
            Console.WriteLine("Kő: 0, Papír: 1, Olló: 2");
            return int.Parse(Console.ReadLine());
        }
        static void EredmenyKiiras(int gep, int ember)
        {
            Console.WriteLine("Gép: {0} --- Játékos {1}", lehetoseg[gep], lehetoseg[ember]);
            switch (EmberNyer(gep, ember))
            {
                case 0:
                    Console.WriteLine("Döntetlen");
                    break;
                case 1:
                    Console.WriteLine("Gép nyert");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyert");
                    break;
            }
        }
        static int EmberNyer(int gep, int ember)
        {
            if (ember == gep) //döntetlen
            {
                return 0;
            }
            else if (gep == 0 && ember == 2 || gep == 1 && ember == 0 || gep == 2 && ember == 1) //gép nyer
            {
                gepNyer++;
                return 1;
            }
            else // játékos nyer
            {
                jatekosNyer++;
                return 2;
            }
        }
        private static bool AkarJatszni()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Szeretnél még tovább játszani? [i/n]");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("------------------------------------");
            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }
        
        
        static void Main(string[] args)
        {
            StatisztikaFajlbol();

            bool tovabb = true;
            while (tovabb)
            {
                menet++;
                int gep = GepValasztas();
                int ember = JatekosValaszt();
                Console.WriteLine("Játékos válastztása: {0}", lehetoseg[ember]);
                Console.WriteLine("Gép választása: {0}", lehetoseg[gep]);
                EredmenyKiiras(gep, ember);
               
                tovabb = AkarJatszni();
                StatisztikaKiiras();
            }
        }

        private static void StatisztikaFajlbol()
        {
            StreamReader stat = new StreamReader("Statisztika.txt");
            int x = 0;
            while (!stat.EndOfStream)
            {
                string[] sor = stat.ReadLine().Split(';');
                int[] adat = new int[3];
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(sor[i]);
                    Console.Write(adat[i]+ " ");
                }
                Console.WriteLine();
            }
            stat.Close();
            Console.WriteLine("------------->Statisztika vége<-------------");
        }

        private static void StatisztikaKiiras()
        {
            Console.WriteLine("Menetek száma: {0}" +
                "\tJátékos győzelmeinek száma: {1}"
                + "\tGép győzelmeinek száma: {2}",menet,jatekosNyer,gepNyer);
        }
    }
}
