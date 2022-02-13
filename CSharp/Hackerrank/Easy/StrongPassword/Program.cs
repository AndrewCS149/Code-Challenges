
int IsStrongPassword(string password)
{
    string numbers = "0123456789";
    string lower_case = "abcdefghijklmnopqrstuvwxyz";
    string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string special_characters = "!@#$%^&*()-+";

    int changesToAdd = 0;

    bool hasNumber = false;
    bool hasLowerCase = false;
    bool hasUpperCase = false;
    bool hasSpecialChar = false;
    int checks = 0;

    foreach (char ch in password)
    {
        if (numbers.Contains(ch) && !hasNumber)
        {
            hasNumber = true;
            checks++;
        }
        else if(lower_case.Contains(ch) && !hasLowerCase)
        {
            hasLowerCase = true;
            checks++;
        }
        else if(upper_case.Contains(ch) && !hasUpperCase)
        {
            hasUpperCase = true;
            checks++;
        }
        else if(special_characters.Contains(ch) && !hasSpecialChar)
        {
            hasSpecialChar = true;
            checks++;
        }
    }

    if(checks < 4)
        changesToAdd += 4 - checks;

    if (password.Length < 6 && changesToAdd + password.Length < 6)
        changesToAdd += 6 - password.Length;

    return changesToAdd;

}