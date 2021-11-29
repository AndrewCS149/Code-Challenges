/*
 https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?isFullScreen=false
 */


static int MinimumAbsoluteDifference(List<int> arr)
{
    arr.Sort();
    int minAbs = Math.Abs(arr[0] - arr[1]);

    for (int i = 0; i < arr.Count - 1; i++)
    {
        int tmp = Math.Abs(arr[i] - arr[i + 1]);
        if (tmp < minAbs)
        {
            minAbs = tmp;
        }
    }

    return minAbs;
}


// { 1, 2, 3, 4, 5, 6 } 
