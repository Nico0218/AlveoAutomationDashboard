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
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetInt?position=" + position.ToString() + ":bit=" + bit.ToString());
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
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetChars?position=" + position.ToString() + ":size=" + size.ToString());
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

    }
}
