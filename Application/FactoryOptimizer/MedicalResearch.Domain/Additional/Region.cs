using System.Collections.Generic;

namespace MedicalResearch.Domain.Additional
{
    public class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<City> Cities { get; set; }
    }
}
