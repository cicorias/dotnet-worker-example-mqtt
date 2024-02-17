using System.Diagnostics;

namespace WorkerService1;

public class OrderList : List<Order>
{
}

public class Order
{
    public DateTime StartTime { get; set; }
    // end time
    public DateTime EndTime { get; set; }

    public Order() => StartTime = DateTime.Now;

    public Order(DateTime startTime) => StartTime = startTime;

    public Order(DateTime startTime, DateTime endTime) => (StartTime, EndTime) = (startTime, endTime);
}

public class OrdersManager
{
    OrderList orders = new OrderList();

    public void AddOrderItem(Order orderItem)
    {
        orders.Add(orderItem);
    }

    // calculate average time for orders
    public double CalculateAverageOrderTime()
    {
        return orders.Average(x =>
            {
                TimeSpan timeDifference = x.EndTime - x.StartTime;
                return timeDifference.TotalSeconds;
            });
    }
}
