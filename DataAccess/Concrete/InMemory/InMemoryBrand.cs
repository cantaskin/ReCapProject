using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrand : IBrandDal
    {
        private List<Brand> _brands;

        public InMemoryBrand()
        {
            _brands = new List<Brand>
                {
                    new Brand { BrandId = 0, BrandName = "BMW" },
                    new Brand { BrandId = 1, BrandName = "Mercedes" }
                };
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = null;
            brandToDelete = _brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
            if (brandToDelete != null)
                _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int id)
        {
            return _brands.SingleOrDefault(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = null;
            brandToUpdate = _brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
            if (brandToUpdate != null)
                brandToUpdate = brand;
        }
    }
}
