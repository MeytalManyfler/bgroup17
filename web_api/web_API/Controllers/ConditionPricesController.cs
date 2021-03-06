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
    public class ConditionPricesController : ApiController
    {
        // GET api/<controller>
        public List<ConditionPricesDTO> Get()
        {
            swishDBContext db = new swishDBContext();
            var conditionPrices = db.S_ConditionPrices.Select(x => new ConditionPricesDTO()
            {
                id= x.id,
                condition = x.condition,
                reduction = (int)x.reduction
            }).ToList();
            return conditionPrices;
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