using Garage_MVC_WEB_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Garage_MVC_WEB_API.Controllers.api
{
    public class CarController : ApiController
    {
        Model1 contact = new Model1();
        // GET: api/Car
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(contact.cars.ToList());

            }
            catch (sqlException ex){return BadRequest(ex.Message);}
            catch (Exception ex) { return BadRequest(ex.Message); }


        }

        // GET: api/Car/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Car
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Car/5
        public void Delete(int id)
        {
        }
    }
}
