/*
 Given a time in the format of "HH:MM" (12 hour time format), return an integer representing the inner angle of the hour and minute hands as it would appear on an analog clock. 

Example: 
    input  : 12:15
    output : 90

    input  : 3:45
    output : 180
 */

static int ReturnClockAngle(string time)
{
    // 12:45
    string[] arr = time.Split(':');

    int degreesPerHr = 360 / 12;
    int degreesPerMin = 360 / 60;

    int hour = int.Parse(arr[0]) * degreesPerHr;
    int min = int.Parse(arr[1]) * degreesPerMin;

    int angle = Math.Abs(hour - min);

    return angle > 180 ? 360 - angle : angle;
}


Console.WriteLine(ReturnClockAngle("12:15"));

/*
 12:45 -> 90

 arr = split(time) -> 12, 45

 hourDegrees = 360 / 12
 minuteDegrees = 360 / 60

 hour = arr[0] * hourDegrees
 min = arr[1] * minuteDegrees

 360 - 
 
 */


