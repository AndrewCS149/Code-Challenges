// See https://aka.ms/new-console-template for more information

/*
 Flip every pair of characters in a string

example:

"check out how interesting this problem is, it\'s insanely interesting!"

"hcce kuo toh wnietertsni ghtsip orlbmei ,si 't sniasenyli tnreseitgn!"
 */

var test1 = "check out how interesting this problem is, it\'s insanely interesting!";
Console.WriteLine(FlipEveryCharacter(test1));


string FlipEveryCharacter(string str)
{
    string newStr = "";

    for (int i = 0; i < str.Length - 1; i += 2)
    {
        newStr += str[i + 1];
        newStr += str[i];
    }

    return str.Length % 2 == 1 ? newStr += str[str.Length - 1] : newStr;
}