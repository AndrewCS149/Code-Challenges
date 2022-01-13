// https://leetcode.com/problems/find-greatest-common-divisor-of-array/

static int FindGCD(int[] nums)
{
    int maxDivisor = 1;
    //int min = nums.Min();
    //int max = nums.Max();

    // no built in methods
    int min = nums[0];
    int max = nums[0];

    foreach (int num in nums)
    {
        if (num < min)
            min = num;

        if (num > max)
            max = num;
    }

    for (int i = 1; i <= min; i++)
    {
        if (min % i == 0 && max % i == 0)
            maxDivisor = i;
    }

    return maxDivisor;
}