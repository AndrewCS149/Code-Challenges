// See https://aka.ms/new-console-template for more information

separateNumbers("91011");

static void separateNumbers(string s)
{
    if(s.Length <= 1)
    {
        Console.WriteLine("NO");
        return;
    }

    List<string> result = new List<string>();

    // Add first number to list
    int i = 0;
    string num = "";
    do
    {
        num += s[i];
        i++;
    } while (int.Parse(s[i].ToString()) == 9);

    result.Add(num);
    num = "";
    for (; i < s.Length;)
    {
        do
        {
            num += s[i];
            i++;
        } while (int.Parse(s[i - 1].ToString()) == 9);

        result.Add(num);
        num = "";
    }

    for (i = 0; i < result.Count - 1; i++)
    {
        if(int.Parse(result[i].ToString()) + 1 != int.Parse(result[i + 1].ToString()))
        {
            Console.WriteLine("NO");
            return;
        }
    }
    Console.WriteLine("YES " + result[0]);
}