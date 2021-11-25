// See https://aka.ms/new-console-template for more information
/*
 Easy

 Link - https://www.hackerrank.com/challenges/acm-icpc-team/problem?isFullScreen=false
 */

using System.Collections;
static List<int> acmTeam(List<string> topic)
{
    List<int> list = new List<int>();
    Dictionary<int, int> dict = new Dictionary<int, int>();
    int maxTopics = 0;
    for(int i = 0; i < topic.Count; i++)
    {
        for (int j = i + 1; j < topic.Count; j++)
        {
            int topics = 0;
            for (int k = 0; k < topic[i].Length; k++)
            {
                if(topic[i][k] == '1' || topic[j][k] == '1')
                {
                    topics++;
                }
            }
            if(topics > maxTopics) maxTopics = topics; 
            
            if(dict.ContainsKey(topics))
            {
                dict[topics]++;
            } 
            else
            {
                dict.Add(topics, 1);
            }
        }

    }

    list.Add(maxTopics);
    list.Add(dict[maxTopics]);

    return list;
}


string[] topics = { "10101", "11110", "00010" };
Console.WriteLine(acmTeam(topics.ToList()));