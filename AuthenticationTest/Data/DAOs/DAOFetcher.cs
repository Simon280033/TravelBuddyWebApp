using System.Runtime.CompilerServices;
using Npgsql;

namespace AuthenticationTest.Data
{
    public class DAOFetcher : IDAOFetcher
    {
        private ICompanyDAO companyDao;
        
        public DAOFetcher(NpgsqlConnection conn)
        {
            this.companyDao = new CompanyDAO(conn);
        }

        public ICompanyDAO CompanyDao()
        {
            return this.companyDao;
        }
    }
}