using AutomationDashboard.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomationDashboard.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class TempUIController : ControllerBase {
        private TempUIService tempUIService;

        public TempUIController(TempUIService tempUIService) {
            this.tempUIService = tempUIService;
        }

        // GET: api/<TempUIController>
        [HttpGet]
        public string Get() {
            return tempUIService.ReadWord().Result;
        }

        // GET api/<TempUIController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<TempUIController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<TempUIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<TempUIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
