using Microsoft.AspNetCore.Mvc;
using ERP_API.Entities;
using ERP_API.Services.Interfaces;
using System.Collections.Generic;

namespace ERP_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CartItems>> GetAll()
        {
            return Ok(_cartService.GetAllCartItems());
        }

        [HttpGet("{id}")]
        public ActionResult<CartItems> GetById(int id)
        {
            var cartItem = _cartService.GetCartItemById(id);
            if (cartItem == null) return NotFound();
            return Ok(cartItem);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CartItems cartItem)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _cartService.AddCartItem(cartItem);
            return CreatedAtAction(nameof(GetById), new { id = cartItem.CartId }, cartItem);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _cartService.RemoveCartItem(id);
            return NoContent();
        }
    }
}
