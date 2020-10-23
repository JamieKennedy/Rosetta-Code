using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Abelian_Sandpile_Model {
    class Sandpile {
        public int width { get; set; }
        public int height { get; set; }

        public int[,] board;

        public Sandpile(int width, int height) {
            this.width = width;
            this.height = height;
            Init();
        }

        private void Init() {
            board = new int[height, width];
        }

        public void AddSand(int x, int y) {
            if (IsInBounds(x, y)) {
                board[y, x]++;
                Update();
            } else {
                Console.WriteLine("Provided Coordinates are not within the bounds of the board");
            }
        }

        private void Update() {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    if (board[i, j] > 3) {
                        board[i, j] -= 4;

                        if (IsInBounds(j - 1, i)) {
                            AddSand(j - 1, i);
                        }

                        if (IsInBounds(j + 1, i)) {
                            AddSand(j + 1, i);
                        }

                        if (IsInBounds(j, i - 1)) {
                            AddSand(j, i - 1);
                        }

                        if (IsInBounds(j, i + 1)) {
                            AddSand(j, i + 1);
                        }
                    }
                }

            }
        }

        public void PrintBoard() {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    Console.Write($"{board[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        private bool IsInBounds(int x, int y) {
            if (x >= 0 && x < width) {
                if (y >= 0 && y < height) {
                    return true;
                }
            }

            return false;
        }

        public bool IsStable() {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    if (board[i, j] > 3) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
