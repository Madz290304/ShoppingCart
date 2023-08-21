using System.ComponentModel.DataAnnotations;

namespace WebStoreMadz.Models
{
    public class Brand
    {
        [Key]
        public int BId { get; set; }
        public string BName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
