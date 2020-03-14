using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class OrdersController: Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("orders", order);
      return View(model);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return RedirectToAction("Index");
    }

    // [HttpPost("/orders/delete/{orderId}")]
    // public ActionResult DeleteOne()
    // {
    //   int id = this.Id
    //   Order.ClearAll();
    //   return View();
    // }

  }
}