using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PS36400_NguyenLocThong_Lab3.Models
{
    [Table("Product")]
	public class Product
	{
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
