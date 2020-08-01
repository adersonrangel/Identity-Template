using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using IdentityModel;

namespace IdentityTest.Data.Model
{
	public class AdditionalUserClaimsPrincipalFactory
        : UserClaimsPrincipalFactory<CustomIdentity, IdentityRole<Guid>>
    {
        public AdditionalUserClaimsPrincipalFactory(
            UserManager<CustomIdentity> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, roleManager, optionsAccessor)
        { }

        public async override Task<ClaimsPrincipal> CreateAsync(CustomIdentity user)
        {
            var principal = await base.CreateAsync(user);
            var identity = (ClaimsIdentity)principal.Identity;

            var claims = new List<Claim>();
            if (user.IsAdmin)
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "admin"));
            }
            else
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "user"));
            }

            identity.AddClaims(claims);
            return principal;
        }
    }
}
