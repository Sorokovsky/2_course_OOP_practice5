namespace Task_2;

public static class Program
{
    private delegate int Delegate();
    public static void Main()
    {
        Console.WriteLine("Avarrage: {0}", Avarage([One, Two, Three]));
    }

    private static double Avarage(Delegate[] delegates)
    {
        double sum = 0;
        foreach (Delegate delegation in delegates)
        {
            sum += delegation.Invoke();
        }
        return sum / delegates.Length;
    }

    private static int One()
    {
        return 1;
    }
    private static int Two()
    {
        return 2;
    }
    private static int Three()
    {
        return 3;
    }
}