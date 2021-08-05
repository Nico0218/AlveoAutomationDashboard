using System.Net.Http;
using System.Threading.Tasks;

namespace AutomationDashboard.Services {
    public class TempUIService {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();
        private string clinetIP = "https://localhost:44300/api/PLC";

        public async Task<string> ReadWord() {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetWord");
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                return await response.Content.ReadAsStringAsync();
            } else {
                throw new System.Exception("Request Error");
            }
        }

        public async Task<string> ReadInt()
        {
            HttpResponseMessage response = await client.GetAsync(clinetIP + "/GetInt");
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
