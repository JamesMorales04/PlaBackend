namespace PLA.Domain.Crop.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Crop
    {
        [Key]
        public Guid CropId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid PlotId { get; set; }

        [Required]
        public CropStatus Status { get; set; }
    }
}