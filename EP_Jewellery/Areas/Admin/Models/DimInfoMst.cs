using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class DimInfoMst
    {
        [Key]
        [MaxLength(10)]
        public string DimID { get; set; } // Khóa chính của bảng DimInfoMst

        [Required]
        [MaxLength(50)]
        public string DimType { get; set; } // Type Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimSubType { get; set; } // Sub Type Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimCrt { get; set; } // Carat Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimPrice { get; set; } // Price Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimImg { get; set; } // Image Of Diamond

        // Một danh sách các kim cương có quan hệ với DimInfoMst nếu có
        public List<DimMst> DimDiamonds { get; set; }
    }
}
