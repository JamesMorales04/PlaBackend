namespace PLA.Domain.Plots.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Plot
    {
        [Key]
        public Guid PlotId { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string CropSuitability { get; set; }

        [Required]
        public PlotStatus Status { get; set; }
    }
}