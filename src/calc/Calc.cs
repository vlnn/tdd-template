using System;

namespace calc {
    public class Calc {
        private int parsedint;
        private int sum;
        public int Add(string args){
            var results = args.Split(",", new StringSplitOptions());
            sum = 0;
            foreach (string number in results) {
                if (int.TryParse(number, out parsedint)){
                    sum += parsedint;
                }
            }
            return sum;
        }
    }
}
