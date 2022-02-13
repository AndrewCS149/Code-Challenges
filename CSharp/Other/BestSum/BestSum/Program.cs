/*
 Write a function BestSum(targetSum, numbers) that takes in a targetSum and an array of numbers as arguments

the function should return an array containing the shortest combination of numbers that add up to exactly the targetSum

If there is a tie for the shortest combination, you may return one of the shortest
 */


var res = BSum(7, new int[] { 5, 3, 4, 7 });
PrintList(res);

var res3 = BSum(8, new int[] { 2, 3, 5 });
PrintList(res3);

//var res2 = BSum(300, new int[] { 7, 14 });
//PrintList(res2);

var res4 = BSum(100, new int[] { 25, 7, 14, 3 });
PrintList(res4);


static void PrintList(List<int> list)
{
    if (list == null)
        Console.Write("null");
    else
        foreach (int n in list) { Console.Write(n + ", "); }
    Console.WriteLine();
}

static List<int> BSum(int targetNum, int[] numbers, Dictionary<int, List<int>> memo = null)
{
    if (memo == null) memo = new Dictionary<int, List<int>>();
    if (targetNum == 0) return new List<int>();
    if (targetNum < 0) return null;

    List<int> shortestComb = null;
    foreach (int num in numbers)
    {
        var result = BSum(targetNum - num, numbers, memo);
        if (result != null)
        {
            result.Add(num);
            if (shortestComb == null || result.Count < shortestComb.Count)
                shortestComb = result;
        }
    }

    memo[targetNum] = shortestComb;
    return shortestComb;
}
