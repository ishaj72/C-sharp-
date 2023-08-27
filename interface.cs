using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}


public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n / 2; i++) // Start from 1 and end at n/2
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        sum += n; // Include n itself as a divisor
        return sum;
    }
}

class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}

//HackeRank 30 days of code.
