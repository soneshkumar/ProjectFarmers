using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    public enum ItemQuantityBy
    {
        /// <summary>
        /// Invalid/wrong entry cases
        /// </summary>
        None = -1,
        /// <summary>
        /// Weight type of item
        /// </summary>
        ByWeight = 1,
        /// <summary>
        /// Counting type of items
        /// </summary>
        ByNumber = 2
    }
}