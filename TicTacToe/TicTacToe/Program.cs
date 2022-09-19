using System;

namespace TicTacToe
{
    class Program
    {

        static player tossWinner;
        static char player1Choice;
        static char player2Choice;

        static void Main(string[] args)
        {
            put_toss();

            show_players_details();

            play_game();


        }


        //Display board

        #region Display-board

        public static void Displayboard(char[] board)
        {
            Console.WriteLine();
            for (int i = 1; i < board.Length; i++)
            {
                Console.Write("| " + board[i] + " ");


                if (i % 3 == 0 && i != 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion


        //Game functions

        #region Check position availability

        public static bool ispositionAvailable(uint i, char[] board)
        {
            return board[i] != (char)Choice.x && board[i] != (char)Choice.o;
        }

        #endregion

        #region show_winner

        public static void showresults(char[] board,player p)
        {
            Displayboard(board);

            if(p == player.first)
            {
                Console.WriteLine("Player 1 Wins!");
            }

            if(p == player.second)
            {
                Console.WriteLine("Player 2 wins!");
            }

            if((state)p == state.draw)
            {
                Console.WriteLine("The game is draw!");
            }
        }

        #endregion

        #region Winning-conditions


        public static bool checkVertical(char playerChoice, char[] board)
        {
        
           if(board[1] == playerChoice)
            {
                if(board[4] == playerChoice)
                {
                    if(board[7] == playerChoice)
                    {
                        return true;
                    }
                }
            }


           if(board[2] == playerChoice)
            {
                if(board[5] == playerChoice)
                {
                    if(board[8] == playerChoice)
                    {
                        return true;
                    }
                }
            }


            if (board[3] == playerChoice)
            {
                if (board[6] == playerChoice)
                {
                    if (board[9] == playerChoice)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool checkHorizontal(char playerChoice, char[] board)
        {
            if (board[1] == playerChoice)
            {
                if (board[2] == playerChoice)
                {
                    if (board[3] == playerChoice)
                    {
                        return true;
                    }
                }
            }


            if (board[4] == playerChoice)
            {
                if (board[5] == playerChoice)
                {
                    if (board[6] == playerChoice)
                    {
                        return true;
                    }
                }
            }


            if (board[7] == playerChoice)
            {
                if (board[8] == playerChoice)
                {
                    if (board[9] == playerChoice)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool checkDiagonal(char playerChoice, char[] board)
        {
            if (board[1] == playerChoice)
            {
                if (board[5] == playerChoice)
                {
                    if (board[9] == playerChoice)
                    {
                        return true;
                    }
                }
            }

            if(board[3] == playerChoice)
            {
                if(board[5] == playerChoice)
                {
                    if(board[7] == playerChoice)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static state isdraw(int filled_places)
        {
            if(filled_places == 9)
            {
                return state.draw;
            }
            return state.noresult;
        }

        public static state checkWinningConditions(char playerChoice,char[] board)
        {

            if(checkDiagonal(playerChoice,board) || checkHorizontal(playerChoice,board) || checkVertical(playerChoice,board))
            {
                return state.win;
            }

            return state.noresult;
        }

        #endregion

        #region Play-Game

        public static void play_game()
        {
            char[] board = new char[10];

            int filled_places = 0;

            int i = 1;

            bool flag;

            if(tossWinner == player.first)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }


            while(i < board.Length)
            {
                uint position;

                Displayboard(board);

                Console.WriteLine("Enter position");


                position = uint.Parse(Console.ReadLine());

                if(ispositionAvailable(position,board))
                {
                    if(flag)
                    {
                        board[position] = player1Choice;

                        filled_places++;

                        if (checkWinningConditions(player1Choice,board) == state.win && filled_places > 4)
                        {
                            showresults(board,player.first);
                            return;
                        }

                    }
                    else
                    {
                        board[position] = player2Choice;

                        filled_places++;

                        if (checkWinningConditions(player2Choice,board) == state.win && filled_places > 4)
                        {
                            showresults(board,player.second);
                            return;
                        }
                    }

                    flag = !flag;

                    i++;

                }
                else
                {
                    Console.WriteLine("Position already filled, try again");
                }
            }

            if (filled_places == 9)
            {
                showresults(board,(player)isdraw(filled_places));
            }
        }

        #endregion



        //Toss functions

        #region commencement of toss and post toss

        public static void put_toss()
        {
            Tossup();
            promptTossWinnerChoice();
            setTossLoserChoice();
            handleExceptions();
        }

        #endregion

        #region Toss functions



        public static void Tossup()
        {
            Random r = new Random();

            int temp = r.Next(1, 3);

            tossWinner = (player)temp;
        }


        public static void promptTossWinnerChoice()
        {
            if (tossWinner == player.first)
            {
                Console.WriteLine("YAYYY! first player won the toss ");
                Console.WriteLine("Please choose X or O: ");
                player1Choice = char.Parse(Console.ReadLine().ToUpper());
            }
            else
            {
                Console.WriteLine("YAYYY! Second player won the toss ");
                Console.WriteLine("Please choose X or O: ");
                player2Choice = char.Parse(Console.ReadLine().ToUpper());
            }
        }


        public static void setTossLoserChoice()
        {


            if (tossWinner == player.second)
            {
                if (player2Choice == (char)Choice.x)
                {
                    player1Choice = (char)Choice.o;
                }
                else if (player2Choice == (char)Choice.o)
                {
                    player1Choice = (char)Choice.x;
                }
            }

            if (tossWinner == player.first)
            {
                if (player1Choice == (char)Choice.x)
                {
                    player2Choice = (char)Choice.o;
                }
                else if (player1Choice == (char)Choice.o)
                {
                    player2Choice = (char)Choice.x;
                }
            }
        }

        public static void handleExceptions()
        {

            if (tossWinner == player.first)
            {
                while (player1Choice != (char)Choice.x && player1Choice != (char)Choice.o)
                {
                    Console.WriteLine("Wrong input, try again");
                    Console.WriteLine("Enter player1 choice: ");
                    player1Choice = char.Parse(Console.ReadLine().ToUpper());
                }

            }

            if (tossWinner == player.second)
            {
                while (player2Choice != (char)Choice.x && player2Choice != (char)Choice.o)
                {
                    Console.WriteLine("Wrong Input, try again");
                    Console.WriteLine("Enter player2 choice: ");
                    player2Choice = char.Parse(Console.ReadLine().ToUpper());
                }
            }

            setTossLoserChoice();
            
        }

        #endregion


        //Details of choices of players

        #region Show selections of the players
        public static void show_players_details()
        {
            Console.WriteLine("Choice Selections: ");
            Console.WriteLine("The first player is: " + player1Choice);
            Console.WriteLine("The Second player is: " + player2Choice);
        }
        #endregion




        //players attributes

        #region No of players

        public enum player
        {
            first = 1,
            second = 2
        }

        #endregion

        #region PlayersChoice

        public enum Choice
         {
            x = 'X',
            o = 'O'
         }

        #endregion


        //Game states

        #region Game state

        public enum state
        {
            win  = 1,
            draw = 3,
            noresult=4
        }

        #endregion
    }
}
