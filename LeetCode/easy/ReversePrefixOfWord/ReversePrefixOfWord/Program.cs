// https://leetcode.com/problems/reverse-prefix-of-word/

Console.WriteLine(ReversePrefix("abcdefd", 'd'));

static string ReversePrefix(string word, char ch)
{
    string result = "";

    for (int i = 0; i < word.Length; i++)
    {
        var j = word.IndexOf(ch);
        result += i <= j ? word[j - i] : word[i];
    }

    return result;
}