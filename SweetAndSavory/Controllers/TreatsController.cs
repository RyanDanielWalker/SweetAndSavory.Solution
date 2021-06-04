using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SweetAndSavory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetAndSavory.Controllers
{
  [Authorize]
  public class TreatsController : Controller
  {
    private readonly SweetAndSavoryContext _db;
    private readonly UserManager<User> _userManager;

    public TreatsController(UserManager<User> userManager, SweetAndSavoryContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    [AllowAnonymous]
    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
  }
}
