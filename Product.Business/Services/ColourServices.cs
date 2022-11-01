using Product.DAL.Repository;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Bussiness.Services
{
    public class ColourServices
    {
        IColourRepo _colourRepo;
        public ColourServices(IColourRepo colourRepository)
        {
            _colourRepo = colourRepository;
        }
        public void AddColour(Colour colour)
        {
            _colourRepo.AddColour(colour);
        }
        public void UpdateColour(Colour colour)
        {
            _colourRepo.UpdateColour(colour);
        }
        public void DeleteColour(int colourId)
        {
            _colourRepo.DeleteColour(colourId);
        }

        public IEnumerable<Colour> GetColours()
        {
            return _colourRepo.GetColours();
        }
        public Colour GetColourByid(int colourId)
        {
            return _colourRepo.GetColourById(colourId);
        }
    }
}
