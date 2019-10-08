using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Auth.Web.Services
{
    public interface IPassportService
    {
        Task<Passport> GetPassportForUserAsync(string username);
    }

    public class Passport
    {
        public Passport(string number, string expiryDate, string issuingCountry)
        {
            Number = number;
            ExpiryDate = DateTime.Parse(expiryDate);
            IssuingCountry = issuingCountry;
        }

        public string Number { get; }
        public DateTime ExpiryDate { get; }
        public string IssuingCountry { get; }
    }
}
