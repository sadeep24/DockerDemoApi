using DockerDemoApi.Infrastructure.Repositories;
using DockerDemoApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerDemoApi.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _unitOfWork.ProductRepository.Get();
        }

        public Product GetProduct(int id)
        {
            return _unitOfWork.ProductRepository.GetByID(id);
        }
        public void InsertProduct(Product product)
        {
            _unitOfWork.ProductRepository.Insert(product);
            _unitOfWork.Save();
        }
    }
}
