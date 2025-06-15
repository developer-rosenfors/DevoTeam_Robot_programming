using Xunit;
using System;
using DevoTeamRobot; // Keep this if Robot is defined in DevoTeamRobot namespace

namespace DevoTeamRobot.Tests
{
    // Unit tests for the Robot class to verify movement, turning, and error handling
    public class RobotTests
    {
        [Fact]
        // Test that the robot executes a complex movement sequence and ends at the correct position and direction
        public void Robot_Executes_Movement_Correctly()
        {
            Robot robot = new Robot(1, 2, 'N', 5, 5);
            string result = robot.ExecuteCommands("RFRFFRFRF");
            Assert.Equal("Report: 1 3 N", result);
        }

        [Fact]
        // Test that the robot turns left from North and reports the correct direction (West)
        public void Robot_Turns_Left_Correctly()
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);
            robot.ExecuteCommands("L");
            Assert.Equal("Report: 1 1 W", robot.ExecuteCommands(""));
        }

        [Fact]
        // Test that the robot moves forward from (1,1) facing North and updates its position correctly
        public void Robot_Moves_Forward_Correctly()
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);
            Assert.Equal("Report: 1 2 N", robot.ExecuteCommands("F"));
        }

        [Fact]
        // Test that the robot throws an exception when moving out of the grid bounds
        public void Robot_Throws_Error_When_Moving_Out_Of_Bounds()
        {
            Robot robot = new Robot(0, 0, 'E', 5, 5);
            try
            {
                robot.ExecuteCommands("FFFFFFFF");
                Assert.True(false, "Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Contains("Out of bounds", ex.Message);
            }
        }

        [Fact]
        // Test that the robot throws an exception when an invalid command is given
        public void Robot_Handles_Invalid_Command()
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);
            try
            {
                robot.ExecuteCommands("X");
                Assert.True(false, "Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException ex)
            {
                Assert.Contains("Invalid command", ex.Message);
            }
        }
    }
}

