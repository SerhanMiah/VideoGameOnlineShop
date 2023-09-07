using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VideoGameAppBackend.Data;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Product;

namespace VideoGameAppBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishListController : ControllerBase
    {
        private readonly GameDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public WishListController(GameDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUserWishList()
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = await _userManager.Users.Include(u => u.WishLists)
                                .ThenInclude(wl => wl.WishlistItems)
                                .ThenInclude(wli => wli.Game)
                                .FirstOrDefaultAsync(u => u.Id == userId);

                if (user == null)
                {
                    return NotFound();
                }

                var wishlist = user.WishLists.FirstOrDefault();

                if (wishlist == null)
                {
                    return NotFound();
                }

                return Ok(wishlist);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteUserWishList()
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = await _userManager.Users.Include(u => u.WishLists)
                                .FirstOrDefaultAsync(u => u.Id == userId);

                if (user == null)
                {
                    return NotFound();
                }

                var wishlist = user.WishLists.FirstOrDefault();

                if (wishlist == null)
                {
                    return NotFound();
                }

                _context.WishlistItems.RemoveRange(wishlist.WishlistItems);
                _context.WishLists.Remove(wishlist);

                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
