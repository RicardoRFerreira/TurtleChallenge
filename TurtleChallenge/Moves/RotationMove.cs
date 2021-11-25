namespace TurtleChallenge.Moves;

public class RotationMove : IMove
{
    public Position Move(Position position)
    {
        var newPosition = position.Orientation switch
        {
            "up" => position with { Orientation = "right" },
            "right" => position with { Orientation = "down" },
            "down" => position with { Orientation = "left" },
            "left" => position with { Orientation = "up" },
            _ => throw new NotImplementedException($"Orientation '{position.Orientation}' has not been implemented"),
        };
        Console.WriteLine($"Rotated {newPosition.Orientation}.");

        return newPosition;
    }
}
