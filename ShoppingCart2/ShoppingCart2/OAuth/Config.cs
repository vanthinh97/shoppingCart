using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart2.OAuth
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource(
                    "ShoppingCart.ReadAccess",
                    "ShoppingCart API",
                    new List<string> {
                        JwtClaimTypes.Id,
                        JwtClaimTypes.Email,
                        JwtClaimTypes.Name,
                        JwtClaimTypes.GivenName,
                        JwtClaimTypes.FamilyName
                    }
                ),

                new ApiResource("ShoppingCart.FullAccess", "ShoppingCart API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "HTML Page Client",
                    ClientId = "htmlClient",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    ClientSecrets =
                    {
                        new Secret("secretpassword".Sha256())
                    },

                    AllowedScopes = { "ShoppingCart.ReadAccess" }
                }
            };
        }
    }
}
