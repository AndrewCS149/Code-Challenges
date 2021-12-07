// https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/

static int Solution(string n)
{
    return int.Parse(Convert.ToString(n.Max()));
}


Console.WriteLine(Solution("32"));
Console.WriteLine(Solution("82734"));
Console.WriteLine(Solution("27346209830709182346"));