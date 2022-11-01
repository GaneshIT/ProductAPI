using Microsoft.EntityFrameworkCore;
using Product.DAL.Data;
using ProductEntity;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product.DAL.Repository
{
    public class SizeRepo:ISizeRepo
    {
        ProductDbContext _productDbContext;
        public SizeRepo(ProductDbContext producDbContext)
        {
            _productDbContext = producDbContext;
        }
        public void AddSize(SizeScale size)
        {
            _productDbContext.SizeScales.Add(size);
            _productDbContext.SaveChanges();
        }
        public void DeleteSize(int sizeId)
        {
            var size = _productDbContext.SizeScales.Find(sizeId);
            _productDbContext.SizeScales.Remove(size);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<SizeScale> GetSizes()
        {
            return _productDbContext.SizeScales.ToList();
        }
        public void UpdateSize(SizeScale size)
        {
            _productDbContext.Entry(size).State = EntityState.Modified;
            _productDbContext.SaveChanges();
        }
        public SizeScale GetSizeById(int sizeId)
        {
            return _productDbContext.SizeScales.Find(sizeId);
        }
    }
}
