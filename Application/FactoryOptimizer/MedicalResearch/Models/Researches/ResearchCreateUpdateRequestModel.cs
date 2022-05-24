using MedicalResearch.Application.Models.Researches.Dto;
using System.ComponentModel.DataAnnotations;

namespace MedicalResearch.Models.Researches
{
    public class ResearchCreateUpdateRequestModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int DeadlineInDays { get; set; }
        [Required]
        public decimal Cost { get; set; }
        public string PreparationDescription { get; set; }
        [Required]
        public int GroupResearchID { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static ResearchCreateUpdateDto AsDto(this ResearchCreateUpdateRequestModel requestModel)
        {
            return new ResearchCreateUpdateDto
            {
                Name = requestModel.Name,
                Description = requestModel.Description,
                DeadlineInDays = requestModel.DeadlineInDays,
                Cost = requestModel.Cost,
                PreparationDescription = requestModel.PreparationDescription,
                GroupResearchID = requestModel.GroupResearchID
            };
        }
    }

}
