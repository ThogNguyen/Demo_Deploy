using Microsoft.EntityFrameworkCore;

namespace PS36400_NguyenLocThong_Lab3.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
