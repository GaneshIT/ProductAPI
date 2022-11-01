using ProductEntity;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DAL.Repository
{
    public interface IColourRepo
    {
        void AddColour(Colour colour);

        void UpdateColour(Colour colour);

        void DeleteColour(int colourId);

        Colour GetColourById(int colourId);
        IEnumerable<Colour> GetColours();
    }
}
