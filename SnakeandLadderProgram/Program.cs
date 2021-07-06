using System;

namespace SnakeandLadderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SnakeandLadder Implementation");
            SnakeLadder();


        }

        public static void SnakeLadder()
        {
            int pos1 = 0;
            Random random = new Random();
            int player1 = random.Next(1, 7);
            Console.WriteLine(player1);
        }
       
    }
}
