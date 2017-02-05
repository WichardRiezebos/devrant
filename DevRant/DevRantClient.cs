﻿using DevRant.Dtos;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DevRant
{
    /// <summary>
    /// Represents a class for the devrant public api. 
    /// </summary>
    public class DevRantClient : IDevRantClient, IDisposable
    {
        private const int appVersion = 3;
        private const string baseAddress = "https://www.devrant.io/";

        private HttpClient client;

        /// <summary>
        /// Initializes a new <see cref="DevRantClient"/>.
        /// </summary>
        public DevRantClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
        }

        /// <summary>
        /// Requests profile details to the rest-api.
        /// </summary>
        /// <param name="username">Username of the profile to request.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="username"/> is empty.</exception>
        /// <inheritdoc />
        public async Task<Profile> GetProfileAsync(string username)
        {
            if (string.IsNullOrEmpty(username)) throw new ArgumentException("Must be non-empty.", nameof(username));

            var userId = await GetUserId(username);

            if (userId == null)
            {
                return null;
            }

            var response = await client.GetAsync($"/api/users/{userId}?app={appVersion}");
            var responseText = await response.Content.ReadAsStringAsync();

            return ParseProperty<Profile>(responseText, "profile");
        }

        /// <summary>
        /// Requests a collection of rants sorted and selected by the arguments from the rest-api.
        /// </summary>
        /// <param name="sort">Sorting of the rant collection.</param>
        /// <param name="limit">Maximal rants to return.</param>
        /// <param name="skip">Number of rants to skip.</param>
        /// <inheritdoc />
        public async Task<IReadOnlyCollection<RantInfo>> GetRantsAsync(RantSort sort = RantSort.Algo, int limit = 50, int skip = 0)
        {
            var sortText = sort
                .ToString()
                .ToLower();

            var response = await client.GetAsync($"/api/devrant/rants?app={appVersion}&sort={sortText}&limit={limit}&skip={skip}");
            var responseText = await response.Content.ReadAsStringAsync();

            return ParseProperty<List<RantInfo>>(responseText, "rants");
        }

        private async Task<int?> GetUserId(string username)
        {
            var response = await client.GetAsync($"/api/get-user-id?app={appVersion}&username={username}");
            var responseText = await response.Content.ReadAsStringAsync();

            return ParseProperty<int?>(responseText, "user_id");
        }

        private T ParseProperty<T>(string jsonText, string propertyName)
        {
            var obj = JObject.Parse(jsonText);
            var prop = obj.GetValue(propertyName);

            return prop == null
                ? default(T)
                : prop.ToObject<T>();
        }

        /// <summary>
        /// Releases all used resources by the <see cref="DevRantClient"/> instance.
        /// </summary>
        public void Dispose()
        {
            client?.Dispose();
            client = null;
        }
    }
}
