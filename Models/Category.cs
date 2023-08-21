using System.ComponentModel.DataAnnotations;

namespace WebStoreMadz.Models
{
    public class Category
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
