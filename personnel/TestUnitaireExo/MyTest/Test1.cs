using ConsoleApp4;

namespace MyTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int x = 10;
            int y = 10;
            int z = -15;

            //act
            int res = MyMath.Somme(x, y);
            int res2 = MyMath.Somme(x, z);

            //assert
            Assert.AreEqual(res, 20);
            Assert.AreEqual(res2, 20);
        }
    }
}
