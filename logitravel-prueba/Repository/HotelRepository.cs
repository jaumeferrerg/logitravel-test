using System.Collections.Generic;

namespace logitravel_test {
  public abstract class HotelRepository {
    public abstract Hotel GetFromId(int Id);
    public abstract IEnumerable<Hotel> GetFromZone(string zone);
  }
}
