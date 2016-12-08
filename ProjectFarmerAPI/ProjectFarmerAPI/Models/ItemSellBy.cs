using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    public enum ItemSellBy
    {
        /// <summary>
        /// Invalid/wrong entry cases
        /// </summary>
        None = -1,
        /// <summary>
        /// Weight type of item
        /// </summary>
        Weight = 1,
        /// <summary>
        /// Counting type of items
        /// </summary>
        Number = 2
    }
}