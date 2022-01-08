//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

//RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
RemoveDuplicates(new int[] { 1, 1, 2, 3, 4, 4, 5, 6 });


int RemoveDuplicates(int[] nums)
{
    //var hashset = new HashSet<int>();
    //for (int i = 0; i < nums.Length; i++)
    //{
    //    int j = 0;
    //    while (!hashset.Add(nums[i]))
    //    {
    //        j++;

    //        if (i + j < nums.Length)
    //            nums[i] = nums[i + j];
    //        else
    //            break;
    //    }
    //}

    //return hashset.Count;

    // online solution
    if (nums.Length <= 1) return nums.Length;
    int i = 1, j = 1;
    while (j < nums.Length)
    {
        if (nums[j] != nums[i - 1])
        {
            nums[i] = nums[j];
            i++;
        }
        j++;
    }
    return i;
}