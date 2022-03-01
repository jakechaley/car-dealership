using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {

    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    private static List<Car> _carList = new List<Car> {};
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _carList.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _carList;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}