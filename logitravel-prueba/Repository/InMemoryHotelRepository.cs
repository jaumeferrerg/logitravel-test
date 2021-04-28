using System.Collections.Generic;
using System.Linq;

namespace logitravel_test {
  internal class InMemoryHotelRepository : HotelRepository {
    private Dictionary<int, Hotel> hotels = new Dictionary<int, Hotel>() {
      {1, new Hotel() { Id=1, Name="Royal Tower", Zone="south" } },
      {2, new Hotel() { Id=2, Name="Emerald", Zone="north" } },
      {3, new Hotel() { Id=3, Name="Solar Resort", Zone="east" } },
      {4, new Hotel() { Id=4, Name="Paradise Sun", Zone="north" } },
      {5, new Hotel() { Id=5, Name="Seaside Hotel", Zone="south" } },
      {6, new Hotel() { Id=6, Name="Vanilla Hotel", Zone="west" } },
      {7, new Hotel() { Id=7, Name="Golden Nugget", Zone="west" } },
      {8, new Hotel() { Id=8, Name="Lion Resort", Zone="east" } },
      {9, new Hotel() { Id=9, Name="Crown Hotel", Zone="north" } },
      {10, new Hotel() { Id=10, Name="Salt Water Hotel", Zone="south" } },
      {11, new Hotel() { Id=11, Name="Coffee Hotel", Zone="east" } },
      {12, new Hotel() { Id=12, Name="Luna Hotel", Zone="west" } }
    };

    public override Hotel GetFromId(int id) {
      return hotels.GetValueOrDefault(id);
    }

    public override IEnumerable<Hotel> GetFromZone(string zone) {
      return hotels.Values.Where(h => h.Zone == zone);
    }
  }
}
