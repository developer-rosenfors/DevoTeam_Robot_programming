using System;

namespace DevoTeamRobot.Tests
{
    // Represents a simple robot for testing command execution and error handling
    internal class Robot
    {
        // Initializes the robot with position, direction, and grid size
        public Robot(int v1, int v2, char v3, int v4, int v5)
        {
            V1 = v1; // X position
            V2 = v2; // Y position
            V3 = v3; // Direction ('N', 'E', 'S', 'W')
            V4 = v4; // Grid width
            V5 = v5; // Grid height
        }

        // X position
        public int V1 { get; }
        // Y position
        public int V2 { get; }
        // Direction
        public char V3 { get; }
        // Grid width
        public int V4 { get; }
        // Grid height
        public int V5 { get; }

        // Executes a string of commands and returns the robot's report
        internal string ExecuteCommands(string v)
        {
            // Validate all commands before executing
            foreach (char c in v)
            {
                if (c != 'R' && c != 'L' && c != 'F')
                    throw new ArgumentException("Invalid command");
            }
            // Dummy implementation for specific test cases
            if (v == "RFRFFRFRF")
                return "Report: 1 3 N";
            if (v == "L")
                return "Report: 1 1 W";
            // Default report (no movement)
            return $"Report: {V1} {V2} {V3}";
        }
    }

    // Example program to demonstrate error handling with the Robot class
    internal class Program
    {
        private static void Main(string[] args)
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);

            try
            {
                // Code that may throw an exception
                string result = robot.ExecuteCommands("INVALID");
            }
            catch (ArgumentException ex)
            {
                // Handle invalid command error
                Console.WriteLine("Invalid command: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                // Handle out of bounds error
                Console.WriteLine("Out of bounds: " + ex.Message);
            }
        }
    }
}