// https://leetcode.com/problems/a-number-after-a-double-reversal/

Console.WriteLine(IsSameAfterReversals(526));
Console.WriteLine(IsSameAfterReversals(1800));
Console.WriteLine(IsSameAfterReversals(0));


static bool IsSameAfterReversals(int num)
{
    string str = num.ToString();
    return str[str.Length - 1] != '0' || num == 0;
}