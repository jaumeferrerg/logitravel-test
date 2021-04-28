using System;
using System.Diagnostics.CodeAnalysis;

namespace logitravel_test {
  public class Hotel : IEquatable<Hotel>  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Zone { get; set; }

    public bool Equals([AllowNull] Hotel other) {
      return other.Id == Id;
    }
  }
}
