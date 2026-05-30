namespace AOIEquipmentControlSystem.Models
{
    public class Recipe
    {
        public string ProductName { get; set; } = "Lens_Module_A";
        public int ExposureTime { get; set; } = 120;
        public int Threshold { get; set; } = 85;
        public int MinArea { get; set; } = 5000;
        public int RoiX { get; set; } = 100;
        public int RoiY { get; set; } = 100;
        public int RoiWidth { get; set; } = 300;
        public int RoiHeight { get; set; } = 300;
        public string SavePath { get; set; } = "Results";
        public int MaxRetryCount { get; set; } = 3;
    }
}