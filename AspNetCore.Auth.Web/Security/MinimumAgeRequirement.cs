using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspNetCore.Auth.Web.Security
{
    public class MinimumAgeRequirement : AuthorizationHandler<MinimumAgeRequirement>, IAuthorizationRequirement
    {
        private int _minimumAge;

        public MinimumAgeRequirement(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            var dobValue = context.User.FindFirstValue(ClaimTypes.DateOfBirth);
            var dob = DateTime.Parse(dobValue);
            if (dob.Date < DateTime.Now.Date.AddYears(-_minimumAge))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}