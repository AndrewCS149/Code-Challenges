// https://leetcode.com/problems/build-array-from-permutation/

int[] Solution(int[] nums)
{
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = nums[nums[i]];
    }

    return result;
}



int[] test = { 0, 2, 1, 5, 3, 4 };
Solution(test);
