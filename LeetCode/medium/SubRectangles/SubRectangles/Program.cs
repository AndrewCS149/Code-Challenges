// https://leetcode.com/problems/subrectangle-queries/
int[][] rectangle =
{
    new int[] {1, 2, 1},
    new int[] {4, 3, 4},
    new int[] {3, 2, 1},
    new int[] {1, 1, 1}
};

var subrectangle = new SubrectangleQueries(rectangle);

Console.WriteLine(subrectangle.GetValue(0, 2));
subrectangle.UpdateSubrectangle(0, 0, 3, 2, 5);
Console.WriteLine(subrectangle.GetValue(0, 2));

public class SubrectangleQueries
{
    public int[][] Rectangle { get; set; }
    public SubrectangleQueries(int[][] rectangle)
    {
        Rectangle = rectangle;
    }

    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int i = row1; i <= row2; i++)
        {
            for (int j = col1; j <= col2; j++)
            {
                Rectangle[i][j] = newValue;
            }
        }
    }

    public int GetValue(int row, int col)
    {
        return Rectangle[row][col];
    }

}


//var rect = new SubrectangleQueries()

// GetValue(0, 2) -output-> 1
// 1 2 1 
// 4 3 4
// 3 2 1
// 1 1 1