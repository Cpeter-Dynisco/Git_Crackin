using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] water = new char[10,10];
            char[] Alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
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
                        Console.Write(Alpha[i] + " ");
                    }
                    water[i, j] = '^';
                    Console.Write(" " + water[i, j] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("Enter your shot");
                string Target = Console.ReadLine();
                Fire(Target);
            }
            
            
        }

        public static void Fire(string Input)
        {
            char Row = Input[0];
            //char Col = Input[1];
            int R = Row - 'A';
            int temp = Input.Length;

        }
    }
}
