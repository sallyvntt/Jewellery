using System.ComponentModel.DataAnnotations;

namespace EP_Jewellery.Models
{
    public class StoneQltyMst
    {
        [System.ComponentModel.DataAnnotations.Key]
        [MaxLength(10)]
        public string StoneQlty_ID { get; set; } // Khóa chính của bảng StoneQltyMst

        [Required]
        [MaxLength(50)]
        public string StoneQlty { get; set; } // Quality Of Stone (Ruby, Meena, etc…)

     
    }
}
