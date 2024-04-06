namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        Queue<int> queue = new();
        string lastData = String.Empty;

        int N = int.Parse(reader.ReadLine());
        for (int i = 0; i < N; i++)
        {
            QueueControl(queue, reader.ReadLine(), writer, ref lastData);
        }
        
        reader.Close();
        writer.Close();
    }

    private static void QueueControl(Queue<int> queue, string command, StreamWriter writer, ref string lastData)
    {
        string[] commandArr = command.Split(' ');
        switch (commandArr[0])
        {
            case "push":
                queue.Enqueue(int.Parse(commandArr[1]));
                lastData = commandArr[1];
                break;
            
            case "pop":
                if (queue.Count > 0)
                {
                    writer.WriteLine(queue.Dequeue());
                }
                else
                {
                    writer.WriteLine("-1");
                }
                break;
            
            case "size":
                writer.WriteLine(queue.Count);
                break;
            
            case "empty":
                if (queue.Count == 0)
                {
                    writer.WriteLine("1");
                }
                else
                {
                    writer.WriteLine("0");
                }
                break;
            
            case "front":
                if (queue.Count == 0)
                {
                    writer.WriteLine("-1");
                }
                else
                {
                    writer.WriteLine(queue.Peek());
                }
                break;
            
            case "back":
                if (queue.Count == 0)
                {
                    writer.WriteLine("-1");
                }
                else
                {
                    writer.WriteLine(lastData);
                }
                break;
        }
    }
}