using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class ItemMst
    {
        [Key]
        [MaxLength(50)]
        public string Style_Code { get; set; } // Khóa chính của bảng ItemMst

        [ForeignKey("Brand")]
        [MaxLength(10)]
        public string Brand_ID { get; set; } // Khóa ngoại đến bảng BrandMst

        [Required]
        [MaxLength(50)]
        public string Prod_Quality { get; set; } // Quality Of Product

        [ForeignKey("Certify")]
        [MaxLength(10)]
        public string Certify_ID { get; set; } // Khóa ngoại đến bảng CertifyMst

        [ForeignKey("Prod")]
        [MaxLength(10)]
        public string Prod_ID { get; set; } // Khóa ngoại đến bảng ProdMst

        [ForeignKey("GoldKrt")]
        [MaxLength(10)]
        public string GoldType_ID { get; set; } // Khóa ngoại đến bảng GoldKrtMst

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Gold_Wt { get; set; } // Weight Of Gold

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Stone_Wt { get; set; } // Weight Of Stone

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Net_Gold { get; set; } // Net Gold

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Wstg_Per { get; set; } // Wastage In Percentage

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Wstg { get; set; } // Wastage

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Tot_Gross_Wt { get; set; } // Total Gross Weight

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Gold_Rate { get; set; } // Rate Of Gold

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Gold_Amt { get; set; } // Amount Of Gold In Item

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Gold_Making { get; set; } // Gold Making Charges

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Stone_Making { get; set; } // Stone Making Charges

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Other_Making { get; set; } // Other Making Charges

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Tot_Making { get; set; } // Total Making Charges

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal MRP { get; set; } // MRP Of Product (Including Stone Making, Gold Making And Other Making)

        // Khóa ngoại đến bảng BrandMst
        public BrandMst Brand { get; set; }

        // Khóa ngoại đến bảng CertifyMst
        public CertifyMst Certify { get; set; }

        // Khóa ngoại đến bảng ProdMst
        public ProdMst Prod { get; set; }

        // Khóa ngoại đến bảng GoldKrtMst
        public GoldKrtMst GoldKrt { get; set; }

        // Danh sách các đá quý có quan hệ với ItemMst nếu có
        public List<StoneMst> Stones { get; set; }
    }
}
