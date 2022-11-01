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
    public class ColourRepo : IColourRepo
    {
        ProductDbContext _productDbContext;
        public ColourRepo(ProductDbContext producDbContext)
        {
            _productDbContext = producDbContext;
        }
        public void AddColour(Colour colour)
        {
            _productDbContext.colours.Add(colour);
            _productDbContext.SaveChanges();
        }
        public void DeleteColour(int colourId)
        {
            var colour = _productDbContext.colours.Find(colourId);
            _productDbContext.colours.Remove(colour);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<Colour> GetColours()
        {
            return _productDbContext.colours.ToList();
        }
        public void UpdateColour(Colour colour)
        {
            _productDbContext.Entry(colour).State = EntityState.Modified;
            _productDbContext.SaveChanges();
        }
        public Colour GetColourById(int colourId)
        {
            return _productDbContext.colours.Find(colourId);
        }
    }
}
