using TurtleChallenge.Moves;

namespace TurtleChallenge;

public static class MoveFactory
{
    public static List<IMove> CreateMoveList(List<string> moves)
    {
        return moves.Select(move => CreateMove(move)).ToList();
    }

    public static IMove CreateMove(string move)
    {
        switch (move)
        {
            case "m":
                return CreateTranslationMove();
            case "r":
                return CreateRotationMove();
            default:
                throw new ArgumentException($"Move '{move}' is not a valid move.");
        }
    }

    public static IMove CreateRotationMove()
    {
        return new RotationMove();
    }

    public static IMove CreateTranslationMove()
    {
        return new TranslationMove();
    }
}
