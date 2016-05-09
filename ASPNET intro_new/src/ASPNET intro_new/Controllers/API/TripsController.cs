using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASPNET_intro_new.Models;
using AutoMapper;
using ASPNET_intro_new.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET_intro_new.Controllers.API
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private TripsRepository repository;
        public TripsController(TripsRepository rep)
        {
            rep = repository;
        }
        // GET: api/values
        [HttpGet]
        public JsonResult Get(JsonResult result)
        {
            repository.GetAllTrips();
            var results = Mapper.Map<IEnumerable<TripViewModel>>(result);
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Trip Get(Trip theTrip)
        {
            return theTrip;
        }

        // POST api/values
        //[HttpPost]
        //public JsonResult Post([FromBody]TripViewModel trip)
        //{
        //    if (ModelState.IsValid)
        //    {
                
        //    }
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
