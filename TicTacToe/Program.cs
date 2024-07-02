



var board = new char[3, 3]
{
    { 'O', 'X', 'O' },
    { 'X', 'X', 'O' },
    { 'O', 'X', 'X' }
};

char player = 'O';

TicTacToe ticTacToe = new TicTacToe(board);
if (ticTacToe.isWonBy(player))
{
    Console.WriteLine($"{player} won!");
}
else
{
    Console.WriteLine($"{player} lose!");
}

class TicTacToe
{
    private readonly char[,] _board = new char[3, 3];
    public TicTacToe(char[,] board)
    {
        _board = board;
    }
    public bool isWonBy(char player)
    {
        return 
            isAnyRowFilledWith(player) ||
            isAnyColumnFilledwith(player) ||
            isDiagonalsFilledWith(player);
    }

    private bool isDiagonalsFilledWith(char player)
    {
        if ((_board[0, 2] == player &&
            _board[1, 1] == player &&
            _board[2, 0] == player)||
            (_board[0,0] == player &&
            _board[1, 1] == player &&
            _board[2, 2] == player))
        {
            return true;
        }
        return false;
    }

    private bool isAnyColumnFilledwith(char player)
    {
        for (int columnIndex = 0; columnIndex < 3; columnIndex++)
        {
            if (_board[0, columnIndex] == player &&
                _board[1, columnIndex] == player &&
                _board[2, columnIndex] == player)
            {
                return true;
            }
        }
        return false;
    }

    private bool isAnyRowFilledWith(char player)
    {
        for (int rowIndex = 0; rowIndex < 3; rowIndex++)
        {
            if (_board[rowIndex, 0] == player &&
                _board[rowIndex, 1] == player &&
                _board[rowIndex, 2] == player)
            {
                return true;
            }
        }
        return false;
    }
}