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
            int pos2 = 0;
            int max = 100;
            int min = 0;

            Random random = new Random();

            int Play = 1;
            int Snake = 2;

            int Num_of_Times_Diceroll = 0;

            while (pos1 < max && pos2 < max)
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

                //player 2

                if (pos2 == min && player2 != 6)
                {
                    Num_of_Times_Diceroll++;
                    Console.WriteLine("Position of player2:" + pos2);


                }
                else if (option2 == Play)
                {
                    Num_of_Times_Diceroll++;
                    pos2 += player2;


                    if (pos2 > max)
                    {
                        pos2 = pos2 - player2;

                    }
                    Console.WriteLine("Position of player2:" + pos2);
                }

                else if (option2 == Snake)
                {
                    Num_of_Times_Diceroll++;
                    pos2 -= player2;




                    if (pos2 < min)
                    {
                        pos2 = 0;

                    }
                    Console.WriteLine("Position of player2:" + pos2);
                }


            }
            if (pos1 == max)
            {
                Console.WriteLine("Player 1 won");
                Console.WriteLine("Number of Dice Roll=" + Num_of_Times_Diceroll);
            }
            else if (pos2 == max)
            {
                Console.WriteLine("Player 2 won");
                Console.WriteLine("Number of Dice Roll=" + Num_of_Times_Diceroll);
            }

        }


    }

}

 