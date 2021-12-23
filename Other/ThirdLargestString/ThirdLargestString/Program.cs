

string[] test1 = { "right", "righ", "rig", "right", "right", "Agt" };

Console.WriteLine(Solution(test1));

string Solution(string[] arr)
{
    List<string> list = new List<string>();
    list.Add(arr[0]);

    for (int i = 1; i < arr.Length; i++)
        Insert(list, arr[i]);

    return list[2];
}

void Insert(List<string> list, string str)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (!list.Contains(str))
        {
            if (str.Length > list[i].Length)
            {
                list.Insert(i, str);
                return;
            }
            else if (str.Length == list[i].Length)
            {
                list[i] = str;
                return;
            }
        }
    }

    list.Add(str);
}