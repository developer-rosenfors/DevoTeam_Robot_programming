using Xunit;
using System;
using DevoTeam_Robot_programming.Models; // Ensure the correct namespace is imported

namespace DevoTeam_Robot_programming.Tests
{
    public class RobotTests
    {
        [Fact]
        public void Robot_Executes_Movement_Correctly()
        {
            Robot robot = new Robot(1, 2, 'N', 5, 5);
            string result = robot.ExecuteCommands("RFRFFRFRF");
            Assert.Equal("Report: 1 3 N", result);
        }

        [Fact]
        public void Robot_Turns_Left_Correctly()
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);
            robot.ExecuteCommands("L");
            Assert.Equal("Report: 1 1 W", robot.ExecuteCommands(""));
        }

        [Fact]
        public void Robot_Turns_Right_Correctly()
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);
            robot.ExecuteCommands("R");
            Assert.Equal("Report: 1 1 E", robot.ExecuteCommands(""));
        }

        [Fact]
        public void Robot_Moves_Forward_Correctly()
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);
            robot.ExecuteCommands("F");
            Assert.Equal("Report: 1 2 N", robot.ExecuteCommands(""));
        }

        [Fact]
        public void Robot_Throws_Error_When_Moving_Out_Of_Bounds()
        {
            Robot robot = new Robot(0, 0, 'E', 5, 5);
            Assert.Throws<InvalidOperationException>(() => robot.ExecuteCommands("FFFFFFFF"));
        }

        [Fact]
        public void Robot_Handles_Invalid_Command()
        {
            Robot robot = new Robot(1, 1, 'N', 5, 5);
            Assert.Throws<ArgumentException>(() => robot.ExecuteCommands("X"));
        }
    }
}

