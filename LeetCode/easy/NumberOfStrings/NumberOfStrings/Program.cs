// https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/

string[] patterns = { "a", "b", "c" };
string word = "aaaaabbbbbb";

Console.WriteLine(NumOfStrings(patterns, word));


static int NumOfStrings(string[] patterns, string word)
{
    int count = 0;

    foreach (string str in patterns)
    {
        for (int i = 0; i <= word.Length - str.Length; i++)
        {
            string tmp = word.Substring(i, str.Length);

            if (str == tmp)
            {
                count++;
                break;
            }
        }


        //if (word.Contains(str))
        //    count++;
    }

    return count;
}