using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService

    {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {

            if (product.ProductName.Length<2)
            {
                //magic string:
                //return new ErrorResult("Ürün ismi en az 2 karakterli olmalıdır");
                return new ErrorResult(Messages.ProductNameInvalid);
            }


             _productDal.Add(product);

            //return new Result(true, "Ürün eklendi");
            //return new SuccessResult("Ürün eklendi");
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //iş kodları
            //return _productDal.GetAll();

            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            //return new DataResult<List<Product>>(_productDal.GetAll(), true, "Ürünler listelendi");
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);


        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            //return _productDal.GetAll(p=>p.CategoryId==id);
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            //return _productDal.Get(p=> p.ProductId==productId);
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            //return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {

            //return _productDal.GetProductDetails();
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}

