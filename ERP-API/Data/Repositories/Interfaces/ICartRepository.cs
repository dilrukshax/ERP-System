using System.Collections.Generic;
using ERP_API.Entities;

namespace ERP_API.Data.Repositories.Interfaces
{
    public interface ICartRepository
    {
        IEnumerable<CartItems> GetAll();
        CartItems GetById(int cartId);
        void Add(CartItems cartItem);
        void Delete(int cartId);
        // Other repository methods as needed...
    }
}
