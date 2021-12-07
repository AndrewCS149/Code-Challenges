// https://leetcode.com/problems/final-value-of-variable-after-performing-operations/

static int Solution(string[] operations)
{
    int result = 0;

    Array.ForEach(operations, val =>
    {
        result += val.Contains('+') ? 1 : -1;
    });

    return result;
}

string[] testCase = { "--X", "X++", "X++" };
string[] testCase2 = { "++X", "++X", "X++" };

Console.WriteLine(Solution(testCase));
Console.WriteLine(Solution(testCase2));