using MedicalResearch.Application.Models.Researches.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Models.Researches
{
    public class Research
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DeadlineInDays { get; set; }
        public decimal Cost { get; set; }
        public string PreparationDescription { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static Research AsViewModel(this ResearchDto dto)
        {
            return new Research
            {
                ID = dto.ID,
                Name = dto.Name,
                Description = dto.Description,
                DeadlineInDays = dto.DeadlineInDays,
                Cost = dto.Cost,
                PreparationDescription = dto.PreparationDescription,
                GroupID = dto.GroupID,
                GroupName = dto.GroupName
            };
        }
    }
}
