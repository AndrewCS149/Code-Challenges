using System;

namespace Goal_Parser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Interpret(string command)
        {
            string newStr = "";

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'G')
                {
                    newStr += 'G';
                }
                else if (command[i] == '(' && command[i + 1] == ')')
                {
                    newStr += 'o';
                    i++;
                }
                else if (command[i] == '(' && command[i + 1] == 'a')
                {
                    newStr += "al";
                    i += 2;
                }
            }

            return newStr;
        }
    }
}