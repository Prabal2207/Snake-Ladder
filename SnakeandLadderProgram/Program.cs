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
            int max = 100;
            int min = 0;

            Random random = new Random();

            int Play = 1;
            int Snake = 2;

            int Num_of_Times_Diceroll = 0;

            while (pos1 < max)
            {

                int player1 = random.Next(1, 7);

                int player2 = random.Next(1, 7);

                int option1 = random.Next(1, 3);
                int option2 = random.Next(1, 3);

                //for player 1

                if (pos1 == min && player1 != 6)
                {
                    Num_of_Times_Diceroll++;
                    Console.WriteLine("Position of player1:" + pos1);
                }

                else if (option1 == Play)
                {
                    Num_of_Times_Diceroll++;
                    pos1 += player1;


                    if (pos1 > max)
                    {
                        pos1 = pos1 - player1;

                    }
                    Console.WriteLine("Position of player1:" + pos1);
                }

                else if (option1 == Snake)
                {
                    Num_of_Times_Diceroll++;
                    pos1 -= player1;
                    if (pos1 < min)
                    {
                        pos1 = 0;

                    }
                    Console.WriteLine("Position of player1:" + pos1);
                }

            }
            Console.WriteLine("Number of Dice Roll=" + Num_of_Times_Diceroll);



        }

    }
}
 