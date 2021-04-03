using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DATA;
using web_API.DTO;

namespace web_API.Controllers
{
    [RoutePrefix("api/UserItems")]
    public class UserItemsController : ApiController
    {
        //GET api/<controller>
        public List<UserItemsDTO> Get()
        {
            swishDBContext db = new swishDBContext();
            var userItems = db.S_User_Items.Select(x => new UserItemsDTO()
            {
                id = x.id,
                email = x.email,
                itemId = (int)x.itemId,
                uploadDate = x.uploadDate
            }).ToList();

            return userItems;
        }

        // POST api/<controller>
        [Route("api/UserItems/{userEmail}/{idItem}")]
        public HttpResponseMessage Post(string userEmail, int idItem, UserItemsDTO userItem)
        {
            swishDBContext db = new swishDBContext();
            S_User_Items userItems = new S_User_Items();

            userItems.email = userEmail;
            userItems.itemId = idItem;
            userItems.uploadDate = userItem.uploadDate;
            db.S_User_Items.Add(userItems);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateResponse(HttpStatusCode.Conflict, "נא לנסות שוב, שמירה במקביל");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotImplemented, "שגיאה כללית");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "העלאת פריט למשתמש בוצעה בהצלחה");

        }
        [Route("api/UserItems/{userEmail}")]
        public dynamic Get(string userEmail)
        {
            swishDBContext db = new swishDBContext();
            var userItem = db.S_User_Items.Where(y => y.email == userEmail).Select(x => new
            {
                id = x.id,
                email = x.email,
                itemId = (int)x.itemId,
                uploadDate = x.uploadDate
            }).ToList();

            return userItem;

        }
        //db.Students.Where(x => x.Purchases.Count == 0).Select(x => x.Name).ToList();
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}