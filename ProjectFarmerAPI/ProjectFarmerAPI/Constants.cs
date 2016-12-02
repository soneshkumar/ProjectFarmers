using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ProjectFarmerAPI
{
    public class Constants
    {
        #region string constants

        // Ratings related sprocs string

        private static string _ratingSaveSprocString = "SaveRatingSproc";
        private static string _ratingGetOrderRatingSprocString = "GetOrderRatingSproc";
        private static string _ratingGetItemRatingSprocString = "GetItemRatingSproc";

        // Inventories related sprocs string

        private static string _inventoryGetSellableSprocString = "GetSellableInventoriesSproc";
        private static string _inventorySaveSprocString = "SaveInventoriesSproc";
        private static string _inventoryGetByIdSprocString = "GetInventorySproc";

        // Customers related sprocs string

        private static string _customerSaveSprocString = "SaveCustomerSproc";
        private static string _customerDeleteSprocString = "DeleteCustomerSproc";
        private static string _customerGetByIdOrEmailIdOrMobileNumberSprocString = "GetCustomerByIdOrEmailIdOrMobileNumberSproc";
        private static string _customerSaveAddressesSprocString = "SaveCustomerAddressesSproc";

        // Farmers related sprocs string

        private static string _farmerSaveSprocString = "SaveFarmerSproc";
        private static string _farmerDeleteSprocString = "DeleteFarmerSproc";
        private static string _farmerGetByIdOrEmailIdOrMobileNumberSprocString = "GetFarmerByIdOrEmailIDOrMobileNumberSproc";
        private static string _farmerGetSoldInventoriesSprocString = "GetFarmerSoldInventoriesSproc";
        private static string _farmerGetInventoriesSprocString = "GetFarmerInventoriesSproc";
        private static string _farmerSaveInventoriesSprocString = "SaveFarmerInventoriesSproc";
        private static string _farmerSaveAddressesSprocString = "SaveFarmerAddressesSproc";

        // Orders related sprocs string

        private static string _orderSaveSprocString = "SaveOrderSproc";
        private static string _orderGetByCustomerSprocString = "GetOrderByCustomerSproc";
        private static string _orderGetByIdSprocString = "GetOrderByIdSproc";
        private static string _orderCancelSprocString = "CancelOrderSproc";
        private static string _orderReturnSprocString = "ReturnOrderSproc";
        private static string _orderStatusUpdateSprocString = "UpdateOrderStatusSproc";

        #endregion

        #region public string variables

        public static string SaveRatingSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_ratingSaveSprocString];
            }
        }

        public static string GetOrderRatingSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_ratingGetOrderRatingSprocString];
            }
        }

        public static string GetItemRatingSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_ratingGetItemRatingSprocString];
            }
        }

        public static string GetSellableInventoriesSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_inventoryGetSellableSprocString];
            }
        }

        public static string SaveInventoriesSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_inventorySaveSprocString];
            }
        }

        public static string GetInventorySproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_inventoryGetByIdSprocString];
            }
        }

        public static string SaveCustomerSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_customerSaveSprocString];
            }
        }

        public static string DeleteCustomerSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_customerDeleteSprocString];
            }
        }

        public static string GetCustomerByIdOrEmailIdOrMobileNumberSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_customerGetByIdOrEmailIdOrMobileNumberSprocString];
            }
        }

        public static string SaveCustomerAddressesSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_customerSaveAddressesSprocString];
            }
        }

        public static string SaveFarmerSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_farmerSaveSprocString];
            }
        }

        public static string DeleteFarmerSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_farmerDeleteSprocString];
            }
        }

        public static string GetFarmerByIdOrEmailIDOrMobileNumberSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_farmerGetByIdOrEmailIdOrMobileNumberSprocString];
            }
        }

        public static string GetFarmerSoldInventoriesSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_farmerGetSoldInventoriesSprocString];
            }
        }

        public static string GetFarmerInvnetoriesSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_farmerGetInventoriesSprocString];
            }
        }

        public static string SaveFarmerInventoriesSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_farmerSaveInventoriesSprocString];
            }
        }

        public static string SaveFarmerAddressesSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_farmerSaveAddressesSprocString];
            }
        }

        public static string SaveOrderSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_orderSaveSprocString];
            }
        }

        public static string GetOrderByCustomerSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_orderGetByCustomerSprocString];
            }
        }

        public static string GetOrderByIdSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_orderGetByIdSprocString];
            }
        }

        public static string CancelOrderSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_orderCancelSprocString];
            }
        }

        public static string ReturnOrderSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_orderReturnSprocString];
            }
        }

        public static string UpdateOrderStatusSproc
        {
            get
            {
                return ConfigurationManager.AppSettings[_orderStatusUpdateSprocString];
            }
        }

        #endregion

    }
}