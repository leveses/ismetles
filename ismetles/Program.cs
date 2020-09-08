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

            Console.WriteLine("Gép választása: {0}",lehetoseg[gepValasz]);
            Console.WriteLine("Kő: 0, Papír: 1, Olló: 3");
            int jatekosV =  int.Parse(Console.ReadLine());
            Console.WriteLine("Játékos válastztása: {0}",lehetoseg[jatekosV]);
            Console.ReadKey();
        }
    }
}
