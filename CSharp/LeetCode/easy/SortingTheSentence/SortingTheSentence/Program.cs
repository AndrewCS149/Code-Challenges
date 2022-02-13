// https://leetcode.com/problems/sorting-the-sentence/

string test = "is2 sentence4 This1 a3";
Console.WriteLine(SortSentence(test));

static string SortSentence(string s)
{
    string[] strArr = s.Split(' ');
    string newStr = "";
    for (int i = 0; i < strArr.Length; i++)
    {
        // grab number from end
        int idx = int.Parse(strArr[i][strArr[i].Length - 1].ToString()) - 1;

        while (idx != i)
        {
            string tmp = strArr[idx];
            strArr[idx] = strArr[i];
            strArr[i] = tmp;
            idx = int.Parse(strArr[i][strArr[i].Length - 1].ToString()) - 1;
        }

        newStr += strArr[i].Remove(strArr[i].Length - 1) + " ";
    }

    newStr = newStr.Remove(newStr.Length - 1);
    s = newStr;

    return s;
}