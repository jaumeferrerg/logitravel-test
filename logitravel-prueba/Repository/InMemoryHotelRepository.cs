using System.Collections.Generic;
using System.Linq;

namespace logitravel_test {
  internal class InMemoryHotelRepository : HotelRepository {
    private readonly Hotel[] hotels = new Hotel[] {
      new Hotel() { Id=1, Name="Royal Tower", Zone="south" },
      new Hotel() { Id=2, Name="Emerald", Zone="north" },
      new Hotel() { Id=3, Name="Solar Resort", Zone="east" },
      new Hotel() { Id=4, Name="Paradise Sun", Zone="north" },
      new Hotel() { Id=5, Name="Seaside Hotel", Zone="south" },
      new Hotel() { Id=6, Name="Vanilla Hotel", Zone="west" },
      new Hotel() { Id=7, Name="Golden Nugget", Zone="west" },
      new Hotel() { Id=8, Name="Lion Resort", Zone="east" },
      new Hotel() { Id=9, Name="Crown Hotel", Zone="north" },
      new Hotel() { Id=10, Name="Salt Water Hotel", Zone="south" },
      new Hotel() { Id=11, Name="Coffee Hotel", Zone="east" },
      new Hotel() { Id=11, Name="Luna Hotel", Zone="west" }
    };

    public override Hotel GetFromId(int Id) {
      return hotels.Where(h => h.Id == Id).FirstOrDefault();
    }

    public override IEnumerable<Hotel> GetFromZone(string zone) {
      return hotels.Where(h => h.Zone == zone);
    }
  }
}
