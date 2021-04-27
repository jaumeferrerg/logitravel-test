namespace logitravel_prueba {
  class PromotionSender {
    private UserRepository userRepository;

    public PromotionSender(UserRepository userRepository) {
      this.userRepository = userRepository;
    }

    public void SendPromotionToEveryone() {
      var users = userRepository.GetAll();
      foreach (var user in users) {

      }
    }
  }
}
