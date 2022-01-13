// https://leetcode.com/problems/check-if-the-sentence-is-pangram/

Console.WriteLine(CheckIfPangram("thequickbrownfoxjumpedoverthelazydog"));

static bool CheckIfPangram(string sentence)
{
    var set = new HashSet<char>();

    foreach (char c in sentence)
        set.Add(c);


    return set.Count == 26;
}


/*
 


 
 
 */
