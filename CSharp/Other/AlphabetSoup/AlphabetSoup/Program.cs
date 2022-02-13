/*
 take in the str param and return the string with the letters in alpha order.
 */

string Solution(string str)
{
    string result = "";

    var test = str.OrderBy(x => x);
    foreach (var ch in test)
    {
        result += ch;
    }

    return result;
}

string Solution2(string str)
{
    string result = "";

    string[] arr = new string[26];
    for(int i = 0; i < str.Length; i++)
    {
        arr[(int)str[i] - 97] += str[i];
    }

    foreach (string item in arr)
    {
        result += item;
    }

    return result;
}

Console.WriteLine(Solution2("coderbyte"));