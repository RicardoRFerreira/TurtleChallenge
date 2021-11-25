// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using TurtleChallenge;

var gameSettings = ReadSettingsFile<GameSettings>("game-settings");
var moveSettings = ReadSettingsFile<MoveSettings>("moves");

int sequenceNumber = 1;
foreach (var moveSequence in moveSettings.Moves)
{
    Console.WriteLine($"Sequence {sequenceNumber++}");
    var game = new Game(gameSettings, moveSequence);
    game.Start();
    Console.WriteLine();
}

static T ReadSettingsFile<T>(string settingsFilePath)
{
    var options = new JsonSerializerOptions();
    options.PropertyNameCaseInsensitive = true;

    var fileContent = File.ReadAllText(settingsFilePath);
    var readSettings = JsonSerializer.Deserialize<T>(fileContent, options);
    if (readSettings == null)
    {
        throw new Exception("Unable to read settings file.");
    }
    return readSettings;
}