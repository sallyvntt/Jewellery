using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class GoldKrtMst
    {
        [Key]
        [MaxLength(10)]
        public string GoldType_ID { get; set; } // Khóa chính của bảng GoldKrtMst

        [Required]
        [MaxLength(50)]
        public string Gold_Crt { get; set; } // Carat Of Gold (18 Crt, 22 Crt, etc…)

     
    }
}
