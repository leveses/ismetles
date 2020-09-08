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
            string jatekosV = Console.ReadLine();
            
            Console.ReadKey();
        }
    }
}
