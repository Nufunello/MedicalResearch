using System.Collections.Generic;

namespace MedicalResearch.Domain.Researches
{
    public class GroupResearch
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Research> Researches { get; set; }
    }
}
