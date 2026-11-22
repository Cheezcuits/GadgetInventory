using System.ComponentModel.DataAnnotations;

namespace GadgetInventory.Models
{
    public class Gadget
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Brand is required.")]
        [StringLength(100)]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model name is required.")]
        [Display(Name = "Model Name")]
        [StringLength(50)]
        public string ModelName { get; set; }

        [Range(1,5000, ErrorMessage = "Price must be between $1 and $5000.")]
        public decimal Price { get; set; }

    }
}