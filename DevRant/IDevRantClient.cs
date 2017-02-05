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

        /// <summary>
        /// Requests a collection of rants sorted and selected by the arguments from the rest-api.
        /// </summary>
        /// <param name="sort">Sorting of the rant collection.</param>
        /// <param name="limit">Maximal rants to return.</param>
        /// <param name="skip">Number of rants to skip.</param>
        Task<IReadOnlyCollection<RantInfo>> GetRantsAsync(RantSort sort = RantSort.Algo, int limit = 50, int skip = 0);
    }
}