using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class DimQltyMst
    {
        [System.ComponentModel.DataAnnotations.Key]
        [MaxLength(10)]
        public string DimQlty_ID { get; set; } // Khóa chính của bảng DimQltyMst

        [Required]
        [MaxLength(50)]
        public string DimQlty { get; set; } // Quality Of Diamond (AD, FD, VVS, etc…)

        // Một danh sách các kim cương có quan hệ với DimQltyMst nếu có
        public List<DimMst> DimDiamonds { get; set; }
    }
}
