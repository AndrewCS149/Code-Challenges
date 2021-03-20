using System;

namespace RobotOrigin
{
    // https://leetcode.com/problems/robot-return-to-origin/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;
            foreach (char ch in moves)
            {
                if (ch == 'U') x++;
                else if (ch == 'D') x--;
                else if (ch == 'L') y--;
                else y++;
            }

            return x == 0 && y == 0 ? true : false;
        }
    }
}
