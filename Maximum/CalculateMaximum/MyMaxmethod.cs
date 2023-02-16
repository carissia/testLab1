namespace CalculateMaximum;
public class MyMaxmethod
{
    ///This method calculates the maximum of 2 numbers.
    //My student ID 1145325
    public static double MyMax(double number, double number1) 
    {
        double max;
        max = Math.Max(number, number1);
        Console.WriteLine("The maximum of the two numbers is: " +max);
        return max;
    }
    public static double MyMax1(double a, double b, double c) 
    {
        double[] myNums = {a, b, c};
        double maximum = myNums.Max();
        Console.WriteLine("The maximum of the three numbers is: " +maximum);
        return maximum;


    }
}
