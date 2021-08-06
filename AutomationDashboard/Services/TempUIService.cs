using System.Net.Http;
using System.Threading.Tasks;

namespace AutomationDashboard.Services {
    public class TempUIService {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();
        private string clinetIP = "https://localhost:44300/api/PLC";

        public async Task<string> ReadWord(int position) {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetWord?position=" + position.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                return await response.Content.ReadAsStringAsync();
            } else {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadInt(int position)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetInt?position=" + position.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadBit(int position, int bit)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetInt?position=" + position.ToString() + "&bit=" + bit.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadByte(int position)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetByte?position=" + position.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadChars(int position, int size)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetChars?position=" + position.ToString() + "&size=" + size.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadDWord(int position)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetDWord?position=" + position.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadDInt(int position)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetDInt?position=" + position.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadReal(int position)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetReal?position=" + position.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteWord(int position, ushort value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetWord?position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteBit(int position, int bit)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetBit?position=" + position.ToString() + "&value=" + bit.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteByte(int position, int value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetByte?position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteChars(int position, string value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetChars?position=" + position.ToString() + "&value=" + value);
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteInt(int position, short value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetInt?position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteDWord(int position, uint value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetDWord?position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteDInt(int position, int value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetDInt?position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteReal(int position, float value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetReal?position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteDBInt(int dbNumber, int position, short value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetDBInt?dbNumber=" + dbNumber.ToString() + "&position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteDBTime(int dbNumber, int position, int value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetDBTime?dbNumber=" + dbNumber.ToString() + "&position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteDBReal(int dbNumber, int position, float value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetDBReal?dbNumber=" + dbNumber.ToString() + "&position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteDBWord(int dbNumber, int position, ushort value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetDBDWord?dbNumber=" + dbNumber.ToString() + "&position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> WriteDBDInt(int dbNumber, int position, ushort value)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/SetDBDInt?dbNumber=" + dbNumber.ToString() + "&position=" + position.ToString() + "&value=" + value.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> bitChangeDB(int dbNumber, int position, int bit)
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/bitChangeDB?dbNumber=" + dbNumber.ToString() + "&position=" + position.ToString() + "&bit=" + bit.ToString());
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception("Request Error");
            }
        }



    }
}
