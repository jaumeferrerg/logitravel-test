using System;

namespace logitravel_test {
  public class EmailMessenger : Messenger {
    public override void Send(Message message) {
      Console.WriteLine($"An email was sent to {message.Receiver}. It says: '{message.Content}'");
    }
  }
}
