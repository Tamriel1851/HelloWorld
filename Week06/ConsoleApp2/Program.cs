

// MAP
Console.WriteLine("Place JSON Here");

var savedGame = Console.ReadLine();

var map = new List<List<MapElement>>();

var turn = PlayerEnum.BLACK;

if (savedGame is { Length: > 0 })
{
    // todo load game data.
}
else
{
    for (var y = 0; y < 4; y++)
    {
        var yAxis = new List<MapElement>();

        for (var x = 0; x < 4; x++)
        {
            yAxis.Add(new MapElement());
        }

        map.Add(yAxis);
    }

    map[0][0] = new MapElement { Player = PlayerEnum.BLACK };
}

// RENDER

void Render()
{
    Console.Clear();
    Console.WriteLine($"Player {turn} turn");
    Console.WriteLine("--------");

    foreach (var yAxis in map)
    {
        var display = "";

        foreach (var xAxis in yAxis)
        {
            if (xAxis.Player == PlayerEnum.BLACK)
            {
                display += " B ";
            }
            else if (xAxis.Player == PlayerEnum.WHITE)
            {
                display += " W ";
            }
            else
            {
                display += "   ";
            }
        }

        Console.WriteLine(display);
    }

    Console.WriteLine("--------");
}

var choice = "";

// Game Loop

while (choice != "exit")
{
    // Call render every time the user submits a move.
    Render();

    choice = Console.ReadLine();

    turn = turn == PlayerEnum.BLACK ? PlayerEnum.WHITE : PlayerEnum.BLACK;
}


public enum PlayerEnum
{
    WHITE,
    BLACK
}

public class MapElement
{
    public PlayerEnum? Player { get; set; }
}