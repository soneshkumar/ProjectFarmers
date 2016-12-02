using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectFarmerAPI.Models;
using ProjectFarmerAPI.DataAccess;
using ProjectFarmerAPI.HelperMethods;

namespace ProjectFarmerAPI.Controllers
{
    [RoutePrefix("api/farmers")]
    public class FarmersController : ApiController
    {
        private ProjectFarmerAPIContext db = new ProjectFarmerAPIContext();
        private OrderDataAccess orderAccess = new OrderDataAccess();

        // GET: api/Farmers
        [Route("")]
        public IQueryable<Farmer> SearchFarmers()
        {
            return db.Farmers;
        }

        // GET: api/Farmers/5
        [Route("{id:int}")]
        [ResponseType(typeof(Farmer))]
        public async Task<IHttpActionResult> GetFarmer(int id)
        {
            Farmer farmer = await db.Farmers.FindAsync(id);
            if (farmer == null)
            {
                return NotFound();
            }

            return Ok(farmer);
        }

        [Route("{id:int}/orders")]
        public IEnumerable<Order> GetOrderByFarmerId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Customer ID should be positive integer");
            }
            return FindOrderByFarmer(id);
        }

        /// <summary>
        /// Follow up method for farmers sold inventories
        /// </summary>
        /// <param name="farmerId"></param>
        /// <returns></returns>
        private IEnumerable<Order> FindOrderByFarmer(int farmerId)
        {
            var orders = orderAccess.GetOrderByFarmer(farmerId);
            Validation.validateOrders(orders);
            return orders;
        }

        // GET: api/Farmers/5/GetSoldInventories
        [Route("{id:int}/GetSoldInventories")]
        [ResponseType(typeof(Farmer))]
        public async Task<IHttpActionResult> GetFarmerSoldInventories(int id)
        {
            Farmer farmer = await db.Farmers.FindAsync(id);
            if (farmer == null)
            {
                return NotFound();
            }

            return Ok(farmer);
        }

        // PUT: api/Farmers/5
        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFarmer(int id, Farmer farmer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != farmer.Id)
            {
                return BadRequest();
            }

            db.Entry(farmer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FarmerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // PUT: api/Farmers/5/AddAddress
        [Route("{id:int}/AddAddress")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> AddFarmerAddress(int id, Farmer farmer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != farmer.Id)
            {
                return BadRequest();
            }

            db.Entry(farmer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FarmerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Farmers
        [Route("")]
        [ResponseType(typeof(Farmer))]
        public async Task<IHttpActionResult> PostFarmer(Farmer farmer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Farmers.Add(farmer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = farmer.Id }, farmer);
        }

        // DELETE: api/Farmers/5
        [Route("{id:int}")]
        [ResponseType(typeof(Farmer))]
        public async Task<IHttpActionResult> DeleteFarmer(int id)
        {
            Farmer farmer = await db.Farmers.FindAsync(id);
            if (farmer == null)
            {
                return NotFound();
            }

            db.Farmers.Remove(farmer);
            await db.SaveChangesAsync();

            return Ok(farmer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FarmerExists(int id)
        {
            return db.Farmers.Count(e => e.Id == id) > 0;
        }
    }
}