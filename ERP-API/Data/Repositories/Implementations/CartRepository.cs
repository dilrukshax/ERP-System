using System.Collections.Generic;
using System.Linq;
using ERP_API.Data.Context;
using ERP_API.Data.Repositories.Interfaces;
using ERP_API.Entities;

namespace ERP_API.Data.Repositories.Implementations
{
    public class CartRepository : ICartRepository
    {
        private readonly ERPDbContext _context;

        public CartRepository(ERPDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CartItems> GetAll()
        {
            return _context.CartItems.ToList();
        }

        public CartItems GetById(int cartId)
        {
            return _context.CartItems.Find(cartId);
        }

        public void Add(CartItems cartItem)
        {
            _context.CartItems.Add(cartItem);
            _context.SaveChanges();
        }

        public void Delete(int cartId)
        {
            var entity = _context.CartItems.Find(cartId);
            if (entity != null)
            {
                _context.CartItems.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
