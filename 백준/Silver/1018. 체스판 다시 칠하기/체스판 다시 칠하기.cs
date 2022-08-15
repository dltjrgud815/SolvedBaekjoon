using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] tempStr = Console.ReadLine().Split(' ');
        int N = Int32.Parse(tempStr[0]);
        int M = Int32.Parse(tempStr[1]);
        char[,] chaArr = new char[N,M];
        string tempStr1;

        for(int i = 0 ; i < N; i++)
        {
            tempStr1 = Console.ReadLine();
            for(int j = 0; j < M; j++)
            {
                chaArr[i,j] = tempStr1[j];
            }
        }
        int cntBlack = 0;
        int cntWhite = 0;
        int minVal = int.MaxValue;
        char[,] tempchaBlack = (char[,])chaArr.Clone();
        char[,] tempchaWhite = (char[,])chaArr.Clone();
        for(int i = 0; i < N - 7; i++)
        {
            for(int j = 0; j < M - 7; j++)
            {
                if(tempchaBlack[i,j] != 'B')
                {
                    tempchaBlack[i,j] = 'B';
                    cntBlack ++;
                }
                if(tempchaWhite[i,j] != 'W')
                {
                    tempchaWhite[i,j] = 'W';
                    cntWhite ++;
                }
                for(int k = i; k < i + 8; k++)
                {
                    for(int l = j; l < j + 7; l++)
                    {
                        if(tempchaBlack[k,l] == tempchaBlack[k,l+1])
                        {
                            if(tempchaBlack[k,l] == 'B')
                                tempchaBlack[k,l+1] = 'W';
                            else
                                tempchaBlack[k,l+1] = 'B';
                            cntBlack++;
                        }
                        if(tempchaWhite[k,l] == tempchaWhite[k,l+1])
                        {
                            if(tempchaWhite[k,l] == 'B')
                                tempchaWhite[k,l+1] = 'W';
                            else
                                tempchaWhite[k,l+1] = 'B';
                            cntWhite++;
                        }
                    }
                    if(k<i+7)
                    {
                        if(tempchaBlack[k,j+ 7] != tempchaBlack[k+1,j])
                        {
                            if(tempchaBlack[k,j+7] == 'B')
                                tempchaBlack[k+1,j] = 'B';
                            else
                                tempchaBlack[k+1,j] = 'W';
                            cntBlack++;
                        }
                        if(tempchaWhite[k,j+7] != tempchaWhite[k+1,j])
                        {
                            if(tempchaWhite[k,j+7] == 'B')
                                tempchaWhite[k+1,j] = 'B';
                            else
                                tempchaWhite[k+1,j] = 'W';
                            cntWhite++;
                        }
                    }
                }

                tempchaBlack = (char[,])chaArr.Clone();
                tempchaWhite = (char[,])chaArr.Clone();
                if(minVal > cntBlack)
                    minVal = cntBlack;
                if(minVal > cntWhite)
                    minVal = cntWhite;

                cntBlack = 0;
                cntWhite = 0;
            }
        }

        System.Console.WriteLine(minVal);


    }
}