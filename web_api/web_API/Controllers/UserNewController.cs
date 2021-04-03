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
    [RoutePrefix ("api/UserNew")]
    public class UserNewController : ApiController
    {
        // GET api/<controller>
        public List<UserNewDTO> Get()
        {
            swishDBContext db = new swishDBContext();
            var user = db.S_User_New.Select(x => new UserNewDTO()
            {
                id = x.id,
                firstName = x.firstName,
                lastName = x.lastName,
                email = x.email,
                password = x.password,
                profilePicture = x.profilePicture,
                phoneNumber = x.phoneNumber,
                residence=x.residence,
                radius = x.radius,
                birthDate = x.birthDate,
                itemViewingMethod = x.itemViewingMethod,
                avatarlevel = x.avatarlevel,
                //dailySentenceId = (int) x.dailySentenceId
            }).ToList();

            return user;
        }
        [HttpGet]
        [Route ("logIn")]
        public List<UserNewDTO> logIn()
        {
            swishDBContext db = new swishDBContext();
            var user = db.S_User_New.Select(x => new UserNewDTO()
            {
                email = x.email,
                password = x.password
                
            }).ToList();

            return user;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post(UserNewDTO userDTO)
        {
            swishDBContext db = new swishDBContext();
            S_User_New user = new S_User_New();

            user.id = userDTO.id;
            user.firstName = userDTO.firstName;
            user.lastName = userDTO.lastName;
            user.phoneNumber = userDTO.phoneNumber;
            user.email = userDTO.email;
            user.password = userDTO.password;
            user.profilePicture = userDTO.profilePicture;
            user.residence = userDTO.residence;
            user.radius = userDTO.radius;
            user.birthDate = userDTO.birthDate;
            user.itemViewingMethod = userDTO.itemViewingMethod;
            user.avatarlevel = "1";
            user.dailySentenceId = 1;
            

            try
            {
                db.S_User_New.Add(user);
                db.SaveChanges();

            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateResponse(HttpStatusCode.Conflict, "נא לנסות שוב");
            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotImplemented, ex.Message);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "משתמש נוסף בהצלחה");
        }

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