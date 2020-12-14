using System;

class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        bool canDivide = true;
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            canDivide = false;
        }
        finally
        {
            if (!canDivide)
            {
                Console.WriteLine($"Cannot divide by zero\n{a} / {b} = 0");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {result}");
            }
        }
    }
}
