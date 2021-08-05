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
        [HttpGet("GetWord")]
        public string GetWord(int position) {
            return plcInterface.ReadWord(position);
        }

        [HttpGet("GetInt")]
        public string GetInt(int position)
        {
            return (plcInterface.ReadInt(position)).ToString();
        }

        [HttpGet("GetBit")]
        public string GetBit(int position, int Bit)
        {
            return (plcInterface.ReadBit(position, Bit)).ToString();
        }

        [HttpGet("GetByte")]
        public string GetByte(int position)
        {
            return (plcInterface.ReadByte(position)).ToString();
        }

        [HttpGet("GetChars")]
        public string GetChars(int position, int size)
        {
            return (plcInterface.ReadChars(position, size)).ToString();
        }

        [HttpGet("GetDWord")]
        public string GetDWord(int position)
        {
            return (plcInterface.ReadDWord(position)).ToString();
        }

        [HttpGet("GetDInt")]
        public string GetDInt(int position)
        {
            return (plcInterface.ReadDInt(position)).ToString();
        }

        [HttpGet("GetReal")]
        public string GetReal(int position)
        {
            return (plcInterface.ReadReal(position)).ToString();
        }

        [HttpGet("SetWord")]
        public void SetWord(int position, ushort value)
        {
            plcInterface.WriteWord(position, value);
        }

        [HttpGet("SetBit")]
        public void SetBit(int position, int bit)
        {
            plcInterface.WriteBit(position, bit);
        }

        [HttpGet("SetByte")]
        public void SetByte(int position, byte value)
        {
            plcInterface.WriteByte(position, value);
        }

        [HttpGet("SetChars")]
        public void SetChars(int position, string value)
        {
            plcInterface.WriteChars(position, value);
        }

        [HttpGet("SetInt")]
        public void SetInt(int position, short value)
        {
            plcInterface.WriteInt(position, value);
        }

        [HttpGet("SetDWord")]
        public void SetDWord(int position, uint value)
        {
            plcInterface.WriteDWord(position, value);
        }

        [HttpGet("SetDInt")]
        public void SetDInt(int position, int value)
        {
            plcInterface.WriteDInt(position, value);
        }

        [HttpGet("SetReal")]
        public void SetReal(int position, float value)
        {
            plcInterface.WriteReal(position, value);
        }

        [HttpGet("SetDBInt")]
        public void SetIntDB(int dbNumber, int position, short value)
        {
            plcInterface.intDbWrite(dbNumber, position, value);
        }

        [HttpGet("SetDBTime")]
        public void SetTimeDB(int dbNumber, int position, int value)
        {
            plcInterface.timeDbWrite(dbNumber, position, value);
        }

        [HttpGet("SetDBReal")]
        public void SetRealDB(int dbNumber, int position, float value)
        {
            plcInterface.realDbWrite(dbNumber, position, value);
        }

        [HttpGet("SetDBWord")]
        public void SetWordDB(int dbNumber, int position, ushort value)
        {
            plcInterface.wordDbWrite(dbNumber, position, value);
        }

        [HttpGet("SetDBDInt")]
        public void SetDIntDB(int dbNumber, int position, ushort value)
        {
            plcInterface.dIntDbWrite(dbNumber, position, value);
        }

        [HttpGet("SetDBBit")]
        public void SetBitDB(int dbNumber, int bit, ushort value)
        {
            plcInterface.bitChangeDB(dbNumber, bit);
        }

        // GET api/<PLC>/5
        [HttpGet("id")]
        public string Get(int id) {
            return "Value";
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
