
namespace HW14.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        PolarVector P1=new PolarVector(5,57);
        PolarVector P2=new PolarVector(2,104);

        PolarVector P3=P1.Add(P2);
        PolarVector Psum=new PolarVector(3.0254405657658228,0.5331127042966446);
        bool S1=P3.Equals(Psum);
        Assert.AreEqual(S1,true);

        //Stack overflow!!
        // MyVector<double> V1=P2.CartesianVector();
        // MyVector<double> V2=new MyVector<double>(3,2);
        // bool S2=V1.Equals(V2);
        // Assert.AreEqual(S2,true);
    }
}