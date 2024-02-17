using WorkerService1;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var orderManager = new OrdersManager();
        var startTime = DateTime.Now;

        orderManager.AddOrderItem(new Order(startTime: startTime, endTime: DateTime.Now.AddSeconds(5.0)));
        orderManager.AddOrderItem(new Order(startTime: startTime, endTime: DateTime.Now.AddSeconds(5.0)));
        orderManager.AddOrderItem(new Order(startTime: startTime, endTime: DateTime.Now.AddSeconds(5.0)));
        orderManager.AddOrderItem(new Order(startTime: startTime, endTime: DateTime.Now.AddSeconds(5.0)));
        var result = orderManager.CalculateAverageOrderTime();
        Assert.AreEqual(20/4, (int)result);
    }
}