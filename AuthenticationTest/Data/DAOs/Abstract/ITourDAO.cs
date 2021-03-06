using System.Collections.Generic;
using AuthenticationTest.Data.Entities;

namespace AuthenticationTest.Data
{
    public interface ITourDAO
    {
        public void createTour(Tour tour);

        public void updateTour(Tour tour);
        
        public List<Tour> getToursForCompany(int companyId);

        public Tour getTourById(int tourId);
    }
}