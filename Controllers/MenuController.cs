using Airport_Food_Court_API.Models;
using Airport_Food_Court_API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Airport_Food_Court_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private readonly IMenuRepository menuRepository;

        public MenuController(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }

        [HttpGet]
        [Route("GetVendors")]
        public async Task<ActionResult> GetVendors()
        {
            try
            {
                return Ok(await menuRepository.GetVendors());
            }
            catch (Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("GetVendor/{vendorid}")]
        public async Task<ActionResult<AspNetUser>> GetVendor(string VendorId)
        {
            try
            {
                var result = await menuRepository.GetVendor(VendorId);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("GetMenu/{vendorid}")]
        public async Task<ActionResult<Menu>> GetMenu(string VendorId)
        {
            try
            {
                var result = await menuRepository.GetMenu(VendorId);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("GetMenuCategories/{menuid:int}")]
        public async Task<ActionResult<MenuCategory>> GetMenuCategories(int MenuId)
        {
            try
            {
                return Ok(await menuRepository.GetMenuCategories(MenuId));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("GetMenuItems/{menucategoryid:int}")]
        public async Task<ActionResult<MenuItem>> GetMenuItems(int MenuCategoryId)
        {
            try
            {
                return Ok(await menuRepository.GetMenuItems(MenuCategoryId));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("GetMenuItem/{menuitemid:int}")]
        public async Task<ActionResult<MenuItem>> GetMenuItem(int MenuItemId)
        {
            try
            {
                var result = await menuRepository.GetMenuItem(MenuItemId);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
    }
}
