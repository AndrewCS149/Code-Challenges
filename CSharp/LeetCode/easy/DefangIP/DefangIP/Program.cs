using System;

namespace DefangIP
{
    class Program
    {
        // link - https://leetcode.com/problems/defanging-an-ip-address/submissions/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
