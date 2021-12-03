// https://www.hackerrank.com/challenges/jim-and-the-orders/problem?isFullScreen=false

static List<int> Orders(List<List<int>> orders)
{
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < orders.Count; i++)
    {
        int tmp = orders[i][0] + orders[i][1];
        dict.Add(i + 1, tmp);
    }

    var sortedDict = dict.OrderBy(x => x.Value);
    var result = sortedDict.ToDictionary(x => x.Key, x => x.Value).Keys.ToList();
    return result;
}

var test1 = new List<List<int>>();
test1.Add(new List<int> { 8, 1 });
test1.Add(new List<int> { 4, 1 });
test1.Add(new List<int> { 5, 6 });
test1.Add(new List<int> { 3, 1 });
test1.Add(new List<int> { 4, 3 });

Orders(test1);

/*
 
  result = {9, 5, 11, 4, 7}

 
 */