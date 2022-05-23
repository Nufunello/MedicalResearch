namespace MedicalResearch.Application.Models.Researches.Dto
{
    public class ResearchListItemDto
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
}
