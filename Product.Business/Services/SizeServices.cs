using Product.DAL.Repository;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Bussiness.Services
{
    public class SizeScaleServices
    {
        ISizeRepo _sizeRepo;
        public SizeScaleServices(ISizeRepo sizeRepository)
        {
            _sizeRepo = sizeRepository;
        }
        public void AddSize(SizeScale size)
        {
            _sizeRepo.AddSize(size);
        }
        public void UpdateSize(SizeScale size)
        {
            _sizeRepo.UpdateSize(size);
        }
        public void DeleteSize(int sizeId)
        {
            _sizeRepo.DeleteSize(sizeId);
        }

        public IEnumerable<SizeScale> GetSizes()
        {
            return _sizeRepo.GetSizes();
        }
        public SizeScale GetSizeByid(int sizeId)
        {
            return _sizeRepo.GetSizeById(sizeId);
        }
    }
}
