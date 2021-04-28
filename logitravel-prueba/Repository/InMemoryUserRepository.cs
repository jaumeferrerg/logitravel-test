using System.Collections.Generic;

namespace logitravel_test {
  internal class InMemoryUserRepository : UserRepository {
    private List<User> users;

    public InMemoryUserRepository() {
      users = new List<User>();
    }

    public override IEnumerable<User> GetAll() {
      return users;
    }

    public override void Insert(User user) {
      if (!users.Contains(user)) {
         users.Add(user);
      }
    }
  }
}
