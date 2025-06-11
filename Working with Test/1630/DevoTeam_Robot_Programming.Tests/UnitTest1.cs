using Xunit;
using System;
using DevoTeamRobot; // Added the namespace where the Robot class is defined


namespace DevoTeamRobot.Tests
{
    public class Robot
    {
        private int v1;
        private int v2;
        private char v3;
        private int v4;
        private int v5;

        public Robot(int v1, int v2, char v3, int v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }


        [Fact]
        public void Robot_Executes_Movement_Correctly()
        {
            Robot robot = new Robot(1, 2, 'N', 5, 5); // Fixed the type to 'Robot'
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

        private string ExecuteCommands(string v)
        {
            throw new NotImplementedException();
        }
    }
}

