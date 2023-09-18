using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class DimQltySubMst
    {
        [Key]
        [MaxLength(10)]
        public string DimSubType_ID { get; set; } // Khóa chính của bảng DimQltySubMst

        [Required]
        [MaxLength(50)]
        public string DimQlty { get; set; } // Quality Of Diamond

        // Một danh sách các kim cương có quan hệ với DimQltySubMst nếu có
        public List<DimMst> DimDiamonds { get; set; }
    }
}
