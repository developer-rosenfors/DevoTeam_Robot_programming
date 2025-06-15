using System;

namespace DevoTeam_Robot_programming
{
    // Represents a robot that can move and turn within a bounded room
    class Robot
    {
        private int x, y; // Current position of the robot
        private char direction; // Current direction ('N', 'E', 'S', 'W')
        private int width, depth; // Room dimensions
        private readonly char[] directions = { 'N', 'E', 'S', 'W' }; // Order of directions for turning

        // Initializes the robot with starting position, direction, and room size
        public Robot(int startX, int startY, char startDirection, int roomWidth, int roomDepth)
        {
            x = startX;
            y = startY;
            direction = startDirection;
            width = roomWidth;
            depth = roomDepth;
        }

        // Turns the robot left (counter-clockwise)
        public void TurnLeft()
        {
            int index = Array.IndexOf(directions, direction);
            direction = directions[(index - 1 + directions.Length) % directions.Length];
        }

        // Turns the robot right (clockwise)
        public void TurnRight()
        {
            int index = Array.IndexOf(directions, direction);
            direction = directions[(index + 1) % directions.Length];
        }

        // Moves the robot forward in the current direction
        public void MoveForward()
        {
            switch (direction)
            {
                case 'N': y++; break;
                case 'E': x++; break;
                case 'S': y--; break;
                case 'W': x--; break;
            }

            // Check if the robot is out of bounds after moving
            if (x < 0 || x >= width || y < 0 || y >= depth)
            {
                throw new InvalidOperationException("Error: Robot moved out of bounds!");
            }
        }

        // Executes a sequence of commands and returns the final state
        public string ExecuteCommands(string commands)
        {
            // Validate all commands before executing
            foreach (char command in commands)
            {
                if (command != 'L' && command != 'R' && command != 'F')
                {
                    throw new ArgumentException($"Invalid command: {command}");
                }
            }

            // Execute each command in order
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L': TurnLeft(); break;
                    case 'R': TurnRight(); break;
                    case 'F': MoveForward(); break;
                }
            }
            // Return the robot's final position and direction
            return $"Report: {x} {y} {direction}";
        }
    }

    class Program
    {
        // Entry point for the application
        static void Main()
        {
            while (true)
            {
                try
                {
                    // Room size input and validation
                    Console.WriteLine("Enter room width and depth:");
                    string[] roomSize = Console.ReadLine().Split();
                    if (roomSize.Length != 2 ||
                        !int.TryParse(roomSize[0], out int roomWidth) ||
                        !int.TryParse(roomSize[1], out int roomDepth) ||
                        roomWidth <= 0 || roomDepth <= 0)
                    {
                        Console.WriteLine("Invalid room size. Please enter two positive integers.");
                        continue;
                    }

                    // Starting position input and validation
                    Console.WriteLine("Enter starting position (X Y Direction):");
                    string[] startPosition = Console.ReadLine().Split();
                    if (startPosition.Length != 3 ||
                        !int.TryParse(startPosition[0], out int startX) ||
                        !int.TryParse(startPosition[1], out int startY) ||
                        !char.TryParse(startPosition[2], out char startDirection) ||
                        "NESW".IndexOf(startDirection) == -1)
                    {
                        Console.WriteLine("Invalid starting position. Please enter two integers and a direction (N, E, S, W).");
                        continue;
                    }

                    // Command input
                    Console.WriteLine("Enter navigation commands:");
                    string commands = Console.ReadLine();

                    // Create a robot and execute the commands
                    Robot robot = new Robot(startX, startY, startDirection, roomWidth, roomDepth);
                    Console.WriteLine(robot.ExecuteCommands(commands));
                    break; // Success, exit loop
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Argument error: " + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Operation error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error: " + ex.Message);
                }

                Console.WriteLine("Please try again.\n");
            }
        }
    }
}
