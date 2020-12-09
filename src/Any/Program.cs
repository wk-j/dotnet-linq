using System;
using System.Collections.Generic;
using System.Linq;

namespace Any {
    class Student {
        public string FirstName { set; get; }
        public string LastName { set; get; }
    }

    class Student2 : Student {
        public int Age { set; get; }
    }

    class Program {
        static void Main(string[] args) {
            var a = new Student { FirstName = "F", LastName = "L" };
            var b = new Student { FirstName = "F", LastName = "X" };
            var c = new Student2 { FirstName = "F", LastName = "L" };

            var listA = new[] { a, b };
            var listB = new[] { c };

            var axc = listA.Except(listB);
            foreach (var item in axc) {
                Console.WriteLine($" {item.FirstName} {item.LastName}");
            }
        }
    }
}
