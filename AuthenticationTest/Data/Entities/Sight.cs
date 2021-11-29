using System.Drawing.Imaging;
namespace AuthenticationTest.Data.Entities
{
    public class Sight
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RadiusInMeters { get; set; }
        public string Image { get; set; }
        public string Audio { get; set; }
        public Language Language { get; set; }
    }
}