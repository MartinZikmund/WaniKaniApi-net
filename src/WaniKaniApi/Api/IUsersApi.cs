using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models.Users;

namespace WaniKaniApi.Api
{
    public interface IUsersApi
    {
        Task<User> GetAsync();

        Task<Preferences> UpdatePreferencesAsync(Preferences preferences);
    }
}
