﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    /// <summary>
    /// Address Class
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Address Id Generated by Database
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Address Line 1 Ex : Apt. 2000 apt Name
        /// </summary>
        [Required]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address Line 2 Ex : Street Name
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// District/City 
        /// </summary>
        [Required]
        public string District { get; set; }

        /// <summary>
        /// State Name
        /// </summary>
        [Required]
        public string State { get; set; }

        /// <summary>
        /// Country Name 
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        /// PinCode Ex : 341519
        /// </summary>
        [Required]
        public int PinCode { get; set; }

        /// <summary>
        /// Mobile Number, it will be the Address Primary Contact Number
        /// </summary>
        [Required]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Phone Number : LandLine Number, Not a Mandatory Number.  it is a Secoundry number. 
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}