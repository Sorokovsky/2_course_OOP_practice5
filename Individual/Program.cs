// Variant 12
namespace Individual;
public static class Program
{
    private delegate double Calc(double alfa, double a);
    public static void Main()
    {
        try
        {
            Console.Write("Введіть катет а: ");
            Calc calculate = Calculate;
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть кут альфа: ");
            double alfa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"P = {calculate(alfa, a)}");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static double Calculate(double alfa, double a)
    {
        double tang = Math.Tan(alfa);
        double sin = Math.Sin(alfa);
        if(tang == 0 ||  sin == 0)
        {
            throw new Exception("Кут не може бути таким.");
        }
        double reverseTang = 1 / tang;
        double reverseSin = 1 / sin;
        return a * (reverseTang + reverseSin + 1);
    }
}