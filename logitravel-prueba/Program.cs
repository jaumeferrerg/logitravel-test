namespace logitravel_test {
  class Program {
    static void Main() {
      var userRepository = new InMemoryUserRepository();
      var hotelRepository = new InMemoryHotelRepository();

      var smsMessenger = new SmsMessenger();
      var emailMessenger = new EmailMessenger();

      var users = new User[] {
          new User("Juanma", smsMessenger, new int[] {1,2,3,4}, hotelRepository),
          new User("Alberto", smsMessenger, new int[] {1,3,5,7}, hotelRepository),
          new User("Emma", emailMessenger, new int[] {2,4,6,8}, hotelRepository),
          new User("Maria", emailMessenger, new int[] {1,3,4,7,8}, hotelRepository)
      };

      foreach (var user in users) {
        userRepository.Insert(user);
      }

      var s = new PromotionSender(userRepository, hotelRepository);
      s.SendPromotionToEveryone();
    }
  }
}
