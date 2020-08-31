using Bayolu.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bayolu.View.ServiceRepository
{
    public class UserServiceRepository : BaseServiceRepository
    {
        private readonly string _submitUser = "/users";
        private readonly string _getUsers = "/users/keyvalues";
        public UserServiceRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<HttpResponse<UserViewModel>> SubmitUser(UserViewModel model)
        {
            return await Post(_submitUser, model);
        }
        public async Task<HttpResponse<List<KeyValuePair<Guid, string>>>> GetUsers()
        {
            return await Get<List<KeyValuePair<Guid, string>>>(_getUsers);
        }
    }
}
