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

namespace ProjectFarmerAPI.Controllers
{
    [RoutePrefix("api/items")]
    public class ItemsController : ApiController
    {
        private ItemDataAccess access = new ItemDataAccess();

        // GET: api/Items
        [Route("")]
        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException("We are sorry, But you can't complete this call, please refer to the API Manual");
        }

        // GET: api/items/sellable
        [Route("sellable")]
        public IEnumerable<Item> GetSellableItems(int requestedBy)
        {
            if(requestedBy <= 0)
            {
                throw new ArgumentOutOfRangeException("requestedBy should be the user_id");
            }
            return GetSellableInventories(requestedBy);
        }

        /// <summary>
        /// Followup method
        /// </summary>
        /// <param name="requestedBy"></param>
        /// <returns></returns>
        private IEnumerable<Item> GetSellableInventories(int requestedBy)
        {
            var inventories = access.GetSellableInventories(requestedBy);
            ValidateInventoryObject(inventories);
            return inventories;
        }

        /// <summary>
        /// Validate that inventory object to make ure it does not have wrong categorization.
        /// </summary>
        /// <param name="sellableItems"></param>
        private void ValidateInventoryObject(IEnumerable<Item> sellableItems)
        {
            if (sellableItems != null)
            {
                foreach (var item in sellableItems)
                {
                    if (item.Category == ItemCategory.None || item.QuantityBy == ItemQuantityBy.None || item.Rate <= 0 || string.IsNullOrWhiteSpace(item.ResourceUrl))
                    {
                        throw new InvalidOperationException("The Inventories data is not valid");
                    }
                }
            }

        }

        // GET: api/Items/5
        [Route("{id:int}")]
        [ResponseType(typeof(Item))]
        public async Task<IHttpActionResult> GetItem(int id)
        {
            //Item item = await db.Items.FindAsync(id);
            //if (item == null)
            //{
            //    return NotFound();
            //}

            //return Ok(item);
            return null;
        }

        // PUT: api/Items/5
        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutItem(int id, Item item)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != item.Id)
            //{
            //    return BadRequest();
            //}

            //db.Entry(item).State = EntityState.Modified;

            //try
            //{
            //    await db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ItemExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return StatusCode(HttpStatusCode.NoContent);
            return null;
        }

        // POST: api/Items
        [Route("")]
        [ResponseType(typeof(Item))]
        public async Task<IHttpActionResult> PostItem(Item item)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //db.Items.Add(item);
            //await db.SaveChangesAsync();

            //return CreatedAtRoute("DefaultApi", new { id = item.Id }, item);
            return null;
        }

        // DELETE: api/Items/5
        [Route("{id:int}")]
        [ResponseType(typeof(Item))]
        public async Task<IHttpActionResult> DeleteItem(int id)
        {
            //Item item = await db.Items.FindAsync(id);
            //if (item == null)
            //{
            //    return NotFound();
            //}

            //db.Items.Remove(item);
            //await db.SaveChangesAsync();

            //return Ok(item);
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                access.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItemExists(int id)
        {
            //return db.Items.Count(e => e.Id == id) > 0;
            return true;
        }
    }
}