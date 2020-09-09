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

            
            Console.WriteLine("Kő: 0, Papír: 1, Olló: 2");
            int jatekosV =  int.Parse(Console.ReadLine());
            Console.WriteLine("Játékos válastztása: {0}",lehetoseg[jatekosV]);
            Console.WriteLine("Gép választása: {0}",lehetoseg[gepValasz]);
            if (jatekosV == gepValasz) //döntetlen
            {
                Console.WriteLine("Döntetlen");
            }
            else if (gepValasz == 0 && jatekosV == 2 || gepValasz == 1 && jatekosV == 0 || gepValasz == 2 && jatekosV == 1) //gép nyer
            {
                Console.WriteLine("Számítógép nyer");
            }
            else // játékos nyer
            {
                Console.WriteLine("Játékos nyer");
            }
            Console.ReadKey();
        }
    }
}
