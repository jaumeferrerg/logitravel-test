using System;

namespace logitravel_prueba {
  class Program {
    static void Main(string[] args) {
      PromotionSender s = new PromotionSender(new InMemoryUserRepository());
      s.SendPromotionToEveryone();
    }
  }
}
