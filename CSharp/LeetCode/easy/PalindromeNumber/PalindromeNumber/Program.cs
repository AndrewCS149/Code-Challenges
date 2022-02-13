// link - https://leetcode.com/problems/palindrome-number/



bool Solution(int num)
{
    string str = num.ToString();

    for (int i = 0; i < str.Length / 2; i++)
    {
        char char1 = str[i];
        char char2 = str[str.Length - 1 - i];

        if (char1 != char2)
            return false;
    }

    return true;
}

// now without converting to string
Console.WriteLine(Solution2(-222));
bool Solution2(int num)
{
    int tmp = num;
    int reverseNum = 0;
    while (tmp > 0)
    {
        int last = tmp % 10;
        tmp /= 10;
        reverseNum = reverseNum * 10 + last;
    }

    return num == reverseNum;
}