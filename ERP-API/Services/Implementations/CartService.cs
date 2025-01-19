using System.Collections.Generic;
using ERP_API.Entities;
using ERP_API.Services.Interfaces;
using ERP_API.Data.Repositories.Interfaces;

namespace ERP_API.Services.Implementations
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public IEnumerable<CartItems> GetAllCartItems()
        {
            return _cartRepository.GetAll();
        }

        public CartItems GetCartItemById(int cartId)
        {
            return _cartRepository.GetById(cartId);
        }

        public void AddCartItem(CartItems cartItem)
        {
            _cartRepository.Add(cartItem);
        }

        public void RemoveCartItem(int cartId)
        {
            _cartRepository.Delete(cartId);
        }
    }
}
