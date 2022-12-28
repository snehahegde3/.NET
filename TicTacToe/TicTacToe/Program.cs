
using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] board = new char[,]
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };
        static bool again = false;
        static void Main(string[] args)
        {
            do {
                Console.Clear();
                char player = 'X';
                string temp;
                bool isCorrectInput = true;
                int input = 0;
                bool gameOn = true;
                string strInput;
                SetBoard();
                Console.Write("Select X or O: ");
                temp = Console.ReadLine();
                if (temp == "O")
                {
                    Console.WriteLine("Selected O");
                    player = 'O';
                }
                else
                {
                    Console.WriteLine("Selected X");
                }
                do
                {
                    Console.Clear();
                    SetBoard();
                    Console.WriteLine($"Player {player} playing");
                    Console.Write("Enter the block number: ");
                    strInput = Console.ReadLine();
                    isCorrectInput = int.TryParse(strInput, out input);
                    while (!isCorrectInput || (input < 1 || input > 9))
                    {
                        Console.Write("Invalid input. Try again: ");
                        strInput = Console.ReadLine();
                        isCorrectInput = int.TryParse(strInput, out input);

                    }

                    player = Mark(player, input);
                    Console.Clear();
                    SetBoard();
                    gameOn = !Win();

                } while (gameOn);
                Console.ForegroundColor = ConsoleColor.Green;
                player = player == 'X' ? 'O' : 'X';
                Console.WriteLine($"Player {player} winss!!!");
                Console.ForegroundColor = ConsoleColor.White;
                int count = 1;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        board[i, j] = count.ToString()[0];
                        count++;
                    }
                }
                Console.ReadKey();
                Console.WriteLine("Press 1 to play again");
                string game = Console.ReadLine();
                if(game == "1")
                {
                    again = true;
                }
                else
                {
                    Console.WriteLine("Exiting...");
                }

            } while (again);
            
            Console.ReadKey();

        }
        
        public static bool IsEmpty(int a, int b)
        {
            if (board[a, b]-'0' >= 1 && board[a, b]-'0' <= 9)
            {
                return true;
            }
            Console.WriteLine("Block alredy filled.");
            return false;
        }
        public static char Mark(char player, int input)
        {
            switch (player)
            {
                case 'X':
                    {
                        switch (input)
                        {
                            case 1:
                                if (IsEmpty(0, 0)) {
                                    board[0, 0] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 2:
                                if (IsEmpty(0, 1)) { 
                                    board[0, 1] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 3:
                                if (IsEmpty(0, 2)) {
                                    board[0, 2] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 4:
                                if(IsEmpty(1, 0)) {
                                    board[1, 0] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 5:
                                if(IsEmpty(1, 1)) {
                                    board[1, 1] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 6:
                                if(IsEmpty(1, 2)) {
                                    board[1, 2] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 7:
                                if(IsEmpty(2, 0)) {

                                    board[2, 0] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 8:
                                if(IsEmpty(2, 1)) { 
                                    board[2, 1] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            case 9:
                                if(IsEmpty(2, 2)) {
                                    board[2, 2] = 'X';
                                    player = SwitchPlayer('X');
                                }
                                break;
                            default: break;
                        }
                    }
                    break;
                case 'O':
                    {
                        switch (input)
                        {
                            case 1:
                                if (IsEmpty(0, 0))
                                {
                                    board[0, 0] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 2:
                                if (IsEmpty(0, 1))
                                {
                                    board[0, 1] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 3:
                                if (IsEmpty(0, 2))
                                {
                                    board[0, 2] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 4:
                                if (IsEmpty(1, 0))
                                {
                                    board[1, 0] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 5:
                                if (IsEmpty(1, 1))
                                {
                                    board[1, 1] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 6:
                                if (IsEmpty(1, 2))
                                {
                                    board[1, 2] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 7:
                                if (IsEmpty(2, 0))
                                {

                                    board[2, 0] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 8:
                                if (IsEmpty(2, 1))
                                {
                                    board[2, 1] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            case 9:
                                if (IsEmpty(2, 2))
                                {
                                    board[2, 2] = 'O';
                                    player = SwitchPlayer('O');
                                }
                                break;
                            default: break;
                        }
                    }
                    break;
            }
            return player;
        }
        public static bool Win()
        {
            for(int i = 0; i < board.GetLength(0); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }
            return false;
        }
        public static char SwitchPlayer(char player)
        {
            return player == 'X' ? 'O' : 'X';
        }
        public static void SetBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {board[0, 0]}  |  {board[0, 1]}  |  {board[0, 2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {board[1, 0]}  |  {board[1, 1]}  |  {board[1, 2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {board[2, 0]}  |  {board[2, 1]}  |  {board[2, 2]}  ");
            Console.WriteLine("     |     |     ");
        }
    }
}
