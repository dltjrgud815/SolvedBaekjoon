using System.Text;

namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        bool isFinished = false;

        while (!isFinished)
        {
            var tempStr = reader.ReadLine();
            if (tempStr.Length == 1)
            {
                isFinished = true;
                break;
            }
            Solution(tempStr, ref sb);
        }
        
        writer.Write(sb);
        reader.Close();
        writer.Close();
    }

    public static void Solution(string args, ref StringBuilder sb)
    {
        var stack = new Stack<char>();
        
        foreach (var c in args)
        {
            if (c == '(' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']')
            {
                if (stack.Count == 0)
                {
                    sb.AppendLine("no");
                    return;
                }

                var fchar = stack.Pop();
                if (c - fchar == 1 || c - fchar == 2)
                {
                    continue;
                }
                else
                {
                    sb.AppendLine("no");
                    return;
                }
            }
        }
        
        if (stack.Count != 0)
        {
            sb.AppendLine("no");
            return;
        }
        
        sb.AppendLine("yes");
    }
}