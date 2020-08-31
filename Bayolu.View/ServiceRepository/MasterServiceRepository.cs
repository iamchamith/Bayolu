using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bayolu.View.ServiceRepository
{
    public class MasterServiceRepository : BaseServiceRepository
    {
        private readonly string _getTeams = "/master/teams";
        private readonly string _getRoles = "/master/roles";
        public MasterServiceRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<HttpResponse<List<KeyValuePair<int, string>>>> GetTeams()
        {
            return await Get<List<KeyValuePair<int, string>>>(_getTeams);
        }
        public async Task<HttpResponse<List<KeyValuePair<int, string>>>> GetRoles()
        {
            return await Get<List<KeyValuePair<int, string>>>(_getRoles);
        }
    }
}
