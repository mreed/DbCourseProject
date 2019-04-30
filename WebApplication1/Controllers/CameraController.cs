using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : ControllerBase
    {
        public CameraController(ApplicationDbContext context)
        {
            db = context;
        }
        private ApplicationDbContext db;
        // GET: api/Camera
        [HttpGet]
        public IEnumerable<Camera> Get()
        {
            return db.Cameras.OrderBy(x => x.Model).ToList();
        }

        // GET: api/Camera/5
        [HttpGet("{id}", Name = "GetCamera")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Camera
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Camera/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
