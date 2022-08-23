using System;
using System.Text;
using System.IO;


internal class Program
{
    private static void Main(string[] args)
    {
        
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        int N = Int32.Parse(reader.ReadLine());
        int[,] num = new int[N, 2];
        string[] tempStr = new string[2];
        for(int i = 0; i < N; i++)
        {
            tempStr = reader.ReadLine().Split(' ');
            num[i, 0] = Int32.Parse(tempStr[0]);
            num[i, 1] = Int32.Parse(tempStr[1]);
        }

        QuickSort(num, 0, N -1);
        for(int i =0; i< N; i++)
        {
            writer.WriteLine($"{num[i,0]} {num[i,1]}");
        }

        reader.Close();
        writer.Close();


    }

    static void QuickSort(int[,] array, int left, int right)
    {
        if(left < right)
        {
            int pivot = RandomPartition(array, left, right);
            QuickSort(array, left, pivot - 1);
            QuickSort(array, pivot + 1, right);
        }
    }

    static int RandomPartition(int[,] array, int left, int right)
    {
        Random random = new Random();
        int i = random.Next(left, right);

        Swap(array, i, right, 0);
        Swap(array, i, right, 1);
        return Partition(array, left, right);

    }

    static int Partition(int[,] array, int left, int right)
    {
        int pivot = array[right, 1];  //피봇값 저장 
        int i = left - 1;
        for(int j = left; j <= right - 1; j ++)
        {
            if(array[j,1] < pivot)
            {
                i++;
                Swap(array, i, j, 0);
                Swap(array, i, j , 1);
                
            }
            else if(array[j,1] == pivot && array[right, 0] > array[j, 0])
            {
                i++;
                Swap(array, i, j, 0);
                Swap(array, i, j , 1);
            }
            
        }
        Swap(array, i+1, right , 0);
        Swap(array, i+1, right , 1);
        
        return i+1;
    }

    static void Swap(int[,] array, int bIndex, int aIndex, int index)
    {
        var tmp = array[bIndex , index];
        array[bIndex , index] = array[aIndex , index];
        array[aIndex , index] = tmp;

    }


}