// https://www.hackerrank.com/challenges/priyanka-and-toys/problem?isFullScreen=false

/*
 {2, 4, 3, 8, 10, 12, 5}

1. Sort    
 {2, 3, 4, 5, 8, 10, 12}

2.
 
 */

static int Toys(List<int> w)
{
    //int containers = 1;

    //w.Sort();
    //int currentMin = w[0];
    //int units = 0;

    //for (int i = 1; i < w.Count; i++)
    //{
    //    int tmp = w[i];
    //    if (units == 4 || w[i] > currentMin + 4)
    //    {
    //        units = 0;
    //        containers++;
    //        currentMin = w[i];
    //    }
    //    else
    //    {
    //        units++;
    //    }

    // online solution

    w.Sort();
    int weight = w[0] + 4;
    int containers = 1;

    for (int i = 1; i < w.Count; i++)
    {
        if (w[i] > weight)
        {
            containers++;
            weight = w[i] + 4;
        }
    }

    return containers;
}

