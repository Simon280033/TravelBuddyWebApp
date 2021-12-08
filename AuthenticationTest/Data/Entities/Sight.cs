using System.Collections.Generic;
using System.Drawing.Imaging;
namespace AuthenticationTest.Data.Entities
{
    public class Sight
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RadiusInMeters { get; set; }
        public string ImageBase64 { get; set; }
        public List<SightVariant> Variants { get; set; }

        public Sight()
        {
            this.Variants = new List<SightVariant>();
            this.Variants.Add(new SightVariant());
        }
    }
}