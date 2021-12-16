using AuthenticationTest.Data.Entities;

namespace AuthenticationTest.Data
{
    public interface ISightDAO
    {
        public int CreateNewSightAndVariant(Sight sight, int tourId, string languageCode);

        public void CreateOrUpdateVariant(Sight sight, int tourId, string languageCode);
    }
}