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
            plcInterface.Connect();
            return plcInterface.ReadWord(position);
            plcInterface.Disconnect();
        }

        [HttpGet("GetInt")]
        public string GetInt(int position)
        {
            plcInterface.Connect();
            return (plcInterface.ReadInt(position)).ToString();
            plcInterface.Disconnect();
        }

        [HttpGet("GetBit")]
        public string GetBit(int position, int Bit)
        {
            plcInterface.Connect();
            return (plcInterface.ReadBit(position, Bit)).ToString();
            plcInterface.Disconnect();
        }

        [HttpGet("GetByte")]
        public string GetByte(int position)
        {
            plcInterface.Connect();
            return (plcInterface.ReadByte(position)).ToString();
            plcInterface.Disconnect();
        }

        [HttpGet("GetChars")]
        public string GetChars(int position, int size)
        {
            plcInterface.Connect();
            return (plcInterface.ReadChars(position, size)).ToString();
            plcInterface.Disconnect();
        }

        [HttpGet("GetDWord")]
        public string GetDWord(int position)
        {
            plcInterface.Connect();
            return (plcInterface.ReadDWord(position)).ToString();
            plcInterface.Disconnect();
        }

        [HttpGet("GetDInt")]
        public string GetDInt(int position)
        {
            plcInterface.Connect();
            return (plcInterface.ReadDInt(position)).ToString();
            plcInterface.Disconnect();
        }

        [HttpGet("GetReal")]
        public string GetReal(int position)
        {
            plcInterface.Connect();
            return (plcInterface.ReadReal(position)).ToString();
            plcInterface.Disconnect();
        }

        [HttpGet("SetWord")]
        public void SetWord(int position, ushort value)
        {
            plcInterface.Connect();
            plcInterface.WriteWord(position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetBit")]
        public void SetBit(int position, int bit)
        {
            plcInterface.Connect();
            plcInterface.WriteBit(position, bit);
            plcInterface.Disconnect();
        }

        [HttpGet("SetByte")]
        public void SetByte(int position, byte value)
        {
            plcInterface.Connect();
            plcInterface.WriteByte(position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetChars")]
        public void SetChars(int position, string value)
        {
            plcInterface.Connect();
            plcInterface.WriteChars(position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetInt")]
        public void SetInt(int position, short value)
        {
            plcInterface.Connect();
            plcInterface.WriteInt(position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDWord")]
        public void SetDWord(int position, uint value)
        {
            plcInterface.Connect();
            plcInterface.WriteDWord(position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDInt")]
        public void SetDInt(int position, int value)
        {
            plcInterface.Connect();
            plcInterface.WriteDInt(position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetReal")]
        public void SetReal(int position, float value)
        {
            plcInterface.Connect();
            plcInterface.WriteReal(position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDBInt")]
        public void SetIntDB(int dbNumber, int position, short value)
        {
            plcInterface.Connect();
            plcInterface.intDbWrite(dbNumber, position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDBTime")]
        public void SetTimeDB(int dbNumber, int position, int value)
        {
            plcInterface.Connect();
            plcInterface.timeDbWrite(dbNumber, position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDBReal")]
        public void SetRealDB(int dbNumber, int position, float value)
        {
            plcInterface.Connect();
            plcInterface.realDbWrite(dbNumber, position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDBWord")]
        public void SetWordDB(int dbNumber, int position, ushort value)
        {
            plcInterface.Connect();
            plcInterface.wordDbWrite(dbNumber, position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDBDInt")]
        public void SetDIntDB(int dbNumber, int position, ushort value)
        {
            plcInterface.Connect();
            plcInterface.dIntDbWrite(dbNumber, position, value);
            plcInterface.Disconnect();
        }

        [HttpGet("SetDBBit")]
        public void SetBitDB(int dbNumber, int bit, ushort value)
        {
            plcInterface.Connect();
            plcInterface.bitChangeDB(dbNumber, bit);
            plcInterface.Disconnect();
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
