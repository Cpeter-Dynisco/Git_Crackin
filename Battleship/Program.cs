using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] water = new char[10,10];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    water[i, j] = '/';
                    Console.Write("." + water[i, j] + ".");
                }
                Console.WriteLine("");
            }
            
            
        }
    }
}
