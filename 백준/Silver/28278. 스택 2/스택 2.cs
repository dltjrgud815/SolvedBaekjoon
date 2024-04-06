namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        Stack<int> stack = new();

        int N = int.Parse(reader.ReadLine());
        for (int i = 0; i < N; i++)
        {
            StackControl(stack, reader.ReadLine(), writer);
        }
        
        reader.Close();
        writer.Close();
    }

    private static void StackControl(Stack<int> stack, string command, StreamWriter writer)
    {
        string[] commandArr = command.Split(' ');
        switch (commandArr[0])
        {
            case "1":
                stack.Push(int.Parse(commandArr[1]));
                break;
            
            case "2":
                if (stack.Count > 0)
                {
                    writer.WriteLine(stack.Pop());
                }
                else
                {
                    writer.WriteLine("-1");
                }
                break;
            
            case "3":
                writer.WriteLine(stack.Count);
                break;
            
            case "4":
                if (stack.Count == 0)
                {
                    writer.WriteLine("1");
                }
                else
                {
                    writer.WriteLine("0");
                }
                break;
            
            case "5":
                if (stack.Count == 0)
                {
                    writer.WriteLine("-1");
                }
                else
                {
                    writer.WriteLine(stack.Peek());
                }
                break;
        }
    }
}