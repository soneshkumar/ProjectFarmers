using ProjectFarmerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.HelperMethods
{
    public class Validation
    {
        /// <summary>
        /// Validating order objects
        /// </summary>
        /// <param name="orders"></param>
        public static void validateOrders(IEnumerable<Order> orders)
        {
            foreach (var order in orders)
            {
                if (order.OrderStatus == OrderStatus.None)
                {
                    throw new ArgumentOutOfRangeException("OrderStatus is not correct");
                }
            }
        }
    }
}