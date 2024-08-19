using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    /// <summary>
    ///  Subsystem Class
    /// </summary>
    public class OrderService
    {
        public bool HsEnoughOrders(int CustomerId)
        {
            Console.WriteLine(" Simulating Order Service ");
            return (CustomerId > 5);
        }

    }
    /// <summary>
    ///  Subsystem Class
    /// </summary>
    public class CustomerDiscountBaseService
    {
        public double CalculateDiscountBase(int CustomerId)
        {
            Console.WriteLine(" Simulating Customer Discount Service ");
            return (CustomerId > 8) ? 10.8 : 20.5;
        }

    }
    /// <summary>
    ///  Subsystem Class
    /// </summary>
    public class DayOfWeeksFactorService
    {
        public double CalculateDayOfTheWeekFactor()
        {
            Console.WriteLine(" Simulating Days of the Week Service ");
            switch (DateTime.UtcNow.DayOfWeek)
            {

                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                    return 0.8;
                default:
                    return 1.2;
            }
        }

    }
    /// <summary>
    ///  Facade Class
    /// </summary>
    public class DiscountFacade
    {
        private readonly DayOfWeeksFactorService _dayOfWeeksFactor = new();
        private readonly CustomerDiscountBaseService _discountBaseService = new();
        private readonly OrderService _orderService = new OrderService();

        public double CalculateOrderDiscountPrecentage(int customerId)
        {
            if (!_orderService.HsEnoughOrders(customerId))
            {
                return 0;
            }
            return _discountBaseService.CalculateDiscountBase(customerId) * _dayOfWeeksFactor.CalculateDayOfTheWeekFactor();
        }
    }
}
