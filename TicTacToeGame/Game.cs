namespace TicTacToeGame
{
    public enum Player
    {
        None,
        X,
        O
    }

    public class Game
    {
        private readonly Player[,] board;

        public Player CurrentPlayer { get; private set; }

        public Player Winner { get; private set; }

        public bool IsGameOver { get; private set; }

        public bool IsDraw { get; private set; }

        public Game()
        {
            board = new Player[3, 3];
            ResetGame();
        }

        public Player GetCell(int row, int column)
        {
            return board[row, column];
        }

        public bool MakeMove(int row, int column)
        {
            // Do not allow moves after the game has ended
            if (IsGameOver)
            {
                return false;
            }

            // Make sure the selected position is inside the board
            if (row < 0 || row > 2 || column < 0 || column > 2)
            {
                return false;
            }

            // Do not allow a player to use an occupied square
            if (board[row, column] != Player.None)
            {
                return false;
            }

            // Store the player's move
            board[row, column] = CurrentPlayer;

            // Check whether this move produced a winner
            if (CheckWinner(CurrentPlayer))
            {
                Winner = CurrentPlayer;
                IsGameOver = true;
                return true;
            }

            if (CheckDraw())
            {
                IsDraw = true;
                IsGameOver = true;
                return true;
            }

            SwitchPlayer();

            return true;
        }

        private bool CheckWinner(Player player)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == player &&
                    board[row, 1] == player &&
                    board[row, 2] == player)
                {
                    return true;
                }
            }

            // Check columns
            for (int column = 0; column < 3; column++)
            {
                if (board[0, column] == player &&
                    board[1, column] == player &&
                    board[2, column] == player)
                {
                    return true;
                }
            }

            // Check diagonal from top-left to bottom-right
            if (board[0, 0] == player &&
                board[1, 1] == player &&
                board[2, 2] == player)
            {
                return true;
            }

            // Check diagonal from top-right to bottom-left
            if (board[0, 2] == player &&
                board[1, 1] == player &&
                board[2, 0] == player)
            {
                return true;
            }

            return false;
        }

        private bool CheckDraw()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[row, column] == Player.None)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void SwitchPlayer()
        {
            if (CurrentPlayer == Player.X)
            {
                CurrentPlayer = Player.O;
            }
            else
            {
                CurrentPlayer = Player.X;
            }
        }

        public void ResetGame()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[row, column] = Player.None;
                }
            }

            CurrentPlayer = Player.X;
            Winner = Player.None;
            IsGameOver = false;
            IsDraw = false;
        }
    }
}