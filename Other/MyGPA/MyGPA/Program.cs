//Write a function that takes in an array of letters represented by grades for a semester Ex: "A+","C-","B+","A","C+" and return the cumulative GPA for the semester.


//myGPA(["A+", "C+", "B+", "A-", "C"]) ==> 3.132
//myGPA(["B-", "C+", "B+", "C-", "A+"]) ==> 2.866

double WhatsMyGPA(string[] grades)
{
    //var letterGrades = new Dictionary<string, int>();

    string[] letters = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" };
    double[] scores = { 4.33, 4.00, 3.67, 3.33, 3.00, 2.67, 2.33, 2.00, 1.67, 1.33, 1.00, 0.67, 0.00 };
    double sum = 0;

    foreach (string num in grades)
    {
        sum += scores[Array.IndexOf(letters, num)];
    }

    return sum / grades.Length;
}

Console.WriteLine(WhatsMyGPA(new string[] { "A+", "C+", "B+", "A-", "C" }));
Console.WriteLine(WhatsMyGPA(new string[] { "B-", "C+", "B+", "C-", "A+" }));