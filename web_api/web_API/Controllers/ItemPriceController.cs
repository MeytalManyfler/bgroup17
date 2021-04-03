using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DATA;
using web_API.DTO;

namespace web_API.Controllers
{
    public class ItemPriceController : ApiController
    {
        // GET api/<controller>
        public List<ItemPriceDTO> Get()
        {
            swishDBContext db = new swishDBContext();
            var itemPrice = db.S_ItemPrice.Select(x => new ItemPriceDTO()
            {
                id= x.id,
                name = x.name,
                price = (int)x.price
            }).ToList();
            return itemPrice;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}