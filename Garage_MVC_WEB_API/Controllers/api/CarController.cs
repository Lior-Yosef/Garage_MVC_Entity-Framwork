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
            try
            {
                return Ok(contact.cars.First(item => item.Id == id));

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }

        }

        // POST: api/Car
        public IHttpActionResult Post([FromBody]Car value)
        {
            try
            {
                contact.cars.Add(value);
                contact.SaveChanges();
                return Ok("row add Successfully");

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT: api/Car/5
        public IHttpActionResult Put(int id, [FromBody]Car value)
        {
            try
            {
                Car NewCar = contact.cars.First(item => item.Id == id);
                NewCar.OwnerName = value.OwnerName;
                NewCar.CarNumber = value.CarNumber;
                NewCar.CarStatus = value.CarStatus;
                contact.SaveChanges();
                return Ok(new { NewCar });

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/Car/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Car carRenomve = contact.cars.First(car => car.Id == id);
                contact.cars.Remove(carRenomve);
                contact.SaveChanges();
                return Ok(contact.cars.ToList());

            }
            catch (sqlException ex) {return BadRequest(ex.Message);}
            catch (Exception ex) { return BadRequest(ex.Message); }

        }
    }
}
