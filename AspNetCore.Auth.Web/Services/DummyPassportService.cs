using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Auth.Web.Services
{
    public class DummyPassportService : IPassportService
    {
        private readonly IDictionary<string, Passport> _passports;

        public DummyPassportService(IDictionary<string, Passport> passports)
        {
            _passports = passports;
        }

        public Task<Passport> GetPassportForUserAsync(string username)
        {
            if (_passports.ContainsKey(username))
            {
                return Task.FromResult(_passports[username]);
            }
            return Task.FromResult<Passport>(null);
        }
    }
}
