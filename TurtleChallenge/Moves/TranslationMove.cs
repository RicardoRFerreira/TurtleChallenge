namespace TurtleChallenge.Moves;

public class TranslationMove : IMove
{
    public Position Move(Position position)
    {
        var newPosition = position.Orientation switch
        {
            "up" => position with { Tile = position.Tile.Above() },
            "down" => position with { Tile = position.Tile.Below() },
            "left" => position with { Tile = position.Tile.Left() },
            "right" => position with { Tile = position.Tile.Right() },
            _ => throw new NotImplementedException($"Orientation '{position.Orientation}' has not been implemented"),
        };
        Console.WriteLine($"Moved {newPosition.Orientation} to ({newPosition.Tile.X},{newPosition.Tile.Y}).");

        return newPosition;
    }
}
