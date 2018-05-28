using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Test;
using IdentityServer4.Models;
using System.Security.Claims;

namespace Core2_IDP
{

  public static class IdentityServerConfig
  {

    public static List<TestUser> GetUsers()
    {
      return new List<TestUser> 
      {
        new TestUser
        {
          SubjectId = "c7efce08-1f44-48ba-a3f9-dcffa65b6541",
          Username = "Frank",
          Password = "password",

          Claims = new List<Claim>
          {
            new Claim("given_name", "Frank"),
            new Claim("family_name", "Underwood"),
          }
        },
        new TestUser
        {
          SubjectId = "965bf018-726f-47be-a936-7130ddfe616a",
          Username = "Sally",
          Password = "password",

          Claims = new List<Claim>
          {
            new Claim("given_name", "Sally"),
            new Claim("family_name", "Underwood"),
          }
        }
      };
    }


    public static IEnumerable<IdentityResource> GetIdentityResources()
    {
      return new List<IdentityResource>
      {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile()
      };
    }


    public static IEnumerable<Client> GetClients()
    {
      return new List<Client>();
    }


  } // End Class

} // End Namespace