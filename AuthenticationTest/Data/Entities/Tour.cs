using System.Collections.Generic;

namespace AuthenticationTest.Data.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string ImageBase64 { get; set; }
        public List<TourVariant> Variants { get; set; }
        public List<Sight> Sights { get; set; }

        public Tour()
        {
            this.Variants = new List<TourVariant>();
            this.Sights = new List<Sight>();
        }
    }
}