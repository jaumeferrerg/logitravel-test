using System;

namespace logitravel_test {
  public class SmsMessenger : Messenger {
    public override void Send(Message message) {
      Console.WriteLine($"A SMS was sent to {message.Receiver}. It says: '{message.Content}'");;
    }
  }
}
