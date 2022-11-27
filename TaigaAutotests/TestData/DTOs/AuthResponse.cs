using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaigaAutotests.TestData.DTOs
{
    public class AuthResponse
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonProperty("full_name_display", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("full_name_display")]
        public string FullNameDisplay { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonProperty("bio", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("theme")]
        public string Theme { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("is_active", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("photo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("photo")]
        public object Photo { get; set; }

        [JsonProperty("big_photo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("big_photo")]
        public object BigPhoto { get; set; }

        [JsonProperty("gravatar_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("roles")]
        public List<object> Roles { get; set; }

        [JsonProperty("total_private_projects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("total_private_projects")]
        public int? TotalPrivateProjects { get; set; }

        [JsonProperty("total_public_projects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("total_public_projects")]
        public int? TotalPublicProjects { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("date_joined", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("date_joined")]
        public DateTime? DateJoined { get; set; }

        [JsonProperty("read_new_terms", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("read_new_terms")]
        public bool? ReadNewTerms { get; set; }

        [JsonProperty("accepted_terms", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("accepted_terms")]
        public bool? AcceptedTerms { get; set; }

        [JsonProperty("max_private_projects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("max_private_projects")]
        public int? MaxPrivateProjects { get; set; }

        [JsonProperty("max_public_projects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("max_public_projects")]
        public object MaxPublicProjects { get; set; }

        [JsonProperty("max_memberships_private_projects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("max_memberships_private_projects")]
        public int? MaxMembershipsPrivateProjects { get; set; }

        [JsonProperty("max_memberships_public_projects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("max_memberships_public_projects")]
        public object MaxMembershipsPublicProjects { get; set; }

        [JsonProperty("verified_email", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("verified_email")]
        public bool? VerifiedEmail { get; set; }

        [JsonProperty("refresh", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("refresh")]
        public string Refresh { get; set; }

        [JsonProperty("auth_token", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("auth_token")]
        public string AuthToken { get; set; }

    }
}
