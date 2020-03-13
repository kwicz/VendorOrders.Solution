using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Order
  {
    public string Product { get; set; }
    public int Quantity { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string product, int quantity)
    {
      Product = product;
      Quantity = quantity;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}