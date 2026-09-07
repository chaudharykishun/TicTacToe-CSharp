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

        public bool IsGameOver { get; private set; }

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
            // Prevent a move outside the board
            if (row < 0 || row > 2 || column < 0 || column > 2)
            {
                return false;
            }

            // Prevent a player from using an occupied square
            if (board[row, column] != Player.None)
            {
                return false;
            }

            // Store the current player's move
            board[row, column] = CurrentPlayer;

            SwitchPlayer();

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
            IsGameOver = false;
        }
    }
}