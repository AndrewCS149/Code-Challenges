/*
You are writing a computer program for an electric vending machine to give you the optimal change for an items 
cost. WRite a funcation called OptimalChange that takes two args: itemCost & amountPaid. The function should
return a string describing the optimal change which follows the following convention:

print(optimalChange(62.13, 100)) 
-> "The optimal change for an item that costs $62.13 with an amount paid of $100 is 1 $20 bill, 1 $10 bill, 1 $5 bills, 2 $1 bills, 
3 quarters, 1 dime and 2 pennies"

*/

using System;

  namespace OptimalChange
  {
      public class Program 
      {
          private static void Main(string[] args) 
          {
          	Console.WriteLine(OptimalChangeSolution(75, 150.56));
          	Console.WriteLine(OptimalChangeSolution(31.51, 50));
          	          	
          }

          private static string OptimalChangeSolution(double itemCost, double amountPaid) 
          {
			string result = $"The optimal change for an item that costs ${itemCost} with an amount paid of ${amountPaid} is ";

			double change = amountPaid - itemCost;
			int cents = 0;
			string[] tmpArr = new string[1];
			if(change.ToString().Contains('.')) 
			{
				tmpArr = change.ToString().Split('.');
				cents = int.Parse(tmpArr[1]);
			}
			else 
				tmpArr[0] = change.ToString();
				
			int dollars = int.Parse(tmpArr[0]);
			while(dollars > 0) 
			{
				int tmp = 0;
				int first = 0;
				if(dollars / 1000 > 0) tmp = 1000;
				else if(dollars / 100 > 0) tmp = 100;
				else if(dollars / 50 > 0) tmp = 50;
				else if(dollars / 20 > 0) tmp = 20;
				else if(dollars / 10 > 0) tmp = 10;
				else if(dollars / 5 > 0) tmp = 5;
				else tmp = 1;

				first = dollars / tmp;
				dollars %= tmp;
				result += $"{first} ${tmp} bill";

				if(first > 1) result += "s";

				result += ", ";
			}

			var centsMap = new Dictionary<int, string>() 
			{
				{25, "quarter"}, {10, "dime"}, {5, "nickel"},{1, "penny"}
			};
			
			while(cents > 0) 
			{
				int tmp = 0;
				int first = 0;
				if(cents / 25 > 0) tmp = 25;
				else if(cents / 10 > 0) tmp = 10;
				else if(cents / 5 > 0) tmp = 5;
				else tmp = 1;

				first = cents / tmp;
				cents %= tmp;

				if(cents == 0) result += " and ";

				result += $"{first} {centsMap[tmp]}";

				// if plural pennies, append "pennies" instead of "penny"
				if(first > 1 && tmp == 1) 
				{
					result = result.Remove(result.Length - 1);
					result += "ies";	
				}
				else if(first > 1) result += "s";

				result += ", ";
			}

			// remove last space and comma before returning
          	return result.Remove(result.Length - 2);
          }
      }
  }
  
