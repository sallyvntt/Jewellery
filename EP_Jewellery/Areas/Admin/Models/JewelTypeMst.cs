using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class JewelTypeMst
    {
        [Key]
        [MaxLength(10)]
        public string ID { get; set; } // Khóa chính của bảng JewelTypeMst

        [Required]
        [MaxLength(50)]
        public string Jewellery_Type { get; set; } // Type Of Jewellery
    }
}
