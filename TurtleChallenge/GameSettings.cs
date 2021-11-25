using System.Collections.ObjectModel;

namespace TurtleChallenge;

public class GameSettings
{
    public BoardDimensions Board { get; init; }
    public Position StartingPosition { get; init; }
    public Tile ExitPoint { get; init; }
    public List<Tile> Mines { get; init; }
}
