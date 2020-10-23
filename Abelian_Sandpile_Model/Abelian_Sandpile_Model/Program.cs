using System;
using System.Diagnostics.Tracing;
using System.Threading;

namespace Abelian_Sandpile_Model {
    class Program {
        static void Main(string[] args) {
            Sandpile sp = new Sandpile(20, 20);
            int centreX = 9;
            int centreY = 9;
            int counter = 0;

            while (counter < 1000) {
                counter++;
                Console.Clear();
                sp.PrintBoard();
                sp.AddSand(centreX, centreY);
                Thread.Sleep(100);
            }
        }
    }
}
