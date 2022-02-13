//https://leetcode.com/problems/rings-and-rods/

Console.WriteLine(CountPoints("B0B6G0R6R0R6G9"));

static int CountPoints(string rings)
{
    int points = 0;
    int[] arr = new int[10];
    var set = new HashSet<string>();

    for (int i = 0; i < rings.Length - 1; i += 2)
    {
        string pair = $"{rings[i]}{rings[i + 1]}";
        if (set.Add(pair))
        {
            int idx = int.Parse($"{pair[1]}");
            arr[idx]++;

            if (arr[idx] == 3)
                points++;
        }
    }

    return points;
}