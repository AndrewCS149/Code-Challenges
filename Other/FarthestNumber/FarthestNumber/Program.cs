// See https://aka.ms/new-console-template for more information

/*
 Instructions
Write a function that takes in a list of incorrect numbers and a correct number. Return the incorrect number farthest away from the correct number.
 */

static int FarthestNumberAway(int[] incorrectNums, int correctNum)
{
    int farthestNum = incorrectNums[0];
    foreach (int num in incorrectNums)
    {
        if(Math.Abs(num - correctNum) > farthestNum)
        {
            farthestNum = num;
        }
    }


    return farthestNum;
}

//Console.WriteLine(FarthestNumberAway(new int[] { 3, 6, -10 }, 0));
Console.WriteLine(FarthestNumberAway(new int[] { 3, 6, -10 }, -9));



/*
example input/outputs

maxError([3, 6, -10], 0) => -10
maxError([3, 6, -10], -9) => 6

 */
