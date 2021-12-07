using System.Collections.Generic;

namespace AuthenticationTest.Data.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string ImageBase64 { get; set; }
        public List<TourVariant> Variants { get; set; }
        public List<List<Sight>> Sights { get; set; } // We need to have lists of lists because we need to support multiple languages for each sight

        public Tour()
        {
            this.Variants = new List<TourVariant>();
            this.Sights = new List<List<Sight>>();
        }
    }
}