namespace MedicalResearch.Application.Models.Researches.Dto
{
    public class ResearchCreateUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DeadlineInDays { get; set; }
        public decimal Cost { get; set; }
        public string PreparationDescription { get; set; }
        public int GroupResearchID { get; set; }
    }
}
