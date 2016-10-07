using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    public class ProjectFarmerAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjectFarmerAPIContext() : base("name=ProjectFarmerAPIContext")
        {
        }

        public System.Data.Entity.DbSet<ProjectFarmerAPI.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<ProjectFarmerAPI.Models.Rating> Ratings { get; set; }

        public System.Data.Entity.DbSet<ProjectFarmerAPI.Models.Farmer> Farmers { get; set; }

        public System.Data.Entity.DbSet<ProjectFarmerAPI.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<ProjectFarmerAPI.Models.Item> Items { get; set; }
    }
}
