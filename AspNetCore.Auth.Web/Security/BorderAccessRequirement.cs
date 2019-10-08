using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AspNetCore.Auth.Web.Security
{
    public class BorderAccessRequirement : IAuthorizationRequirement
    {
        public BorderAccessRequirement(string country)
        {
            Country = country;
        }

        public string Country { get; }
    }
}
