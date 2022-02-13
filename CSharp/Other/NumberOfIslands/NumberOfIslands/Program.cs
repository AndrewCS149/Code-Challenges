

// answer = 3
int[][] mtx = new int[][]
{
    new int[] { 1, 1, 0, 1, 1 },
    new int[] { 1, 1, 0, 0, 0 },
    new int[] { 0, 0, 1, 1, 0 },
    new int[] { 0, 0, 0, 1, 0 },
    new int[] { 0, 1, 0, 1, 0 },
};

Console.WriteLine(NumOfIslands(mtx));

static void CheckAdjCells(int[][] grid, int x, int y, int rows, int cols)
{
    if (x < 0 || x >= rows || y < 0 || y >= cols || grid[x][y] != 1)
        return;

    grid[x][y] = 0;

    CheckAdjCells(grid, x - 1, y, rows, cols); // up
    CheckAdjCells(grid, x + 1, y, rows, cols); // down
    CheckAdjCells(grid, x, y - 1, rows, cols); // left
    CheckAdjCells(grid, x, y + 1, rows, cols); // right
}

static int NumOfIslands(int[][] grid)
{
    int islands = 0;

    if (grid.Length == 0)
        return -1;

    int rows = grid.Length;
    int cols = grid[0].Length;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (grid[i][j] == 1)
            {
                CheckAdjCells(grid, i, j, rows, cols);
                islands++;
            }
        }
    }

    return islands;
}