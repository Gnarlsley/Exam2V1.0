using System.ComponentModel.DataAnnotations;

namespace Exam2V1._0.Models
{

    //defining the Product object
    public class Product
    {

        public int ProductID { get; set; }

        //[Required(ErrorMessage = "")]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }
    }
}
