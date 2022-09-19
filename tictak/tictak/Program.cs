using System;

namespace tictak
{
    class Program
    {
        public int[] board = { 1,2,3,4,5,6,7,8,9};
        
        int wonToss = -1;
        int nxt;
        static void Main(string[] args)
        {
            Console.Write("1 2 3\n4 5 6\n7 8 9\n");
            

            Program p = new Program();
            
            Console.WriteLine("Toss");

            p.wonToss = toss();

            Console.WriteLine(String.Format("Player {0} won the toss", p.wonToss < 0 ? 1 : 2));

            p.play(p.wonToss);

            while(true) 
            {
                p.display();

                p.play(p.nxt);

                if (p.isMatchDraw())
                {
                    Console.WriteLine("Match Draw");
                    break;
                }

                if (p.isGame())
                {
                    Console.WriteLine(String.Format("Player {0} won the game", inOff(p.nxt) < 0 ? 1 : 2));
                    break;
                }
                   
            }
                 
        }

        public bool isMatchDraw()
        {
            int sum = 0;
            for (int i=0; i< board.Length; i++)
            {
                sum += board[i];
            }

            if (sum > 0)
                return false;

            return true;
        }

        public static int toss()
        {
            Random random = new Random();
            return random.Next(-1, 0);
            
        }

        public bool isGame()
        {
            int[,] lines =
            {
                {0,3,6}, {1,4,7}, {2,5,8},
                {0,1,2}, {3,4,5}, {6,7,8},
                {0,4,8}, {2,4,6}
            };


            for (int l=0; l<lines.Length/3; l++)
            {
               if (board[lines[l,0]] == 0 && board[lines[l,1]] == 0 && board[lines[l, 2]] == 0)
                {
                    return true;
                }

               else if(board[lines[l, 0]] == -1 && board[lines[l, 1]] == -1 && board[lines[l, 2]] == -1)
                {
                    return true;
                }
            }

            return false;

        }

        public static int inOff(int i)
        {
            return i == 0 ? -1 : 0;
        }

        public void play(int player)
        {
            int n = int.Parse(Console.ReadLine());
            if (board[n-1] > 0)
            {
                board[n - 1] = player;
                nxt = inOff(player);
            } else
            {
                Console.WriteLine("Invalid");
                nxt=player;
            }
           
        }

        public void display()
        {
            int count = 0;
            for (int r = 0; r<3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[count] == 0)
                    {
                        Console.Write("O");
                    } else if (board[count] < 0)
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write((count + 1).ToString());
                    }

                    count++;
                }

                Console.WriteLine("\n");
            }
        }
    }
}
