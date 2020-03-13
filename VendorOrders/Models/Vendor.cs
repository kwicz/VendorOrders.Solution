using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int Id { get; }
    public List<VendorOrders> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string address, string phone, string email)
    {
      Name = name;
      Address = address;
      Phone = phone;
      Email = email;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }
  }
}