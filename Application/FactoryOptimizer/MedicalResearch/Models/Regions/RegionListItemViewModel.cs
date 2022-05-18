using MedicalResearch.Application.Models.Regions.Dto;

namespace MedicalResearch.Models.Regions
{
    public class RegionListItemViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static RegionListItemViewModel AsViewModel(this RegionListItemDto dto)
        {
            return new RegionListItemViewModel
            {
                ID = dto.ID,
                Name = dto.Name
            };
        }
    }
}
