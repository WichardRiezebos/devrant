using System.Collections.Generic;
using System.Threading.Tasks;
using DevRant.Dtos;

namespace DevRant
{
    /// <summary>
    /// Represents an interface which describes the public api for devrant.
    /// </summary>
    public interface IDevRantClient
    {
        /// <summary>
        /// Requests profile details to the rest-api.
        /// </summary>
        /// <param name="username">Username of the profile to request.</param>
        Task<Profile> GetProfileAsync(string username);
    }
}