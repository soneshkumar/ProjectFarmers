using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// The Customer Class
    /// </summary>
    public class Customer : Entity
    {
        /// <summary>
        /// The Type of the Customer
        /// </summary>
        public CustomerType Type { get; set; }

        /// <summary>
        /// The Date of birth of the Customer if Indivisual Otherwise Company Date.
        /// </summary>
        public DateTime Date { get; set; }

    }
}