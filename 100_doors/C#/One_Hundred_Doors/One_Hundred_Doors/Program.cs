using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace One_Hundred_Doors {
    class Program {
        static void Main(string[] args) {
            bool[] doors = new bool[100];

            for (int i = 1; i <= 100; i++) {
                for (int j = 1; j <= 100; j++) {
                    if (j % i == 0) {
                        doors[j - 1] = !doors[j - 1];
                    }
                }
            }

            // Display Results
            for (int i = 0; i < 100; i++) {
                if (doors[i]) {
                    var str = string.Format("Door {0} is open", i + 1);
                    Console.WriteLine(str);
                } else {
                    var str = string.Format("Door {0} is closed", i + 1);
                    Console.WriteLine(str);
                }
            }
            
            
        }
    }
}