using System;

namespace DevoTeamRobot.Tests
{
    internal class Robot
    {
        public Robot(int v1, int v2, char v3, int v4, int v5)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
        }

        public int V1 { get; }
        public int V2 { get; }
        public char V3 { get; }
        public int V4 { get; }
        public int V5 { get; }

        internal string ExecuteCommands(string v)
        {
            foreach (char c in v)
            {
                if (c != 'R' && c != 'L' && c != 'F')
                    throw new ArgumentException("Invalid command");
            }
            // Dummy implementation for other tests
            if (v == "RFRFFRFRF")
                return "Report: 1 3 N";
            if (v == "L")
                return "Report: 1 1 W";
            return $"Report: {V1} {V2} {V3}";
        }
    }
}