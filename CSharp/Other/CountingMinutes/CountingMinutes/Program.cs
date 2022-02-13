/*
 have the function CountingMinutes(str) take the str parameters being passed which will be two times (each properly formatted with a colon and am or pm) separated by a hyphen and return the total number of minutes between the two times. Th time will be in a 12 hour clock format. For example: If str is 9:00am-10:00am then the output should be 60. If str is 1:00pm-11:00am the output should be 1320

    input outputs
    "12:30pm-12:00am" -> 690
    "1:23am-1:08am" -> 1425
    "11:00am-01:00pm" -> 120
    "05:00am-03:30am" -> 1350
    

 */
Console.WriteLine(Solution("12:30pm-12:00am"));
Console.WriteLine(Solution("1:23am-1:08am"));
Console.WriteLine(Solution("11:00am-01:00pm"));
Console.WriteLine(Solution("5:00am-03:30am"));
Console.WriteLine(Solution("3:30pm-3:30pm"));


static int Solution(string time)
{
    int totalMinutes = 1440;

    // split times into individual components 
    string[] bothTimes = time.Split("-");

    // get total minutes of both times
    int time1 = GetMinutes(bothTimes[0]);
    int time2 = GetMinutes(bothTimes[1]);

    if (time1 > time2)
    {
        int diff = time1 - time2;
        return totalMinutes - diff;
    }
    else
        return time2 - time1;
}

static int GetMinutes(string time)
{
    // split hrs and minutes
    string[] splitTime = time.Split(":");

    // get minutes
    int minutes = int.Parse(splitTime[1].Substring(0, 2));

    // determine if its am or pm
    string AmPm = splitTime[1][2] == 'a' ? "am" : "pm";

    // get hours and convert to military time
    int hours = int.Parse(splitTime[0]);
    if (AmPm == "am") hours += 12;

    int totalMinutes = hours * 60 + minutes;

    return totalMinutes;
}