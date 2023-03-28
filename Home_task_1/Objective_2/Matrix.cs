using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Matrix
    {
        private static int _rows, _cols;
        private int[,] _array;

        public Matrix()
        {
            sbyte[] temp = MatrixSize();
            _rows = temp[0];
            _cols = temp[1];
            _array = new int[_cols, _rows];
            FillMatrix();
        }
        private void FillMatrix()                                                           // Fill matrix with random numbers
        {
            for (int i = 0; i < _cols; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    Random random = new Random();
                    _array[i, j] = random.Next(10);
                }
            }
            MatrixLogic();
        }
        private void MatrixLogic()
        {
            int rows = _array.GetLength(0);
            int cols = _array.GetLength(1);                                                                         
            (int, int)[,] checkHorint = new (int _cols, int _rows)[rows, cols];
            (int, int) empty = (-1, -1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    checkHorint[i, j] = empty;
                }

            void CheckHorizont((int x, int y) start, (int dx, int dy) step, (int, int)[,] check)                // Method to check horizontal lines
            {                      // Був би вдячним якщо поясните усно або письмово                            // In matrix
                var (xend, yend) = start;
                int count = 0;
                while (xend < _array.GetLength(0) && yend < _array.GetLength(1) && _array[xend, yend] == _array[start.x, start.y])
                {
                    check[xend, yend] = start;
                    (xend, yend) = (xend + step.dx, yend + step.dy);
                    count++;
                }
                if (count == 1) check[start.x, start.y] = empty;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (checkHorint[i, j] == empty)
                        CheckHorizont((i, j), (0, 1), checkHorint);
                }
            }

            int maxLenght = 0;
            var lines = new HashSet<((int x1, int y1) start, (int x2, int y2) end, int lenght, int color)>();   // Collection to keep information about lines    
            void MaxLenght((int i, int j) start, (int i, int j) end)
            {
                if (start == empty) return;
                var lenght = Math.Max(end.i - start.i, end.j - start.j);
                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    lines.Clear();
                    lines.Add((start, end, lenght, _array[start.i, start.j]));
                }
                if (lenght == maxLenght)
                    lines.Add((start, end, lenght, _array[start.i, start.j]));
            }
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    MaxLenght(checkHorint[i, j], (i, j));
            foreach (var item in lines)                                                                         // Print information about lines
            {
                Console.WriteLine($"{item.start}-{item.end}, lenght={item.lenght + 1}, color={item.color}");
            }
        }
        public override string ToString()
        {
            string str = "";
            Console.WriteLine();
            for (int x = 0; x < _array.GetLength(0); ++x)
            {
                for (int y = 0; y < _array.GetLength(1); ++y)
                {
                    str += _array[x, y] + " ";
                }
                str += "\n";
            }
            return str;
        }
        public sbyte[] MatrixSize()
        {
            sbyte counter = 0;
            sbyte[] temp = new sbyte[2];
            do
            {
                try
                {
                    Console.WriteLine("Enter the width of the matrix");
                    temp[0] = SByte.Parse(Console.ReadLine());
                    if (temp[0] <= 0)
                        continue;
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid format, numeric required\n");
                }
            } while (counter != 1);
            do
            {
                try
                {
                    Console.WriteLine("Enter the height of the matrix");
                    temp[1] = SByte.Parse(Console.ReadLine());
                    if (temp[1] <= 0)
                        continue;
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid format, numeric required\n");
                }
            } while (counter != 2);
            return temp;
        }
    }
}
