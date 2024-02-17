using WorkerService1;

namespace TestProject2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var orderManager = new OrdersManager();
        var startTime = DateTime.Now;
        
        orderManager.AddOrderItem(new Order(startTime: startTime, endTime: DateTime.Now.AddSeconds(10.0)));
        orderManager.AddOrderItem(new Order(startTime: startTime, endTime: DateTime.Now.AddSeconds(5.0)));
        orderManager.AddOrderItem(new Order(startTime: startTime, endTime: DateTime.Now.AddSeconds(5.0)));
        var result = orderManager.CalculateAverageOrderTime();
        Assert.That(result, Is.EqualTo(20.0/3.0).Within(0.0001));
    }
}