using System;

namespace Parking_System
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class ParkingSystem
    {
        private int[] arr;

        public ParkingSystem(int big, int med, int small)
        {
            arr = new int[] { big, med, small };
        }

        public bool AddCar(int carType)
        {
            // ONLINE SOLUTION
            return arr[carType - 1]-- > 0;

            // MY SOLUTION
            //if (carType == 1 && arr[0] > 0)
            //{
            //    arr[0]--;
            //    return true;
            //}
            //else if (carType == 2 && arr[1] > 0)
            //{
            //    arr[1]--;
            //    return true;
            //}
            //else if (carType == 3 && arr[2] > 0)
            //{
            //    arr[2]--;
            //    return true;
            //}

            //return false;
        }
    }
}