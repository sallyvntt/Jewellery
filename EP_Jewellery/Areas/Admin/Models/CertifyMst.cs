using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class CertifyMst
    {
        [Key]
        [MaxLength(10)]
        public string Certify_ID { get; set; } // Khóa chính của bảng CertifyMst

        [Required]
        [MaxLength(50)]
        public string Certify_Type { get; set; } // Name Of Certification (918, 920, etc…)

       
    }
}
