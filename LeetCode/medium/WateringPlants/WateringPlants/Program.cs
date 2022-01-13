// https://leetcode.com/problems/watering-plants/

int[] plants = { 2, 2, 3, 3 };
int cap = 5;
Console.WriteLine(WateringPlants(plants, cap));

static int WateringPlants(int[] plants, int capacity)
{
    int count = 0;
    int tmpCap = capacity;
    for (int i = 0; i < plants.Length; i++)
    {
        if (tmpCap - plants[i] < 0)
        {
            count += (i * 2);
            tmpCap = capacity;
        }

        count++;
        tmpCap -= plants[i];
    }

    return count;
}