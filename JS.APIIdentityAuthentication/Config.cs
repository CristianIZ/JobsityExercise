using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JS.APIIdentityAuthentication
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("myresourceapi", "My Resource API")
                {
                    Scopes = {("apiscope")}
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                // for public api
                new Client
                {
                    ClientId = "secret_client_id",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "apiscope" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
             {
                 new ApiScope(name: "read",   displayName: "Read your data."),
                 new ApiScope(name: "write",  displayName: "Write your data."),
                 new ApiScope(name: "delete", displayName: "Delete your data."),
                 new ApiScope(name: "apiscope", displayName: "Api Scope.")
             };
        }
    }
}
