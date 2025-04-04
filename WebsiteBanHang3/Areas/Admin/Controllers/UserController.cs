//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using WebsiteBanHang3.Models;

//namespace WebsiteBanHang3.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    [Authorize(Roles = SD.Role_Admin)]
//    public class UserController : Controller
//    {
//        public IActionResult Index()
//        {

//            return View();
//        }
//    }
//}

using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang3.Models;

public class UserController : Controller
{
    private readonly ApplicationDbContext _context;

    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var users = _context.Users.ToList(); // Lấy danh sách người dùng từ database
        return View(users);
    }
}
