using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.DataAccess
{
    public class ItemDataAccess
    {
        private string itemSaveSproc;
        private string itemGetSproc;
        public ItemDataAccess()
        {
            itemSaveSproc = ConfigurationManager.AppSettings[Constants.ItemSaveSprocString];
            itemGetSproc = ConfigurationManager.AppSettings[Constants.ItemGetSprocString];
        }
    }
}