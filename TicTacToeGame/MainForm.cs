namespace TicTacToeGame
{
    public partial class MainForm : Form
    {
        private readonly Game game;
        private readonly Button[,] boardButtons;

        public MainForm()
        {
            InitializeComponent();

            game = new Game();

            boardButtons = new Button[,]
            {
                { btn00, btn01, btn02 },
                { btn10, btn11, btn12 },
                { btn20, btn21, btn22 }
            };

            ConnectBoardButtons();

            btnNewGame.Click += BtnNewGame_Click;

            UpdateStatus();
        }

        private void ConnectBoardButtons()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    int selectedRow = row;
                    int selectedColumn = column;

                    boardButtons[row, column].Click +=
                        (sender, e) => HandleMove(selectedRow, selectedColumn);
                }
            }
        }

        private void HandleMove(int row, int column)
        {
            Player playerMakingMove = game.CurrentPlayer;

            bool validMove = game.MakeMove(row, column);

            if (!validMove)
            {
                MessageBox.Show(
                    "That square is already occupied. Choose another square.",
                    "Invalid Move",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            boardButtons[row, column].Text = playerMakingMove.ToString();

            if (game.IsGameOver && game.Winner != Player.None)
            {
                lblStatus.Text = $"Player {game.Winner} Wins!";

                DisableBoard();

                MessageBox.Show(
                    $"Player {game.Winner} wins the game!",
                    "Game Over",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (game.IsDraw)
            {
                lblStatus.Text = "It's a Draw!";

                DisableBoard();

                MessageBox.Show(
                    "The game ended in a draw.",
                    "Game Over",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblStatus.Text = $"Player {game.CurrentPlayer}'s Turn";
        }


        private void DisableBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    boardButtons[row, column].Enabled = false;
                }
            }
        }

        private void BtnNewGame_Click(object? sender, EventArgs e)
        {
            game.ResetGame();

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    boardButtons[row, column].Text = string.Empty;
                    boardButtons[row, column].Enabled = true;
                }
            }

            UpdateStatus();
        }

    }
}