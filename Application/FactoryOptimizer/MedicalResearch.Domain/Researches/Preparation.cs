using System.Collections.Generic;

namespace MedicalResearch.Domain.Researches
{
    public class Preparation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Research> Researches { get; set; }
    }
}
