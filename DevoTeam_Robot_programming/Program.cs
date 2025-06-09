using System;

class Robot
{
    private int x, y;
    private char direction;
    private int width, depth;
    private readonly char[] directions = { 'N', 'E', 'S', 'W' };

    public Robot(int startX, int startY, char startDirection, int roomWidth, int roomDepth)
    {
        x = startX;
        y = startY;
        direction = startDirection;
        width = roomWidth;
        depth = roomDepth;
    }

    public void TurnLeft()
    {
        int index = Array.IndexOf(directions, direction);
        direction = directions[(index - 1 + directions.Length) % directions.Length];
    }

    public void TurnRight()
    {
        int index = Array.IndexOf(directions, direction);
        direction = directions[(index + 1) % directions.Length];
    }

    public void MoveForward()
    {
        switch (direction)
        {
            case 'N': y++; break;
            case 'E': x++; break;
            case 'S': y--; break;
            case 'W': x--; break;
        }

        if (x < 0 || x >= width || y < 0 || y >= depth)
        {
            throw new InvalidOperationException("Error: Robot moved out of bounds!");
        }
    }

    public string ExecuteCommands(string commands)
    {
        foreach (char command in commands)
        {
            switch (command)
            {
                case 'L': TurnLeft(); break;
                case 'R': TurnRight(); break;
                case 'F': MoveForward(); break;
                default: throw new ArgumentException($"Invalid command: {command}");
            }
        }
        return $"Report: {x} {y} {direction}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter room width and depth:");
        string[] roomSize = Console.ReadLine().Split();
        int roomWidth = int.Parse(roomSize[0]), roomDepth = int.Parse(roomSize[1]);

        Console.WriteLine("Enter starting position (X Y Direction):");
        string[] startPosition = Console.ReadLine().Split();
        int startX = int.Parse(startPosition[0]);
        int startY = int.Parse(startPosition[1]);
        char startDirection = char.Parse(startPosition[2]);

        Console.WriteLine("Enter navigation commands:");
        string commands = Console.ReadLine();

        Robot robot = new Robot(startX, startY, startDirection, roomWidth, roomDepth);
        Console.WriteLine(robot.ExecuteCommands(commands));
    }
}
