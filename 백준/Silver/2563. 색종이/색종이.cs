using System;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        bool[,] _mapArr = new bool[100, 100];

        int N = Int32.Parse(Console.ReadLine());

        int Count = 0;

        for(int i = 0; i < N; i++)
        {
            int[] tempInt = new int[2];
            string[] tempStr = Console.ReadLine().Split(" ");
            tempInt[0] = Int32.Parse(tempStr[0]);
            tempInt[1] = Int32.Parse(tempStr[1]);
            for(int j = tempInt[0]; j < tempInt[0] + 10; j++)
            {
                for(int k = tempInt[1]; k < tempInt[1] + 10; k++)
                {
                    if(!_mapArr[j, k])
                    {
                        _mapArr[j, k] = true;
                    }
                }
            }
        }

        foreach (var item in _mapArr)
        {
            if(item)
            {
                Count++;
            }
        }
        System.Console.WriteLine(Count);
        
    }
}