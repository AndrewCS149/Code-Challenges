string[] test1 = { "coder", "byte", "code" };
string[] test2 = { "hello", "world", "before", "all" };
string[] test3 = { "hello", "world", "after", "all" };
string[] test4 = { "hell", "bell", "dell", "gell" };

Console.WriteLine(Solution(test1));
Console.WriteLine(Solution(test2));
Console.WriteLine(Solution(test3));
Console.WriteLine(Solution(test4));


string Solution(string[] arr)
{
    List<string> list = new List<string>();
    list.Add(arr[0]);

    for (int i = 1; i < arr.Length; i++)
    {
        int j = 0;
        while (arr[i].Length <= list[j].Length && j < list.Count - 1)
            j++;

        if (j == list.Count - 1)
            list.Add(arr[i]);
        else
            list.Insert(j, arr[i]);

        if (list.Count == 3)
            return list[2];
    }

    return list[2];
}