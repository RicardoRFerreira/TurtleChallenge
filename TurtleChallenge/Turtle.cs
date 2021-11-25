using TurtleChallenge.Moves;

namespace TurtleChallenge;

public class Turtle
{
    private readonly List<IMove> _moves;
    private int _currentMove = 0;
    private Position _currentPosition;
    public bool IsOutOfMoves => _currentMove >= _moves.Count;

    public Turtle(List<IMove> moves, Position initialPosition)
    {
        _moves = moves;
        _currentPosition = initialPosition;
    }

    public Tile Move()
    {
        _currentPosition = _moves[_currentMove++].Move(_currentPosition);
        return _currentPosition.Tile;
    }

    public Tile GetPosition()
    {
        return _currentPosition.Tile;
    }
}
