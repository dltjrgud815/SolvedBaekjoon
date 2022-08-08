using System;
using System.Text;
using System.Collections.Generic;

namespace baekjoon0808
{
    internal class Program
    {
        static void Main()
        {

            int N = Int32.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
            ChatBot(sb, N, -N);
        }
        static void ChatBot(StringBuilder sbb, int n, int K)
        {
            int j = n;
            if (n > 0)
            {
                Console.WriteLine(sbb+"\"재귀함수가 뭔가요?\"");
                Console.WriteLine(sbb+"\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
                Console.WriteLine(sbb+"마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
                Console.WriteLine(sbb+"그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");
                sbb.Insert(0, "____");
                ChatBot(sbb, --j, K);
                
            }
            else if (j == 0)
            {
                Console.WriteLine(sbb+"\"재귀함수가 뭔가요?\"");
                Console.WriteLine(sbb+"\"재귀함수는 자기 자신을 호출하는 함수라네\"");
                ChatBot(sbb, --j, K);
            }
            else if(j >= K - 1)
            {
                Console.WriteLine(sbb+"라고 답변하였지.");
                if(sbb.Length >= 4)
                    sbb.Remove(0, 4);
                ChatBot(sbb, --j, K);
               
            }
            
        }
    
    }
    
}