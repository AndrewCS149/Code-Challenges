//https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/

int[] groupSizes = { 2, 1, 3, 3, 3, 2 };
int[] groupSizes2 = { 3, 3, 3, 3, 3, 1, 3 };

var rest = GroupThePeople(groupSizes);
var rest2 = GroupThePeople(groupSizes2);

static IList<IList<int>> GroupThePeople(int[] groupSizes)
{
    IList<IList<int>> result = new List<IList<int>>();

    for (int i = 0; i < groupSizes.Length; i++)
    {
        var group = new List<int>();
        int tmp = groupSizes[i];
        for (int j = i, k = 1; j < groupSizes.Length; j++)
        {
            if (groupSizes[j] == tmp && groupSizes[j] != 0 && k <= tmp)
            {
                group.Add(Array.IndexOf(groupSizes, groupSizes[j]));
                groupSizes[j] = 0;
                k++;
            }
        }

        if (group.Count > 0)
            result.Add(group);
    }

    return result;
}