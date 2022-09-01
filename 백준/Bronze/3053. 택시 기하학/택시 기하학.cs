internal class Program
{
    private static void Main(string[] args)
    {
        int R = Int32.Parse(Console.ReadLine());
        double answer1 = Math.Pow(R, 2) * Math.PI;
        string strAnswer1 = string.Format("{0:0.000000}", answer1);
        System.Console.WriteLine(strAnswer1);
        double answer2 = Math.Pow(R, 2) * 2f;
        string strAnswer2 = string.Format("{0:0.000000}", answer2);
        System.Console.WriteLine(strAnswer2);
    }
}