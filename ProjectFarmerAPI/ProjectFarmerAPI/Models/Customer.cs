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
    public class Customer
    {
        /// <summary>
        /// The Customer Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Customers First Name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The Customers Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The Type of the Customer
        /// </summary>
        public CustomerType Type { get; set; }

        /// <summary>
        /// The Date of birth of the Customer if Indivisual Otherwise Company Date.
        /// </summary>
        public DateTime DOB { get; set; }

        /// <summary>
        /// The Mobile Number of the Customer, It can be different from the Address. We can use this same number for the Address as well.
        /// </summary>
        [Required]
        public string MobileNumber { get; set; }

        /// <summary>
        /// The Secondary Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The Prefered Address of the Customer  
        /// </summary>
        [Required]
        public Address PreferedAddress { get; set; }

        /// <summary>
        /// The Other Addresses of the Customer, null in case of no other address
        /// </summary>
        public IEnumerable<Address> Addresses { get; set; }

        /// <summary>
        /// This is very private information about the Customer and it will not be accesable by outsiders
        /// </summary>
        protected double CustomerRating { get; private set; }

    }
}