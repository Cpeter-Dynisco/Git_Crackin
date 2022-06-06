using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] water = new char[10,10];
            //char[] Alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            for(int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("   A  B  C  D  E  F  G  H  I  J");
                }
                for(int j = 0; j < 10; j++)
                {
                    if(j == 0)
                    {
                        Console.Write(i + " ");
                    }
                    water[i, j] = '^';
                    Console.Write(" " + water[i, j] + " ");
                }
                Console.WriteLine("");
            }
            
            
        }
    }
}
