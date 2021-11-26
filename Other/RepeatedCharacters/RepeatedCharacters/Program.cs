// See https://aka.ms/new-console-template for more information


static string RepeatedChars(char[] chars, int[] nums)
{
    string result = "";

    for (int i = 0; i < chars.Length; i++)
    {
        result = result.PadRight(result.Length + nums[i], chars[i]);
    }

    return result;
}

Console.WriteLine(RepeatedChars(new char[] { 'a', 'b', 'c' }, new int[] { 1, 2, 3 }));
Console.WriteLine(RepeatedChars(new char[] { 'h', 'e', 'l', 'o' }, new int[] { 1, 1, 2, 1 }));

//repeatedChars(['a', 'b', 'c'], [1,2,3]) => 'abbccc'
//repeatedChars(['h', 'e', 'l', 'o'], [1,1,2,1]) => 'hello'