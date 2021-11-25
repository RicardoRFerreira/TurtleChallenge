using System.Collections.ObjectModel;

namespace TurtleChallenge;

public class Board
{
    private readonly ReadOnlyCollection<Tile> _mines;
    private readonly Tile _exitPoint;
    private readonly BoardDimensions _dimensions;

    public Board(GameSettings settings)
    {
        _dimensions = settings.Board;
        _mines = settings.Mines.AsReadOnly();
        _exitPoint = settings.ExitPoint;
    }

    public bool IsOutOfBounds(Tile tile)
    {
        return tile.X > _dimensions.Width || tile.Y > _dimensions.Height || tile.X < 1 || tile.Y < 1;
    }

    public bool IsMine(Tile tile)
    {
        return _mines.Contains(tile);
    }

    public bool IsExitPoint(Tile tile)
    {
        return _exitPoint == tile;
    }
}
