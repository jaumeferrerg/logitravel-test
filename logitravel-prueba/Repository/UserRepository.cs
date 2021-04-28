using System.Collections.Generic;

namespace logitravel_test {
  abstract class UserRepository {
    public abstract IEnumerable<User> GetAll();
    public abstract void Insert(User user);
  }
}
