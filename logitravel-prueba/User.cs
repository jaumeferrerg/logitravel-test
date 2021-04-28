using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace logitravel_test {
  public class User : IEquatable<User> {
    string Id { get { return Name; } }
    string Name { get; }
    Messenger messenger;
    private List<int> bookedHotelIds;
    private HotelRepository hotelRepository;

   public User(string name, Messenger messenger, int[] bookedHotelIds, HotelRepository hotelRepository) {
      Name = name;
      this.messenger = messenger;
      this.bookedHotelIds = bookedHotelIds.ToList();
      this.hotelRepository = hotelRepository;
    }

    public void SendMessage(string msg) {
      messenger.Send(new Message {
        Receiver = Name,
        Content = msg
      });
    }

    public IEnumerable<Hotel> BookedHotels() {
      return bookedHotelIds.Select(id => hotelRepository.GetFromId(id));
    }

    public bool Equals([AllowNull] User other) {
      return other != null && Id == other.Id;
    }
  }
}
