using System.Collections.Generic;

namespace AuthenticationTest.Data.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<List<Sight>> Sights { get; set; } // We need to have lists of lists because we need to support multiple languages for each sight
    }
}