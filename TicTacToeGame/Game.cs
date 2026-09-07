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