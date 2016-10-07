using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// The Order Class
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Order ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Customer Id
        /// </summary>
        [Required]
        public int CustomerId { get; set; }

        /// <summary>
        /// Description of the Order
        /// </summary>
        public string OrderDescription { get; set; }

        /// <summary>
        /// The Order Delivery Address
        /// </summary>
        [Required]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// The Prioirty of the Order
        /// </summary>
        public Priority Priority { get; set; }

        /// <summary>
        /// Delivery Date of the Order,
        /// </summary>
        [Required]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// The time slot will be used for delivery
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// The Status of the Order
        /// </summary>
        public Status OrderStatus { get; set; }

        /// <summary>
        /// The list of items which are being ordered.
        /// </summary>
        [Required]
        public IDictionary<int, double> OrderedItems { get; set; }

        /// <summary>
        /// The Total Cost of the Order
        /// </summary>
        public double TotalCost { get; set; }
    }
}