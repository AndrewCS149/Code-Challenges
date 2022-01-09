// https://leetcode.com/problems/max-increase-to-keep-city-skyline/

int[][] grid =
{
    new int[] {3,0,8,4 },
    new int[] {2,4,5,7 },
    new int[] {9,2,6,3 },
    new int[] {0,3,1,0 }
};

Solution(grid);

static int Solution(int[][] grid)
{
    int result = 0;

    int[] maxX = new int[grid[0].Length];
    int[] maxY = new int[grid[0].Length];

    for (int i = 0; i < grid.Length; i++)
    {
        int tmpX = 0;
        int tmpY = 0;
        for (int j = 0; j < grid[i].Length; j++)
        {
            if (grid[i][j] > tmpX)
                tmpX = grid[i][j];

            if (grid[j][i] > tmpY)
                tmpY = grid[j][i];
        }
        maxX[i] = tmpX;
        maxY[i] = tmpY;
    }

    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[i].Length; j++)
            result += Math.Min(maxX[i], maxY[j]) - grid[i][j];
    }

    return result;
}