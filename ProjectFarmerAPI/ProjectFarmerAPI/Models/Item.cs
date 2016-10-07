using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// The Item Class is for list of items
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The Id of the item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Name of the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The URL of the resource attached with the item
        /// </summary>
        public string ResourceUrl { get; set; }

        /// <summary>
        /// The Category of the Item
        /// </summary>
        public ItemCategory Category { get; set; }

        /// <summary>
        /// The type of the item weather the item is priced with the weight or by quantity.
        /// </summary>
        public ItemType Type { get; set; }

        /// <summary>
        /// The quantity of the item available in the store
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// The Cost/Rate of the Item per Quantity
        /// </summary>
        public double Rate { get; set; }

    }
}