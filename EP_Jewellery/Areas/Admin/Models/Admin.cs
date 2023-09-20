using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EP_Jewellery.Models
{
    [Table("AdminLoginMst")]

    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please enter the ID")]
        public string username { get; set; }
        [Required(ErrorMessage = "Please enter the Passoword")]
        public string password { get; set; }
        public int id { get; set; }
        public string name { get; set; }

    }
}

