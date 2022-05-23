using MedicalResearch.Application.Models.Researches.Dto;

namespace MedicalResearch.Models.Researches
{
    public class ResearchListQuery
    {
        public int? GroupID { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static ResearchListQueryDto AsDto(this ResearchListQuery requestModel)
        {
            return new ResearchListQueryDto
            {
                GroupID = requestModel.GroupID,
                GroupName = requestModel.GroupName,
                Name = requestModel.Name
            };
        }
    }
}
