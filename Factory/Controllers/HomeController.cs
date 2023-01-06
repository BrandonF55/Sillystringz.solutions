using Dr-Sillystring-Factory.Models;

namespace Dr-Sillystring-Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly Dr-Sillystring-Factory _db;

      public HomeController(DoctorsOfficeContext db)
      {
        _db = db;
      }