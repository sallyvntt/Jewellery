using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EP_Jewellery.Models
{
    [Table("UserRegMst")]
    public class User
    {        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public string userId { get; set; }
            //[Required(ErrorMessage ="Please enter the ID")]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }
            public string? userFName { get; set; }
            public string? userLName { get; set; }
            public string? address { get; set; }
            public string? city { get; set; }
            public string? state { get; set; }
            public int? mobNo { get; set; }
            public string? emailID { get; set; }
            public DateTime dob { get; set; }
            public DateTime cdate { get; set; }
            //[Required(ErrorMessage = "Please enter the Password")]

            public string? password { get; set; }
        
    }
}
