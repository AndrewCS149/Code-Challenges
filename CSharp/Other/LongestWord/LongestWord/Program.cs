/*
 Write a method that takes in an array of strings and outputs the longest word in that string. If there are two word with equal length, output the first one. Ignore puncuation.
 */
using System.Text.RegularExpressions;

static string ReturnLongestWord(string[] arr)
{
    string result = arr[0];

    foreach (string word in arr)
    {
        string tmpWord = Regex.Replace(word, @"[^\w\s]", "");
        if (tmpWord.Length > result.Length)
        {
            result = word;
        }
    }

    return result;
}

var test1 = new string[] { "hello", "world", "whatsupp", "!!!!!!dontDoIt", "nice" };
Console.WriteLine(ReturnLongestWord(test1));