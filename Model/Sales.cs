using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Model
{
    public class Sales
    {
        [Key]
        public int SalesId { get; set; }
        [Required]
        [ForeignKey(nameof(Sales))]
        public int CustomerId { get; set; }
        [Required]
        [ForeignKey(nameof(Sales))]
        public int ProductId { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
