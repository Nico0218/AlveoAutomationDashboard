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


        // GET api/<TempUIController>/5
        [HttpGet("GetWord")]
        public string GetWord(int position) {
            return tempUIService.ReadWord(position).Result;
        }

        [HttpGet("GetInt")]
        public string GetInt(int position)
        {
            return tempUIService.ReadInt(position).Result;
        }

        [HttpGet("GetBit")]
        public string GetBit(int position, int bit)
        {
            return tempUIService.ReadBit(position, bit).Result;
        }

        [HttpGet("GetByte")]
        public string GetByte(int position)
        {
            return tempUIService.ReadByte(position).Result;
        }

        [HttpGet("GetChars")]
        public string GetChars(int position, int size)
        {
            return tempUIService.ReadChars(position, size).Result;
        }

        [HttpGet("GetDWord")]
        public string GetDWord(int position)
        {
            return tempUIService.ReadDWord(position).Result;
        }

        [HttpGet("GetDInt")]
        public string GetDInt(int position)
        {
            return tempUIService.ReadDInt(position).Result;
        }

        [HttpGet("GetReal")]
        public string GetReal(int position)
        {
            return tempUIService.ReadReal(position).Result;
        }

        [HttpGet("SetWord")]
        public void SetWord(int position, ushort value)
        {
            tempUIService.WriteWord(position, value);
        }

        [HttpGet("SetBit")]
        public void SetBit(int position, int bit)
        {
            tempUIService.WriteBit(position, bit);
        }

        [HttpGet("SetByte")]
        public void SetByte(int position, byte value)
        {
            tempUIService.WriteByte(position, value);
        }

        [HttpGet("SetChars")]
        public void SetChars(int position, string value)
        {
            tempUIService.WriteChars(position, value);
        }

        [HttpGet("SetInt")]
        public void SetInt(int position, short value)
        {
            tempUIService.WriteInt(position, value);
        }

        [HttpGet("SetDWord")]
        public void SetDWord(int position, uint value)
        {
            tempUIService.WriteDWord(position, value);
        }

        [HttpGet("SetDInt")]
        public void SetDInt(int position, int value)
        {
            tempUIService.WriteDInt(position, value);
        }

        [HttpGet("SetReal")]
        public void SetReal(int position, float value)
        {
            tempUIService.WriteReal(position, value);
        }

        [HttpGet("SetDBInt")]
        public void SetDBInt(int dbNumber, int position, short value)
        {
            tempUIService.WriteDBInt(dbNumber, position, value);
        }

        [HttpGet("SetDBTime")]
        public void SetDBTime(int dbNumber, int position, int value)
        {
            tempUIService.WriteDBTime(dbNumber, position, value);
        }

        [HttpGet("SetDBReal")]
        public void SetDBReal(int dbNumber, int position, float value)
        {
            tempUIService.WriteDBReal(dbNumber, position, value);
        }

        [HttpGet("SetDBWord")]
        public void SetDBWord(int dbNumber, int position, ushort value)
        {
            tempUIService.WriteDBWord(dbNumber, position, value);
        }

        [HttpGet("SetDBDInt")]
        public void SetDBDInt(int dbNumber, int position, ushort value)
        {
            tempUIService.WriteDBDInt(dbNumber, position, value);
        }

        [HttpGet("bitChangeDB")]
        public void bitChangeDB(int dbNumber, int position, int bit)
        {
            tempUIService.bitChangeDB(dbNumber, position, bit);
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
