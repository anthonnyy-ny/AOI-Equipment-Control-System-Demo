namespace AOIEquipmentControlSystem.Models
{
    public class InspectionResult
    {
        public DateTime InspectionTime { get; set; } = DateTime.Now;
        public string ImageName { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public double Area { get; set; }
        public int Threshold { get; set; }
        public string Result { get; set; } = "N/A";
        public string ImagePath { get; set; } = string.Empty;
    }
}