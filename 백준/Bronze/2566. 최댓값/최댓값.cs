using System;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] _doubleArray = new int[9, 9];
        int _maxVal = int.MinValue;
        int _resultOfRow = 1;
        int _resultOfCol = 1;

        for(int i = 0; i < 9; i++)
        {
            string[] _tempStr = new string[9];
            _tempStr = Console.ReadLine().Split(" ");
            for(int j = 0; j < 9; j++)
            {
                _doubleArray[i, j] = Int32.Parse(_tempStr[j]);
                if(_maxVal < _doubleArray[i, j])
                {
                    _maxVal = _doubleArray[i,j];
                    _resultOfRow = i + 1;
                    _resultOfCol = j + 1;
                }
            }
        }

        Console.WriteLine(_maxVal);
        System.Console.WriteLine(_resultOfRow + " " + _resultOfCol);
    }
}