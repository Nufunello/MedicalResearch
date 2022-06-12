using MedicalResearch.Application.Models.Regions.Dto;

namespace MedicalResearch.Application.Models.Cities
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RegionListItemDto Region { get; set; }
    }
}
