using System.Runtime.CompilerServices;
using Npgsql;

namespace AuthenticationTest.Data
{
    public class DAOFetcher : IDAOFetcher
    {
        private ICompanyDAO companyDao;
        private ILanguageDAO languageDao;

        public DAOFetcher(NpgsqlConnection conn)
        {
            this.companyDao = new CompanyDAO(conn);
            this.languageDao = new LanguageDAO(conn);
        }

        public ICompanyDAO CompanyDao()
        {
            return this.companyDao;
        }

        public ILanguageDAO LanguageDao()
        {
            return this.languageDao;
        }
    }
}