namespace AuthenticationTest.Data
{
    public interface IDAOFetcher
    {
        public ICompanyDAO CompanyDao();
        
        public ILanguageDAO LanguageDao();

        public ITourDAO TourDao();
    }
}