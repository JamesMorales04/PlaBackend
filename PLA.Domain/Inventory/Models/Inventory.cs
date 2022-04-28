namespace PLA.Domain.Inventory.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Inventory
    {
        [Key]
        public Guid InvetoryId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public string Warehouse { get; set; }
    }
}