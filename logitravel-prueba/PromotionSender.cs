using System;
using System.Linq;

namespace logitravel_test {
  class PromotionSender {
    private UserRepository userRepository;
    private HotelRepository hotelRepository;

    public PromotionSender(UserRepository userRepository, HotelRepository hotelRepository) {
      this.userRepository = userRepository;
      this.hotelRepository = hotelRepository;
    }

    public void SendPromotionToEveryone() {
      var users = userRepository.GetAll();
      foreach (var user in users) {
        SendPromotionTo(user);
      }
    }

    public void SendPromotionTo(User user) {
      var promotedHotel = GetPromotedHotel(user);
      if (promotedHotel != null)
        user.SendMessage($"Promotion of {promotedHotel.Name}");
    }

    private Hotel GetPromotedHotel(User user) {
      var bookedHotels = user.BookedHotels();

      if (bookedHotels.Count() == 0) {
        return null;
      }

      var bookedZones = bookedHotels.Select(h => h.Zone);
      var mostBookedZone = bookedZones
        .GroupBy(z => z)
        .OrderByDescending(g => g.Count())
        .Select(g => g.Key)
        .First();
      
      var candidates = hotelRepository
        .GetFromZone(mostBookedZone)
        .Where(hotel => !bookedHotels.Contains(hotel));

      if (candidates.Count() == 0) {
        return null;
      }

      var r = new Random();
      int idx = r.Next(candidates.Count());
      return candidates.ElementAt(idx);
    }
  }
}
