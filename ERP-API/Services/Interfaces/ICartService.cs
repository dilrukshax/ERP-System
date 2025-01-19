using System.Collections.Generic;
using ERP_API.Entities;

namespace ERP_API.Services.Interfaces
{
    public interface ICartService
    {
        IEnumerable<CartItems> GetAllCartItems();
        CartItems GetCartItemById(int cartId);
        void AddCartItem(CartItems cartItem);
        void RemoveCartItem(int cartId);
    }
}
