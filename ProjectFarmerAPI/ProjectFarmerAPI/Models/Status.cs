using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// The Status enum will be used for both order status and delivery status
    /// </summary>
    public enum Status
    {
        Processing = 1,
        LeftTheStore = 2
    }
}