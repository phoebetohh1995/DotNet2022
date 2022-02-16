using System.ComponentModel.DataAnnotations;

namespace ProductApplicationAssignment.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; } 
        public string Category { get; set; }
        
        [Range(1, 9999, ErrorMessage = "Invalid price")]
        public double Price     { get; set; }

        [Range(1, 20, ErrorMessage = "Quantity cannot exceed more than 20.")]
        public int Quantity { get; set; }

        [Display(Name = "Picture")]
        public string Pic { get; set; }


    }
}
