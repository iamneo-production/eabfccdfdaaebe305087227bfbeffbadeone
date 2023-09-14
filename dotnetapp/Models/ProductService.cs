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
            IQueryable<Product> product=_dbContext.Products.ToList().AsQueryable();
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
            var product= _dbContext.Products.Find(Id);
            if(product==null){
                return false;
            }
            _dbContext.Remove(product);
            _dbContext.SaveChanges();
            return false;
        }
    }
}