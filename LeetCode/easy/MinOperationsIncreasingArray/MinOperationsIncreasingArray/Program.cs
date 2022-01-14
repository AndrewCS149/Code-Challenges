// https://leetcode.com/problems/minimum-operations-to-make-the-array-increasing/

Console.WriteLine(MinOperations(new int[] { 1, 1, 1 }));
Console.WriteLine(MinOperations(new int[] { 1, 5, 2, 4, 1 }));


static int MinOperations(int[] nums)
{
    int operations = 0;

    for (int i = 1; i < nums.Length; i++)
    {
        int prev = nums[i - 1];

        if (nums[i] <= prev)
        {
            operations += prev - nums[i] + 1;
            nums[i] += (prev - nums[i]) + 1;
        }
    }

    return operations;
}