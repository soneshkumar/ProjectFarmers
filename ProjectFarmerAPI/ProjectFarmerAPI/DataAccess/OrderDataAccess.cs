using ProjectFarmerAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.DataAccess
{
    public class OrderDataAccess
    {
        DBDataAccess access;

        public OrderDataAccess()
        {
            access = new DBDataAccess();
        }

        public void SaveOrder(Order order)
        {

        }

        internal IEnumerable<Order> GetOrderByCustomer(int customerId)
        {
            var sqlParms = new[] { new SqlParameter("UserId", customerId) };
            var ds = access.ExecuteStoredProcedure(Constants.GetOrderByCustomerSproc, sqlParms);
            ValidateOrderDataSet(ds);
            var orderObjects = ds.Tables[0].Rows.OfType<DataRow>()
                .Select(row => CreateBasicOrderObject(row));
            return orderObjects;
        }

        private Order CreateBasicOrderObject(DataRow row)
        {
            return new Order
            {
                Id = row.Field<int>("Id"),
                DeliveryDate = row.Field<DateTime>("DeliveryDate"),
                TotalCost = row.Field<decimal>("TotalCost"),
                OrderStatus = Enum.IsDefined(typeof(OrderStatus), row.Field<int>("OrderStatus")) ? (OrderStatus)Enum.Parse(typeof(OrderStatus), row.Field<int>("OrderStatus").ToString()) : OrderStatus.None
            };
        }

        private void ValidateOrderDataSet(DataSet ds)
        {
            if(ds == null || ds.Tables.Count != 1)
            {
                throw new RowNotInTableException("The returned dataset is either null or does not have sufficient tables or rows");
            }
        }

        internal IEnumerable<Order> GetOrderByFarmer(int farmerId)
        {
            var sqlParms = new[] { new SqlParameter("UserId", farmerId), new SqlParameter("IsFarmerRequesting", 1)};
            var ds = access.ExecuteStoredProcedure(Constants.GetFarmerSoldInventoriesSproc, sqlParms);
            ValidateOrderDataSet(ds);
            var orderObjects = ds.Tables[0].Rows.OfType<DataRow>()
                .Select(row => CreateBasicOrderObject(row));
            return orderObjects;
        }

        /// <summary>
        /// Dispose will free up some memory space from this access
        /// </summary>
        internal void Dispose()
        {
            //#TODO : Need to write this.
        }
    }
}