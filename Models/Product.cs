using System.ComponentModel.DataAnnotations;

namespace WebStoreMadz.Models
{
    public class Product
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public int PPrice { get; set; }
        public string PDesc { get; set; }

        //Foreign Key

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string BrandId { get; set; }
        public Brand Brand { get; set;}

        public string ImagePath { get; set; }
    }
}
