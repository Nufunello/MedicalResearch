using MedicalResearch.Application.Models.Researches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Models.GroupResearches
{
    public class GroupReserachItemViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static GroupReserachItemViewModel AsViewModel(this GroupResearchDTO dto)
        {
            return new GroupReserachItemViewModel
            {
                Id = dto.Id,
                Description = dto.Description
            };
        }
    }
}
