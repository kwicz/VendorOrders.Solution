using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Order
  {
    public string Product { get; set; }
    public int Quantity { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};
    public static int IdCounter = 0;

    public Order(string product, int quantity)
    {
      Product = product;
      Quantity = quantity;
      _instances.Add(this);
      Id = IdCounter++;
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
      return _instances[searchId];
    }

    public static void ClearOne(int searchId)
    {
      for(int i = 0; i < _instances.Count; i++ )
      {
        if (_instances[i].Id == searchId)
        {
          _instances.Remove(_instances[i]);
          break;
        }
      }
    }
  }
}