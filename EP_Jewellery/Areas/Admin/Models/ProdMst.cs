using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class ProdMst
    {
        [System.ComponentModel.DataAnnotations.Key]
        [MaxLength(10)]
        public string Prod_ID { get; set; } // Khóa chính của bảng ProdMst

        [Required]
        [MaxLength(50)]
        public string Prod_Type { get; set; } // Type Of Product

       
    }
}
