namespace TurtleChallenge;

public record Tile(int X, int Y)
{
    public Tile Above() => this with { Y = Y + 1 };
    public Tile Below() => this with { Y = Y - 1 };
    public Tile Left() => this with { X = X - 1 };
    public Tile Right() => this with { X = X + 1 };
}
