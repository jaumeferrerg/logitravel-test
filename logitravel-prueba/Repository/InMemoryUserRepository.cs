using System.Collections.Generic;

namespace logitravel_test {
  internal class InMemoryUserRepository : UserRepository {
    private Dictionary<string, User> users;

    public InMemoryUserRepository() {
      users = new Dictionary<string, User>();
    }

    public override IEnumerable<User> GetAll() {
      return users.Values;
    }

    public override void Insert(User user) {
      if (!users.ContainsKey(user.Id)) {
        users.Add(user.Id, user);
      }
    }
  }
}
