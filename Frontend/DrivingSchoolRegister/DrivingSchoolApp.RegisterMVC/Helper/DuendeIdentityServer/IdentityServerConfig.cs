using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace DrivingSchoolApp.RegisterMVC.Helper.DuendeIdentityServer
{
    public class IdentityServerConfig
    {

		public static IEnumerable<IdentityResource> Resources =>
			new List<IdentityResource>
			{
				new IdentityResources.OpenId(),
				new IdentityResources.Email(),
				new IdentityResources.Profile()
			};
		public static IEnumerable<ApiScope> Scopes =>
			new List<ApiScope>
			{
				new ApiScope(name: "grendma",displayName: "grendma server"),
				new ApiScope(name: "read", displayName: "reading data"),
				new ApiScope(name: "write", displayName: "writing data"),
				new ApiScope(name: "delete", displayName: "delete data")
			};
		public static IEnumerable<Client> Clients =>
			new List<Client>
			{
				new Client
				{
					ClientId = "client",
					ClientSecrets = {new Secret("secret".Sha256())},
					AllowedGrantTypes = GrantTypes.ClientCredentials,
					AllowedScopes = {"read","write","profile"}
                },
				new Client
				{
					ClientId="angular",
					AllowedGrantTypes= GrantTypes.Code,
					RequireClientSecret = false,
					AllowOfflineAccess = true,
					RedirectUris = { "http://localhost:4200"},
					PostLogoutRedirectUris = { "http://localhost:4200" },
					AllowedCorsOrigins = {"http://localhost:4200","https://localhost:4200"},
					AllowedScopes = new List<string>
					{
						IdentityServerConstants.StandardScopes.OpenId,
						IdentityServerConstants.StandardScopes.Profile,
						IdentityServerConstants.StandardScopes.OfflineAccess,
						IdentityServerConstants.StandardScopes.Email,
                        "grendma"
                    },
				}
			};
	}
}
