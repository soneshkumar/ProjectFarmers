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
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        private OrderDataAccess orderAccess = new OrderDataAccess();

        // GET: api/Orders
        public IQueryable<Order> SearchOrders()
        {
            //return db.Orders;
            return null;
        }

        // GET: api/Orders/5
        [Route("{id:int}")]
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> GetOrderById(int id)
        {
            //Order order = await db.Orders.FindAsync(id);
            //if (order == null)
            //{
            //    return NotFound();
            //}

            //return Ok(order);
            return null;
        }

        // PUT: api/Orders/5
        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrder(int id, Order order)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != order.Id)
            //{
            //    return BadRequest();
            //}

            //db.Entry(order).State = EntityState.Modified;

            //try
            //{
            //    await db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!OrderExists(id))
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

        // POST: api/Orders/5/updateStatus
        [Route("{id:int}/updateStatus")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateOrderStatus(int id, OrderStatus newStatus)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //try
            //{
            //    await db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!OrderExists(id))
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

        // POST: api/Orders
        [Route("")]
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> PostOrder(Order order)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //db.Orders.Add(order);
            //await db.SaveChangesAsync();

            //return CreatedAtRoute("DefaultApi", new { id = order.Id }, order);
            return null;
        }

        // DELETE: api/Orders/5
        [Route("{id:int}")]
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> DeleteOrder(int id)
        {
            //Order order = await db.Orders.FindAsync(id);
            //if (order == null)
            //{
            //    return NotFound();
            //}

            //db.Orders.Remove(order);
            //await db.SaveChangesAsync();

            //return Ok(order);
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                orderAccess.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            //return db.Orders.Count(e => e.Id == id) > 0;
            return true;
        }
    }
}