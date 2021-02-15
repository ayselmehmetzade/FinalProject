using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //List<Product> GetAll();
        //List<Product> GetAllByCategoryId(int id);
        //List<Product> GetByUnitPrice(decimal min, decimal max);
        //List<ProductDetailDto> GetProductDetails();
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        //void Add(Product product);
        IResult Add(Product product);

        //Product GetById(int productId);
        IDataResult<Product> GetById(int productId);
    }
}

