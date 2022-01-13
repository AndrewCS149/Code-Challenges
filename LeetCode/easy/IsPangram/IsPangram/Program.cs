// https://leetcode.com/problems/check-if-the-sentence-is-pangram/

Console.WriteLine(CheckIfPangram("thequickbrownfoxjumpedoverthelazydog"));

static bool CheckIfPangram(string sentence)
{
    var hashset = new HashSet<char>();

    foreach (char c in sentence)
        hashset.Add(c);


    var test = hashset.ToList();
    test.Sort();
    return sentence.Length == 26;
}


/*
 


 
 
 */