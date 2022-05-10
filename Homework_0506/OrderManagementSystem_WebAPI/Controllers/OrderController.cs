using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem_WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderManagementSystem_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDB;

        public OrderController(OrderContext orderDB)
        {
            this.orderDB = orderDB;
        }



        // GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            var orders = orderDB.Orders.ToList();

            return orders;
        }

        // GET api/Order/Id
        [HttpGet("{Id}")]
        public ActionResult<Order> GetOrder(int Id)
        {
            return orderDB.Orders.FirstOrDefault(o=>o.Id == Id);
        }

        // POST api/Order
        [HttpPost]
        public ActionResult<Order> Post([FromBody] Order order)
        {
            try
            {
                orderDB.Orders.Add(order);
                orderDB.SaveChanges();

            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT api/Order/5
        [HttpPut("{Id}")]
        public ActionResult<Order> Put(int Id, [FromBody] Order order)
        {
            if (Id != order.Id)
            {
                return BadRequest("It cannot be modifed.");
            }
            try
            {
                orderDB.Orders.Remove(order);
                orderDB.Orders.Add(order);
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE api/Order/Id
        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {
            try
            {
                orderDB.Orders.Remove(orderDB.Orders.FirstOrDefault(o=>o.Id==Id));
                orderDB.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            return NoContent();
        }
    }
}
