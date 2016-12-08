using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The URL of the resource attached with the item
        /// </summary>
        [Required]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// The Category of the Item
        /// </summary>
        [Required]
        public ItemCategory Category { get; set; }

        /// <summary>
        /// The type of the item weather the item is priced with the weight or by number.
        /// </summary>
        [Required]
        public ItemSellBy SellBy { get; set; }

        /// <summary>
        /// The quantity of the item available in the store
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// The Cost/Rate of the Item per Quantity, It will be farmers rate if farmers has asked for it, otherwise it will be customers rate.
        /// </summary>
        public decimal Rate { get; set; }

    }
}