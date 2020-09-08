using System;

namespace ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[]{ "Kő", "Papír", "Olló"};
            int gepValasz = vel.Next(0,3);

            //Console.WriteLine("Gép választása: {0}",lehetoseg[gepValasz]);
            Console.WriteLine("Kő: 0, Papír: 1, Olló: 2");
            int jatekosV =  int.Parse(Console.ReadLine());
            Console.WriteLine("Játékos válastztása: {0}",lehetoseg[jatekosV]);
            if (gepValasz == 0)
            {
                if (jatekosV == 0)
                {
                    Console.WriteLine("Döntetlen");
                }
                if (jatekosV == 1)
                {
                    Console.WriteLine("A játékos győzött");
                }
                if (jatekosV == 2)
                {
                    Console.WriteLine("A számítógép győzött");
                }
            }
            if (gepValasz == 1)
            {
                if (jatekosV == 0)
                {
                    Console.WriteLine("A számítógép győzött");
                }
                if (jatekosV == 1 && gepValasz == 1)
                {
                    Console.WriteLine("Döntetlen");
                }
                if (jatekosV == 2)
                {
                    Console.WriteLine("A játékos győzött");
                }
            }
            if (gepValasz == 2)
            {
                if (jatekosV == 0)
                {
                    Console.WriteLine("A játékos győzött");
                }
                if (jatekosV == 1)
                {
                    Console.WriteLine("A számítógép győzött");
                }
                if (jatekosV == 2 && gepValasz == 2)
                {
                    Console.WriteLine("Döntetlen");
                }
            }
            Console.ReadKey();
        }
    }
}
