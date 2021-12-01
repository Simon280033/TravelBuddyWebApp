using System.Collections.Generic;

namespace AuthenticationTest.Data
{
    public interface ICompanyDAO
    {
        public void getCompanyById(int id);

        public bool userTiedToCompany(string userName);

        public List<string> getCustomers();
    }
}