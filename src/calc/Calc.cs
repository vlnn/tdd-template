using System;

namespace calc {
    public class Calc {
        private int sum;
        public int Add(string args){
            var result = int.TryParse(args, out sum);
            return sum;
        }
    }
}
