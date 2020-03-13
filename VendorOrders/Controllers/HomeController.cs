using Microsoft.AspNetCore.Mvc;

namespace VendorOrders.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}