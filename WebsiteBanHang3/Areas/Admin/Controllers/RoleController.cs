using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang3.Models;

namespace WebsiteBanHang3.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    public class RoleController : Controller
    {
        ApplicationDbContext db;
        public RoleController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<IdentityRole> list = db.Roles.ToList();
            return View(list);
        }
    }
}
