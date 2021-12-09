static void Solution(int num)
{
    int fibNumber = 0;
    int num1;
    int num2 = 1;
    for (int i = 0; i < num; i++)
    {
        num1 = num2;// 1
        num2 = fibNumber;
        fibNumber = num1 + num2;
        if(num == num1 || num == num2 || num == fibNumber)
        {
            Console.WriteLine("Yes");
            return;
        }
    }

    Console.WriteLine("No");
}

Solution(34);
Solution(54);

static int Fib(int num)
{
    if(num == 1 || num == 0)
    {
        return num;
    } 
    else
    {
        return Fib(num - 1) + Fib(num - 2);
    }

}

static int FibIterative(int num)
{
    int fibNumber = 0;
    int num1;
    int num2 = 1;
    for(int i = 0; i < num; i++)
    {
        num1 = num2;// 1
        num2 = fibNumber;
        fibNumber = num1 + num2;
        
    }

    return fibNumber;
}

//Console.WriteLine(Fib(30));
//Console.WriteLine(FibIterative(30));