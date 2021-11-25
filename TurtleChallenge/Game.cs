namespace TurtleChallenge;

public class Game
{
    private readonly Board _board;
    private readonly Turtle _turtle;

    public Game(GameSettings settings, List<string> moveSequence)
    {
        _board = new Board(settings);
        _turtle = new Turtle(MoveFactory.CreateMoveList(moveSequence), settings.StartingPosition);
    }

    public void Start()
    {
        while (!_turtle.IsOutOfMoves)
        {
            var landingTile = _turtle.Move();
            var isMoveValid = ValidateLandingTile(landingTile);
            if (!isMoveValid)
            {
                return;
            }
        }
    }

    public bool ValidateLandingTile(Tile landingTile)
    {
        if (_board.IsExitPoint(landingTile))
        {
            Console.WriteLine("Success!");
            return false;
        }

        if (_board.IsMine(landingTile))
        {
            Console.WriteLine("Mine hit!");
            return false;
        }

        if (_board.IsOutOfBounds(landingTile))
        {
            Console.WriteLine("Out of Bounds!");
            return false;
        }

        if (_turtle.IsOutOfMoves)
        {
            Console.WriteLine("Still in danger!");
            return false;
        }

        return true;
    }
}
