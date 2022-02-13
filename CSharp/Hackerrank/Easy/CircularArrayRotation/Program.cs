/*
 link - https://www.hackerrank.com/challenges/circular-array-rotation/problem?isFullScreen=false

 NOTE - solution derived from online discussion forum
 */

List<int> test1 = new List<int>();
test1.Add(1);
test1.Add(4);
test1.Add(7);
test1.Add(5);
test1.Add(2);

List<int> q1 = new List<int>();
q1.Add(0);
q1.Add(1);
q1.Add(2);
q1.Add(3);
q1.Add(4);

List<int> res1 = circularArrayRotation(test1, 3, q1);

res1.ForEach(n => Console.WriteLine(n));



static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{
    int[] arr = new int[a.Count];

    for (int i = 0; i < a.Count; i++)
        arr[(i + k) % a.Count] = a[i];

    for (int i = 0; i < queries.Count; i++)
        queries[i] = arr[queries[i]];

    return queries;
}