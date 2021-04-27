using System.Collections.Generic;

namespace logitravel_prueba {
  internal class InMemoryUserRepository : UserRepository {
    public override IEnumerable<User> GetAll() {
      return new List<User>();
    }
  }
}