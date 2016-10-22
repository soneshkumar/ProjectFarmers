using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// The Farmer Class
    /// </summary>
    public class Farmer : Entity
    {
        /// <summary>
        /// The Date Of Birth of the Farmer
        /// </summary>
        [Required]
        public DateTime DOB { get; set; }


        /// <summary>
        /// The List of Items Farmer has
        /// </summary>
        public IDictionary<int, double> FarmerItems { get; set; }
    }
}