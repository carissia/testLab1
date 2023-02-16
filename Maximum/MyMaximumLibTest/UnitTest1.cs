using Xunit;

using CalculateMaximum;
using MyMaximumLibTest;
namespace MyMaximumLibTest;

public class UnitTest1
{
    [Fact]
    public void TestMaximum() {
        double a = 4;
        double b = 2;
        double actual = MyMaxmethod.MyMax(a, b);
        
    }
    [Fact]
    public void TestMaximum1() 
    {
        double a = 2;
        double b = 4;
        double c = 6;
        
        double actual = MyMaxmethod.MyMax1(a, b ,c);
     

    }

    
}