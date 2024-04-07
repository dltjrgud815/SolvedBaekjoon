using System.Text;

namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(reader.ReadLine());
        for (int i = 0; i < T; i++)
        {
            var tempStr = reader.ReadLine();
            if (tempStr.Length % 2 != 0)
            {
                sb.AppendLine("NO");
            }
            else
            {
                var stack = new Stack<char>();
                foreach (var c in tempStr)
                {
                    if (c == '(')
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            stack.Push(c);
                            break;
                        }
                        stack.Pop();
                    }
                }
                if (stack.Count == 0)
                {
                    sb.AppendLine("YES");
                }
                else
                {
                    sb.AppendLine("NO");
                }
            }
        }
        
        writer.Write(sb);
        reader.Close();
        writer.Close();
    }
}