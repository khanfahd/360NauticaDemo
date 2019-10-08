using Microsoft.AspNetCore.Authorization;
using AspNetCore.Auth.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Auth.Web.Security
{
    public class CitizenHandler : AuthorizationHandler<BorderAccessRequirement>
    {
        private IPassportService _passports;

        public CitizenHandler(IPassportService passports)
        {
            _passports = passports;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, BorderAccessRequirement requirement)
        {
            var passport = await _passports.GetPassportForUserAsync(context.User.Identity.Name);
            if (passport.IssuingCountry == requirement.Country)
            {
                context.Succeed(requirement);
            }
        }
    }
}
