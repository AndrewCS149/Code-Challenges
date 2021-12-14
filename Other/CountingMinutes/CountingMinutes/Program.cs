/*
 have the function CountingMinutes(str) take the str parameters being passed which will be two times (each properly formatted with a colon and am or pm) separated by a hyphen and return the total number of minutes between the two times. Th time will be in a 12 hour clock format. For example: If str is 9:00am-10:00am then the output should be 60. If str is 1:00pm-11:00am the output should be 1320

    input outputs
    "12:30pm-12:00am" -> 690
    "1:23am-1:08am" -> 1425
    "11:00am-01:00pm" -> 120
    "05:00am-03:30am" -> 1350
    

 */

static int Solution(string time)
{
    string[] bothTimes = time.Split("-");
    string first = bothTimes[0];
    string seconds = bothTimes[1];


    return -1;
}