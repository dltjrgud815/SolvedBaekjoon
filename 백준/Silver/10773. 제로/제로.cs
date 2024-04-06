namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        Stack<int> stack = new();

        int K = int.Parse(reader.ReadLine());
        for (int i = 0; i < K; i++)
        {
            int value = int.Parse(reader.ReadLine());
            if (value == 0)
            {
                if (stack.Count != 0)
                    stack.Pop();
            }
            else
            {
                stack.Push(value);
            }
        }
        
        int sum = 0;
        while (stack.Count != 0)
        {
            sum += stack.Pop();
        }
        writer.Write(sum);
        
        reader.Close();
        writer.Close();
    }
}