using Airport_Food_Court_API.Models;

namespace Airport_Food_Court_API.Data
{
    public interface IMenuRepository
    {
        Task<IEnumerable<AspNetUser>> GetVendors();
        Task<AspNetUser> GetVendor(string VendorId);
        Task<Menu> GetMenu(string VendorId);
        Task<IEnumerable<MenuCategory>> GetMenuCategories(int MenuId);
        Task<IEnumerable<MenuItem>> GetMenuItems(int MenuCategoryId);
        Task<MenuItem> GetMenuItem(int MenuItemId);
    }
}
