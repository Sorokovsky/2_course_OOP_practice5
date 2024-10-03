namespace Task_1;
public static class Program
{
    private delegate double Ad(double a, double b);
    private delegate double Sub(double a, double b);
    private delegate double Mul(double a, double b);
    private delegate double Div(double a, double b);

    public static void Main()
    {
        Ad add = Add;
        Sub sub = Subtract;
        Mul mul = Multiply;
        Div div = Divide;
        while(true)
        {
            try
            {
                int operation = ChooseOperation();
                switch(operation)
                {
                    case 0:
                    {
                        return;
                    }
                    case 1:
                    {
                        (double a, double b) = EnterNumbers();
                        DisplayOperation(a, b, '+', add.Invoke(a, b));
                        break;
                    }
                    case 2:
                    {
                        (double a, double b) = EnterNumbers();
                        DisplayOperation(a, b, '-', sub.Invoke(a, b));
                        break;
                    }
                    case 3:
                    {
                        (double a, double b) = EnterNumbers();
                        DisplayOperation(a, b, '*', mul.Invoke(a, b));
                        break;
                    }
                    case 4:
                    {
                        (double a, double b) = EnterNumbers();
                        DisplayOperation(a, b, '/', div.Invoke(a, b));
                        break;
                    }
                    default:
                    {
                        throw new InvalidOperationException("Uknown operation.");
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                continue;
            }
        }

    }

    private static double Add(double a, double b)
    {
        return a + b;
    }

    private static double Subtract(double a, double b)
    {
        return a - b;
    }

    private static double Multiply(double a, double b)
    {
        return a * b;
    }

    private static double Divide(double a, double b)
    {
        if(b == 0)
        {
            throw new DivideByZeroException("Can not divide by zero.");
        }

        return a / b;
    }

    private static int ChooseOperation()
    {
        int operation;
        Console.WriteLine($"Choose operation.");
        Console.WriteLine($"0-Exit.");
        Console.WriteLine($"1-Add.");
        Console.WriteLine($"2-Subtract.");
        Console.WriteLine($"3-Multyply.");
        Console.WriteLine($"4-Divide.");
        Console.Write($">> "); operation = Convert.ToInt32(Console.ReadLine());
        return operation;
    }

    private static (double a, double b) EnterNumbers()
    {
        double a, b;
        Console.Write($"Enter a: "); a = Convert.ToUInt32(Console.ReadLine());
        Console.Write($"Enter b: "); b = Convert.ToUInt32(Console.ReadLine());
        return (a, b);
    }

    private static void DisplayOperation(double a, double b, char operation, double result)
    {
        Console.WriteLine($"{a}{operation}{b}={result}");
        
    }
}