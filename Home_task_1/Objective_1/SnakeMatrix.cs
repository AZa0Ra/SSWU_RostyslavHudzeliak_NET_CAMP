using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class SnakeMatrix
    {
        private static int _n, _m;
        private int[,] _array;
        public SnakeMatrix()
        {
            sbyte[] temp = MatrixSize();
            _n = temp[0];
            _m = temp[1];
            MatrixStyle();
        }

        private void Matrix()
        {    
            int ibeg = 0, ifin = 0, jbeg = 0, jfin = 0;
            _array = new int[_n, _m];
            int number = 1;
            int i = 0;
            int j = 0;

            while (number <= _n * _m)
            {// Ліпшого підходу в голову не прийшло :(
                _array[i, j] = number;

                if (j == jbeg && i < _n - ifin - 1)
                    ++i;                                                            // Move numbers down
                else if (i == _n - ifin - 1 && j < _m - jfin - 1)
                    ++j;                                                            // Move numbers to the right
                else if (j == _m - jfin - 1 && i > jbeg)
                    --i;                                                            // Move numbers up
                else
                    --j;                                                            // Move numbers to the left

                if ((j == ibeg + 1) && (i == ibeg)) // && (Jbeg != m - Jfin - 2)
                {
                    ++ibeg;                                                         // Shifts the beginning and end so that the data is not overwritten
                    ++ifin;                                                         // and occupies empty cells
                    ++jbeg;
                    ++jfin;
                }
                ++number;
            }
        }

        private void BaseMatrix()
        {
            int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
            _array = new int[_n, _m];
            int number = 1;
            int i = 0;
            int j = 0;

            while (number <= _n * _m)
            {
                _array[i, j] = number;
                if (i == Ibeg && j < _m - Jfin - 1)
                    ++j;                                                            // Move numbers to the right
                else if (j == _m - Jfin - 1 && i < _n - Ifin - 1)
                    ++i;                                                            // Move numbers down
                else if (i == _n - Ifin - 1 && j > Jbeg)
                    --j;                                                            // Move numbers to the left
                else
                    --i;                                                            // Move numbers up

                if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != _m - Jfin - 1))       // Shifts the beginning and end so that the data is not overwritten
                {                                                                   // and occupies empty cells
                    ++Ibeg;
                    ++Ifin;
                    ++Jbeg;
                    ++Jfin;
                }
                ++number;
            }
        }

        public override string ToString()
        {
            string str = "";
            for (int x = 0; x < _array.GetLength(0); ++x)
            {
                for (int y = 0; y < _array.GetLength(1); ++y)
                {
                    str += _array[x, y] + "\t";
                }
                str += "\n";
            }
            return str;
        }
        private sbyte[] MatrixSize()
        {
            sbyte counter = 0;
            sbyte[] temp = new sbyte[2];
            do
            {
                try
                {
                    Console.WriteLine("Enter the width of the matrix");
                    temp[0] = SByte.Parse(Console.ReadLine());
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
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid format, numeric required\n");
                }
            } while (counter != 2);
            return temp;
        }

        public void MatrixStyle()
        {
            Console.WriteLine("Select the bypass direction: ");
            Console.WriteLine("1 - Spiral matrix ");
            Console.WriteLine("2 - Basic spiral matrix ");

            sbyte choice = 1;
            do
            {
                try
                {
                    choice = SByte.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid format, or number.\n");
                }
            } while (choice != 1 && choice != 2);
            if (choice == 1)
                Matrix();
            else BaseMatrix();
        }
    }
}
