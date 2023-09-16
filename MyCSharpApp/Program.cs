
using System;

namespace Testing {
    class Program {
        static void Main(string[] args) {
            Console.Write(MinutesToSeconds(5));
        }

        public static int Summation (int a , int b ){
            return a + b;
        }

        public static int MinutesToSeconds(int a){
            return a * 60;
        }
    }


}