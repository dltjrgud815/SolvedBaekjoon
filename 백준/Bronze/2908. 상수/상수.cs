using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        string str = Console.ReadLine();
        string[] words = str.Split(" ");

        sb1.Append(words[0]);
        sb2.Append(words[1]);

        if(Int32.Parse(sb1[2].ToString()) > Int32.Parse(sb2[2].ToString()))
            ReversePrint(sb1);
        else if(Int32.Parse(sb1[2].ToString()) == Int32.Parse(sb2[2].ToString()))
            if(Int32.Parse(sb1[1].ToString()) > Int32.Parse(sb2[1].ToString()))
                ReversePrint(sb1);
            else if(Int32.Parse(sb1[1].ToString()) == Int32.Parse(sb2[1].ToString()))
                if(Int32.Parse(sb1[0].ToString()) > Int32.Parse(sb2[0].ToString()))
                    ReversePrint(sb1);
                else
                    ReversePrint(sb2);
            else
                ReversePrint(sb2);
        else
            ReversePrint(sb2);
    }

    static void ReversePrint(StringBuilder sb)
    {
        for(int i = 0; i < 3; i++)
        {
            System.Console.Write(sb[2 - i].ToString());
        }
    }

}