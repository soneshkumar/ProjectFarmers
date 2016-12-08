﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ProjectFarmerAPI.Models;
using System.Data.SqlClient;
using System.Data;

namespace ProjectFarmerAPI.DataAccess
{
    public class ItemDataAccess
    {
        private DBDataAccess dbAccess;

        public ItemDataAccess()
        {
            dbAccess = new DBDataAccess();
        }

        /// <summary>
        /// This method will return list of sellable inventories based upon the request generated by the user type. 
        /// For farmers, requestedBy = 0, and we will return Rates based upon farmers, and even number of inventories as well. 
        /// For Customers, requestedBy = 1, and we will return only those inventories which can be readly available to us by approperate means
        /// </summary>
        /// <param name="requestedBy"></param>
        /// <returns>list of inventories</returns>
        public IEnumerable<Item> GetSellableInventories(int requestedBy)
        {
            var sqlparams = new[] { new SqlParameter("requestedBy", requestedBy) };

            var ds = dbAccess.ExecuteStoredProcedure(Constants.GetSellableInventoriesSproc, sqlparams);
            ValidateInventoryDataSet(ds);
            var sellableItems = ds.Tables[0].Rows.OfType<DataRow>()
                .Select(row => CreateInventoryObject(row));
            return sellableItems;
        }

        /// <summary>
        /// Create the inventory object
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Item CreateInventoryObject(DataRow row)
        {
            return new Item
            {
                Id = row.Field<int>("Id"),
                Name = row.Field<string>("Name"),
                ResourceUrl = row.Field<string>("ResourceUrl"),
                Category = Enum.IsDefined(typeof(ItemCategory), row.Field<int>("Category")) ? (ItemCategory)Enum.Parse(typeof(ItemCategory), row.Field<int>("Category").ToString()) : ItemCategory.None,
                SellBy = Enum.IsDefined(typeof(ItemSellBy), row.Field<int>("SellBy")) ? (ItemSellBy)Enum.Parse(typeof(ItemSellBy), row.Field<int>("SellBy").ToString()) : ItemSellBy.None,
                //Quantity = row.Field<decimal>("Quantity"),
                Rate = row.Field<decimal>("Rate")
            };
        }


        /// <summary>
        /// Validating the db dataset
        /// </summary>
        /// <param name="ds"></param>
        private void ValidateInventoryDataSet(DataSet ds)
        {
            if(ds == null || ds.Tables.Count != 1)
            {
                throw new RowNotInTableException("The returned dataset should not be null");
            }
        }

        internal void Dispose()
        {
            // #TODO : Need to add some code to dispose the local variables
        }
    }
}