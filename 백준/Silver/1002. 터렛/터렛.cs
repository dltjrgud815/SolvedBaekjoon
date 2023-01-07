using System;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());

        int[,] _turret = new int[N, 6];
        int[] result = new int[N];

        for(int i = 0; i < N; i++)
        {
            string[] tempStr = Console.ReadLine().Split(" ");
            for(int j = 0; j < 6; j++)
            {
                _turret[i, j] = Int32.Parse(tempStr[j]);
            }

            decimal _distance = ((decimal)(_turret[i, 0] - _turret[i, 3]) * (decimal)(_turret[i, 0] - _turret[i, 3])) + ((decimal)(_turret[i, 1] - _turret[i, 4]) * (decimal)(_turret[i, 1] - _turret[i, 4]));
            decimal _addDistance = (decimal)MathF.Abs(_turret[i, 2] + _turret[i, 5]) * (decimal)MathF.Abs(_turret[i, 2] + _turret[i, 5]);
            decimal _minusDistance = (decimal)MathF.Abs(_turret[i, 2] - _turret[i, 5]) * (decimal)MathF.Abs(_turret[i, 2] - _turret[i, 5]);
            if(_distance == 0 && _turret[i, 2] == _turret[i, 5])
            {
                result[i] = -1;
            }
            else if(_minusDistance < _distance && _addDistance > _distance)
            {
                result[i] = 2;
            }
            else if(_addDistance == _distance || _minusDistance == _distance)
            {
                result[i] = 1;
            }
            else
            {
                result[i] = 0;
            }
            // if(_minusDistance < _distance && _addDistance > _distance)
            // {
            //     result[i] = 2;
            // }
            // else if((_addDistance == _distance || _minusDistance == _distance) && _minusDistance != _distance)
            // {
            //     result[i] = 1;
            // }
            // else if(_addDistance < _distance || _minusDistance > _distance || (_distance == 0 && _minusDistance != 0))
            // {
            //     result[i] = 0;
            // }
            // else
            // {
            //     result[i] = -1;
            // }
        }

        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }

        
    }
}