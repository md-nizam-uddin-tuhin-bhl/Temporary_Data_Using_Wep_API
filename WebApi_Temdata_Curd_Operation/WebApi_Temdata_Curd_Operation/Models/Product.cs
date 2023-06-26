using System.ComponentModel.DataAnnotations;

namespace WebApi_Temdata_Curd_Operation.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        
        public string Descripsion { get; set; }
    }
}
