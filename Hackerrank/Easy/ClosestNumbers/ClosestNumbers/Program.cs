using System;

class ClosestNumbers
{

    /*
     * Complete the 'closestNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    private static void Main(string[] args)
    {
        List<int> test1 = new List<int>();
        test1.Add(-20);
        test1.Add(-3916237);
        test1.Add(-357920);
        test1.Add(-3620601);
        test1.Add(7374819);
        test1.Add(-7330761);
        test1.Add(30);
        test1.Add(6246457);
        test1.Add(-6461594);
        test1.Add(266854);


        List<int> res1 = Numbers(test1);

        foreach (var num in res1)
            Console.Write(num + ", ");
    }


    public static List<int> Numbers(List<int> arr)
    {
        arr.Sort();
        List<int> result = new List<int>();
        result.Add(arr[0]);
        result.Add(arr[1]);

        long currentMinDiff = arr[1] - arr[0];

        for (int i = 1; i < arr.Count - 1; i++)
        {
            // replace result 
            long num1 = arr[i + 1];
            long num2 = arr[i];

            long diff = num1 - num2;
            if(diff < currentMinDiff)
            {
                result.Clear();
                result.Add(Convert.ToInt32(num2));
                result.Add(Convert.ToInt32(num1));
                currentMinDiff = diff;
            }
            // append to result
            else if(diff == currentMinDiff)
            {
                result.Add(Convert.ToInt32(num2));
                result.Add(Convert.ToInt32(num1));
            }
        }

        return result;
    }
}
