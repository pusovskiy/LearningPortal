using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "User name should content 3-20 chars")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Password should content 6-15 chars")]
        public string Password { get; set; }


    }
}
