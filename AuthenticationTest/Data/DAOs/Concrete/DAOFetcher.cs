using System.Runtime.CompilerServices;
using Npgsql;

namespace AuthenticationTest.Data
{
    public class DAOFetcher : IDAOFetcher
    {
        private ICompanyDAO companyDao;
        private ILanguageDAO languageDao;
        private ITourDAO tourDao;

        public DAOFetcher(NpgsqlConnection conn)
        {
            this.companyDao = new CompanyDAO(conn);
            this.languageDao = new LanguageDAO(conn);
            this.tourDao = new TourDAO(conn);
        }

        public ICompanyDAO CompanyDao()
        {
            return this.companyDao;
        }

        public ILanguageDAO LanguageDao()
        {
            return this.languageDao;
        }

        public ITourDAO TourDao()
        {
            return this.tourDao;
        }
    }
}