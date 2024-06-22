using PS36400_NguyenLocThong_Lab3.Models;

namespace PS36400_NguyenLocThong_Lab3.Repositories
{
	public class ProductService : IProductService
	{
		public List<Product> GetAllProducts()
		{
			return new List<Product>{
				new Product { ID = 1, Name = "san pham 1" },
				new Product { ID = 2, Name = "san pham 2" },
				new Product { ID = 3, Name = "san pham 3" },
				new Product { ID = 4, Name = "san pham 4" },
				new Product { ID = 5, Name = "san pham 5" }
			};
		}
	}
}
