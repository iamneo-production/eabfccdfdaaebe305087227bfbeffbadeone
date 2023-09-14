using dotnetapp.Models;
using System.Linq;

namespace dotnetapp.Models
{
    public interface IProductService
    {
        public IQueryable<Product> GetProductList();
        public bool AddProduct(Product product);
        public bool DeleteProduct(int Id);
    }
    //Fill ur code
    public class ProductService : IProductService
    {
       private readonly ProductDBContext _dbContext;

        public ProductService(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Product> GetProductList()
        {
            IQueryable<Product> product=_dbContext.ToList();
            return product;
        }
        public bool AddProduct(Product product)
        {
            if(product==null){
            return false;
            }
            else{
                _dbContext.Add(product);
                _dbContext.SaveChanges();
                
            }
            return true;
        }

        public bool DeleteProduct(int Id)
        {
            return false;
        }
    }
}