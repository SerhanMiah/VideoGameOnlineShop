using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using VideoGameAppBackend.Data;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Payments;

namespace VideoGameAppBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly GameDbContext _context;

        public CartController(GameDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AddToCart")]
        public async Task<IActionResult> AddToCart([FromBody] CartItemRequest request)
        {
            var cart = await _context.Carts.Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserId == request.UserId);

            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = request.UserId
                };

                _context.Carts.Add(cart);
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.GameId == request.GameId);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    GameId = request.GameId,
                    Quantity = request.Quantity
                };

                cart.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += request.Quantity;
            }

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("GetCartItems")]
        public async Task<IActionResult> GetCartItems(string userId)
        {
            var cartItems = await _context.Carts
                .Where(c => c.UserId == userId)
                .SelectMany(c => c.CartItems)
                .Include(ci => ci.Game)
                .ToListAsync();

            return Ok(cartItems);
        }

        [HttpDelete]
        [Route("RemoveFromCart/{cartItemId}")]
        public async Task<IActionResult> RemoveFromCart(int cartItemId)
        {
            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.Id == cartItemId);

            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return NotFound("Cart item not found.");
        }

        [HttpPut]
        [Route("UpdateQuantity")]
        public async Task<IActionResult> UpdateQuantity([FromBody] CartItemUpdateRequest request)
        {
            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.Id == request.CartItemId);

            if (cartItem != null)
            {
                cartItem.Quantity = request.NewQuantity;
                await _context.SaveChangesAsync();
                return Ok();
            }

            return NotFound("Cart item not found.");
        }
    }
}
