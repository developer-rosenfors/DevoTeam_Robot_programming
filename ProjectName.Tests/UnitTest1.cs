using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevoTeamRobot; // Added the namespace where the Robot class is defined

[TestClass]
public class MathTests
{
    [TestMethod]
    public void Should_Add_Two_Numbers()
    {
        int result = 2 + 3;
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Should_Check_If_String_Is_Correct()
    {
        string input = "Hello";
        Assert.AreEqual("Hello", input);
    }
    public void Robot_Executes_Movement_Correctly()
    {
        Robot robot = new Robot(1, 2, 'N', 5, 5); // Fixed the type to 'Robot'
        string result = robot.ExecuteCommands("RFRFFRFRF");
        Assert.Equal("Report: 1 3 N", result);
    }
}

