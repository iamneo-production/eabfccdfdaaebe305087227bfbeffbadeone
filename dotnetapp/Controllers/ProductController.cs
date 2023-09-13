using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
    private readonly IProductService productService;

    public ProductController(IProductService _productService)
    {
      this.productService = _productService;
    }

    public IQueryable<Product> GetAll()
    {
        return null;
    }

    public bool AddProduct(Product newProduct)
    {         
       if(newProduct==null){
        return false;
       }  
       var res=_productService.AddProduct(newProduct);
       return res;          
    }   

    public bool DeleteProduct (int id)
    {
   return false; 
    }
    }
}
