using MedicalResearch.Application.Models.Researches.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalResearch.Application.Models.Researches
{
    public class GroupResearchDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<ResearchDTO> ResearchDTOs { get; set; }
    }
}
