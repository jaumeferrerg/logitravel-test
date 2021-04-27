using System.Collections.Generic;

namespace logitravel_prueba {
  abstract class UserRepository {
    public abstract IEnumerable<User> GetAll();
  }
}