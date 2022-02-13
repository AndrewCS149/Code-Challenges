// https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/

int[] Solution(string boxes)
{
    int[] operations = new int[boxes.Length];

    for (int i = 0; i < boxes.Length; i++)
    {
        int tmp = 0;
        for (int j = 0; j < boxes.Length; j++)
        {
            if (i == j) continue;

            if (boxes[j] == '1')
                tmp += Math.Abs(i - j);
        }

        operations[i] = tmp;
    }

    return operations;
}