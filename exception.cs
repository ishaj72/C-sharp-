//ques from hackerRank 30 days of code
class NegExcept : Exception
{
    public NegExcept() : base("n and p should be non-negative")
    {
    }
}

class Calculator
{
    public int power(int n, int p)
    {
        if (n < 0 || p < 0)
        {
            throw new NegExcept();
        }
        else
        {
            return (int)Math.Pow(n, p);
        }
    }
}
