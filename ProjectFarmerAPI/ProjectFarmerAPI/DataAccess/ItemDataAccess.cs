using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ProjectFarmerAPI.Models;
using System.Data.SqlClient;

namespace ProjectFarmerAPI.DataAccess
{
    public class ItemDataAccess
    {
        private string itemSaveSproc;
        private string itemGetSproc;
        private DBDataAccess dbAccess;
        public ItemDataAccess()
        {
            itemSaveSproc = ConfigurationManager.AppSettings[Constants.ItemSaveSprocString];
            itemGetSproc = ConfigurationManager.AppSettings[Constants.ItemGetSprocString];
            dbAccess = new DBDataAccess();
        }

        public int SaveItem(Item item)
        {
            SqlParameterCollection parameters = null;

            parameters.AddWithValue("abc", DBNull.Value);

            var ds = dbAccess.ExecuteStoredProcedure(itemSaveSproc, parameters);

            return 1;

        }

    }
}