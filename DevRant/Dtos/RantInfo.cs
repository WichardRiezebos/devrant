using Newtonsoft.Json;

namespace DevRant.Dtos
{
    /// <summary>
    /// Represents a data-transfer-object used for basic information about a rant.
    /// </summary>
    public class RantInfo
    {
        /// <summary>
        /// Represents the identity of the rant.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Represents the text of the rant.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Represents the number of upvotes of the rant.
        /// </summary>
        [JsonProperty("num_upvotes")]
        public int NrOfUpvotes { get; set; }

        /// <summary>
        /// Represents the number of downvotes of the rant.
        /// </summary>
        [JsonProperty("num_downvotes")]
        public int NrOfDownvotes { get; set; }
    }
}
