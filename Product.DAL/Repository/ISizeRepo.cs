using ProductEntity;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Product.DAL.Repository
{
    public interface ISizeRepo
    {
        void AddSize(SizeScale size);

        void UpdateSize(SizeScale size);

        void DeleteSize(int sizeId);

        SizeScale GetSizeById(int sizeId);
        IEnumerable<SizeScale> GetSizes();
    }
}
