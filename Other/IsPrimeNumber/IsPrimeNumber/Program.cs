//Instructions
//A prime number is a positive integer with no divisors besides itself and 1 (it cannot be divided without a remainder by any number besides itself and 1). Write a function to check whether a given positive integer greater than 1 is prime or not.

//Examples

//isPrime(3) => true
//isPrime(5) => true
//isPrime(10) => false(divided evenly by 2 and 5)

Console.WriteLine(IsPrime(3));
Console.WriteLine(IsPrime(5));
Console.WriteLine(IsPrime(10));
Console.WriteLine(IsPrime(15));
Console.WriteLine(IsPrime(17));


static bool IsPrime(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0) return false;
    }

    return true;
}

