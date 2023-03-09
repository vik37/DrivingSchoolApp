using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using Duende.IdentityServer.Extensions;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;
using Duende.IdentityServer.Validation;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DrivingSchoolApp.RegisterMVC.Services
{
    public class ProfileServices : IProfileService
    {
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipalFactory;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public ProfileServices(IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory,
                                UserManager<ApplicationUser> userManager,
                                RoleManager<IdentityRole> roleManager)
        {
            _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            string sub = context.Subject.GetSubjectId();
            ApplicationUser user = await _userManager.FindByIdAsync(sub);
            ClaimsPrincipal userClaims = await _userClaimsPrincipalFactory.CreateAsync(user);
            List<Claim> claims = userClaims.Claims.ToList();
            claims = claims.Where(c => context.RequestedClaimTypes.Contains(c.Type)).ToList();
            claims.Add(new Claim(JwtClaimTypes.GivenName,user.Firstname));
            claims.Add(new Claim(JwtClaimTypes.FamilyName,user.Lastname));
            claims.Add(new Claim(JwtClaimTypes.Email,user.Email));
            claims.Add(new Claim(JwtClaimTypes.PhoneNumber,user.PhoneNumber));
            new Claim(JwtClaimTypes.Address, user.Address);
            
            if (_userManager.SupportsUserRole)
            {
                IList<string> roles = await _userManager.GetRolesAsync(user);
                foreach (var role in roles)
                {
                    claims.Add(new Claim(JwtClaimTypes.Role, role));
                    if(_roleManager.SupportsRoleClaims)
                    {
                        IdentityRole identityRole = await _roleManager.FindByNameAsync(role);
                        if (role != null)
                            claims.AddRange(await _roleManager.GetClaimsAsync(identityRole));

                        
                    }
                }
            }
            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            string sub = context.Subject.GetSubjectId();
            ApplicationUser user = await _userManager.FindByIdAsync(sub);
            context.IsActive = user != null;
        }
    }
}
