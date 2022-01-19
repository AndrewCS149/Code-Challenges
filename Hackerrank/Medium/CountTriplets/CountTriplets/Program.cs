// https://www.hackerrank.com/challenges/count-triplets-1/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
Console.WriteLine(CountTriplets(new List<long> { 1, 2, 2, 4 }, 2));

static long CountTriplets(List<long> arr, long r)
{
    long count = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        int tmpCount = 1;
        long tmp = arr[i];
        for (int j = i + 1; j < arr.Count; j++)
        {
            if (tmpCount >= 3)
                break;

            if (arr[j] > tmp)
            {
                tmp = arr[j];
                tmpCount++;
            }
        }

        if (tmpCount >= r)
            count++;
    }

    return count;
}