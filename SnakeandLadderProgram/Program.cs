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
            int Play = 1;
            int Snake = 2;
            int max = 100;
            int min = 0;

            Random random = new Random();
            int player1 = random.Next(1, 7);
            int option1 = random.Next(1, 3);

            while (pos1 <= max)
            {

                if (pos1 == min && player1 != 6)
                {

                    Console.WriteLine("Position of player1:" + pos1);
                }

                else if (option1 == Play)
                {

                    pos1 = pos1+ player1;
                    Console.WriteLine("Position of player1:" + pos1);



                }

                else if (option1 == Snake)
                {

                    pos1 = pos1 -player1;
                    Console.WriteLine("Position of player1:" + pos1);

                }
            }


        }

    }
}
 