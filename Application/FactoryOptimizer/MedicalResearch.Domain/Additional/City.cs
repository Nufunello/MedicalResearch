namespace MedicalResearch.Domain.Additional
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int RegionID { get; set; }

        public Region Region { get; set; }
    }
}
