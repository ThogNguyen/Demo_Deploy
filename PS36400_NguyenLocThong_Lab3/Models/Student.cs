using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PS36400_NguyenLocThong_Lab3.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(18, 100, ErrorMessage = "Age must be in 18 and 100")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please choose gender")]
        public bool Gender { get; set; }
        [Required (ErrorMessage = "The value Date Of Birth is invalid")]
        [Column(TypeName = "datetime")]
        public DateTime DateofBirth { get; set; }
        [Required(ErrorMessage = "The value BatchTime is invalid")]
        [Column(TypeName = "datetime")]
        public DateTime BatchTime { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        [StringLength(15)]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please enter email")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please enter website url")]
        [StringLength(50)]
        [Url(ErrorMessage = "Invalid URL")]
        public string WebsiteUrl { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [MinLength(3, ErrorMessage = "Password must be more than 3 charracters")]
        [MaxLength(9, ErrorMessage = "Password must be less than 9 characters")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter confirm password")]
        [MinLength(3, ErrorMessage = "Password must be more than 3 charracters")]
        [MaxLength(9, ErrorMessage = "Password must be less than 9 characters")]
        [StringLength(50)]
        [Compare("Password", ErrorMessage = "The confirm password does not match password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }


}
