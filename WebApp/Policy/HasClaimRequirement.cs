using System;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Policy
{
    public class HasClaimRequirement : IAuthorizationRequirement
    {
        public string UserClaims { get; set; }
        public HasClaimRequirement(string userClaims)
        {
            UserClaims = userClaims?? throw new ArgumentNullException(nameof(userClaims));
        }
    }
}
