using System.ComponentModel.DataAnnotations;

namespace Exam2V1._0.Models
{

    //defining the Product object
    public class Product
    {

        public int ProductId { get; set; }

        //[Required(ErrorMessage = "")]
        
        [Required(ErrorMessage = "Please enter a Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid quantity.")]
        [Range(1, 99999, ErrorMessage = "Quantity cannot exceed 99,999.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please enter a valid price.")]
        [Range(1.00, 999999.99, ErrorMessage = "Quantity cannot exceed 999,999.99")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }
    }
}
