// given a 2d matrix of n x m, return the amount of ways you can traverse from the upmost left square to the bottommost right square. 
// The only two directions you can move at a time is down or right.


Console.WriteLine(Traverse(2, 3));
Console.WriteLine(Traverse(3, 3));
Console.WriteLine(Traverse(18, 18));



static long Traverse(long m, long n, Dictionary<string, long> dict = null)
{
    string key = $"{m},{n}";

    if (dict == null)
        dict = new Dictionary<string, long>();

    if (dict.ContainsKey(key)) return dict[key];

    if (m == 1 && n == 1) return 1;
    if (m == 0 || n == 0) return 0;

    dict[key] = Traverse(m - 1, n, dict) + Traverse(m, n - 1, dict);
    return dict[key];
}