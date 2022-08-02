using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int Num = Int32.Parse(Console.ReadLine());
        string[] str = new string[Num];
        bool isTrue = true;
        int result = 0;

        StringBuilder sb = new StringBuilder();
        for(int i = 0 ; i < Num; i++)
        {
            str[i] = Console.ReadLine();
        }

        for(int i = 0; i < Num; i++)
        {
            sb.Append(str[i]);
            int[] cntNum = new int[26];
            for(int j = 0; j < sb.Length; j++)
            {
            
                cntNum[sb[j] - 'a'] ++;
                if(cntNum[sb[j] - 'a'] > 1)
                {
                    if(j != 0)
                    {
                        if(sb[j - 1] == sb[j])
                            isTrue = true;
                        else
                        {
                            isTrue = false;
                            break;
                        }
                            
                    }
                    

                }                
            }
            if(isTrue)
                result++;

            
            isTrue = true;
            sb.Clear();
        }
        System.Console.WriteLine(result);
        
    }
}