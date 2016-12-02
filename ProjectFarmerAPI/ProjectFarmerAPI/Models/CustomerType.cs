using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// The Type of Customers
    /// </summary>
    public enum CustomerType
    {
        /// <summary>
        /// Indivisual customers
        /// </summary>
        Indivisual = 1,
        /// <summary>
        /// The Enterprise customers, small or big
        /// </summary>
        Enterprise = 2
    }
}