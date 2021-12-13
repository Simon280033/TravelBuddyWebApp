using System.Collections.Generic;
using AuthenticationTest.Data.Entities;

namespace AuthenticationTest.Data
{
    public interface ICompanyDAO
    {
        public Company getCompanyForUserById(string id);

        public bool userTiedToCompany(string userName);

        public List<string> getCustomers();
    }
}