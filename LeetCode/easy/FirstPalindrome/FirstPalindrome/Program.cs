// https://leetcode.com/problems/find-first-palindromic-string-in-the-array/

string[] test = { "abc", "car", "ada", "racecare", "cool" };
Console.WriteLine(FirstPalindrome(test));

static string FirstPalindrome(string[] words)
{
    foreach (string word in words)
    {
        // built in methods
        //char[] arr = word.ToCharArray();
        //Array.Reverse(arr);

        //if (new string(arr) == word)
        //    return word;

        // no built in methods
        string reverse = "";
        for (int i = word.Length - 1; i >= 0; i--)
            reverse += word[i];

        if (reverse == word)
            return word;
    }


    return "";
}