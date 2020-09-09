using System;

namespace ismetles
{
    class Program
    {
        static int EmberNyer(int gep, int ember)
        {
            if (ember == gep) //döntetlen
            {
                return 0;
            }
            else if (gep == 0 && ember == 2 || gep == 1 && ember == 0 || gep == 2 && ember == 1) //gép nyer
            {
                return 1;
            }
            else // játékos nyer
            {
                return 2;
            }
        }
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[]{ "Kő", "Papír", "Olló"};
            int gep = vel.Next(0,3);

            
            Console.WriteLine("Kő: 0, Papír: 1, Olló: 2");
            int ember =  int.Parse(Console.ReadLine());
            Console.WriteLine("Játékos válastztása: {0}",lehetoseg[ember]);
            Console.WriteLine("Gép választása: {0}",lehetoseg[gep]);
            Console.WriteLine("Gép: {0} --- Játéswswswwsswwskos {1}",lehetoseg[gep], lehetoseg[ember]);
            switch (EmberNyer(gep,ember))
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
            Console.ReadKey();
        }
    }
}
