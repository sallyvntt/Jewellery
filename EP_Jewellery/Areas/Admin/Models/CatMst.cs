using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class CatMst
    {
        [Key]
        [MaxLength(10)]
        public string Cat_ID { get; set; } // Khóa chính của bảng CatMst

        [Required]
        [MaxLength(50)]
        public string Cat_Name { get; set; } // Name Of Category

       
    }
}
