// https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/

int Solution(string[] sentences)
{
    int result = 0;

    // using 'split()'
    //foreach (string sentence in sentences)
    //{
    //    int words = sentence.Split(' ').Count();
    //    if (words > result)
    //        result = words;
    //}

    // not using 'split()'
    foreach (string sentence in sentences)
    {
        int tmp = 0;
        for (int i = 0; i < sentence.Length; i++)
            if (sentence[i] == ' ') tmp++;

        if (tmp > result)
            result = tmp;
    }

    return result + 1;
}