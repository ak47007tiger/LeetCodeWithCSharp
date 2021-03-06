using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiuKeWang {
  public class PowN {
    public int Pow(int v, int count) {
      if (count == 1)return v;

      if (count % 2 == 0) {
        var a = Pow(v, count / 2);
        return a * a;
      } else {
        var a = Pow(v, count / 2);
        return a * a * v;
      }
    }
  }
}