using System;

namespace TicTacToe_2
{ 
    class Board
    {
        int[] tiles;
        public const int BOARDSIZE = 9;
   
        public Board() { this.tiles = new int[BOARDSIZE]; }
    };

    class Coin
    {
        Choice player;

        public Coin(Choice player) { this.player = player; }

        public Choice GetChoice() { return this.player; }
    };
    
    class TicTacToe
    {
        Board gameBoard;
        Coin firstPlayer;
        Coin secondPlayer;
        BoardState boardState;

        public TicTacToe()
        {
            this.gameBoard = new Board();
            this.boardState = BoardState.Empty;
        }

        public void TossUp()
        {
            Random r = new Random();
            SetConsoleColor(ConsoleColor.DarkYellow);
            Console.WriteLine("************************************");
            SetConsoleColor(ConsoleColor.DarkMagenta);
            if ((Player)r.Next(1, 3) == Player.First)
            {
                Console.WriteLine("* YAYYY! First player won the toss *");
                SetConsoleColor(ConsoleColor.DarkYellow);
                Console.WriteLine("************************************");
                SetChoice(Player.First);
            }
            else
            {
                Console.WriteLine("* YAYYY! Second player won the toss *");
                SetConsoleColor(ConsoleColor.DarkYellow);
                Console.WriteLine("************************************");
                SetChoice(Player.Second);
            }
        }

        void SetChoice(Player TossWinner)
        {
            PrintMessage("   Enter X or O");

            Choice WinnerChoice = (Choice)char.Parse(Console.ReadLine());

            Choice LoserChoice = (WinnerChoice == Choice.o) ? Choice.x : Choice.o;

            if(TossWinner == Player.First)
            {
                this.firstPlayer = new Coin(WinnerChoice);
                this.secondPlayer = new Coin(LoserChoice);
            }
            else
            {
                this.secondPlayer = new Coin(WinnerChoice);
                this.firstPlayer = new Coin(LoserChoice);
            }
            ShowChoice();
        }

        void ShowChoice()
        {
            PrintMessage(string.Format("   PLAYER CHOICES"));
            PrintMessage(string.Format("   PLAYER 1 : {0}", this.firstPlayer.GetChoice().ToString().ToUpper()));
            PrintMessage(string.Format("   PLAYER 2 : {0}", this.secondPlayer.GetChoice().ToString().ToUpper()));
        }

        void SetConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        void PrintMessage(string message)
        {
            SetConsoleColor(ConsoleColor.Cyan);
            Console.WriteLine("----------------------------");
            SetConsoleColor(ConsoleColor.DarkMagenta);
            Console.WriteLine("| "+message+"          |");
            SetConsoleColor(ConsoleColor.Cyan);
            Console.WriteLine("----------------------------");
            Console.ResetColor();
        }
    };
}
