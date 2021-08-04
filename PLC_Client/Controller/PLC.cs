using Microsoft.AspNetCore.Mvc;
using PLC_Client.Services;
using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLC_Client.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class PLC : ControllerBase {
        private PLCInterface plcInterface;

        public PLC(PLCInterface plcInterface) {
            this.plcInterface = plcInterface;
        }

        // GET: api/<PLC>
        [HttpGet]
        public string Get() {
            return plcInterface.ReadArea(2, 4, S7WordLength.Word);
        }

        // GET api/<PLC>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<PLC>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<PLC>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<PLC>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
