using Airport_Food_Court_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Airport_Food_Court_API.Data
{
    public class MenuRepository : IMenuRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public MenuRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<AspNetUser>> GetVendors()
        {
            return await _dbContext.AspNetUsers.ToListAsync();
        }

        public async Task<AspNetUser> GetVendor(string VendorId)
        {
            return await _dbContext.AspNetUsers.FirstOrDefaultAsync(x => x.Id == VendorId);
        }

        public async Task<Menu> GetMenu(string VendorId)
        {
            return await _dbContext.Menus.FirstOrDefaultAsync(x => x.UserId == VendorId);
        }

        public async Task<IEnumerable<MenuCategory>> GetMenuCategories(int MenuId)
        {
            return await _dbContext.MenuCategories.Where(x => x.MenuId == MenuId).ToListAsync();
        }

        public async Task<IEnumerable<MenuItem>> GetMenuItems(int MenuCategoryId)
        {
            return await _dbContext.MenuItems.Where(x => x.MenuCategoryId == MenuCategoryId).ToListAsync();
        }

        public async Task<MenuItem> GetMenuItem(int MenuItemId)
        {
            return await _dbContext.MenuItems.FirstOrDefaultAsync(x => x.Id == MenuItemId);
        }

        
    }
}
