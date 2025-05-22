namespace S08con.test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        int result=Program.Add(3,5);
        Assert.AreEqual(result,8);
    }
}
