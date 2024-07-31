namespace GE_240731_누적함
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 누적함
            // 특정한 배열이 있을 때 해당 배열까지의 합을 의미
            //
            #endregion

            int[] aArray = new int[5] { 7, 3, 4, 5, 1 };

            Console.WriteLine($"『누적함』");
            for (int i = 1; i < aArray.Length; i++)
            {
                aArray[i] = aArray[i - 1] + aArray[i];
            }

            for (int i = 0; i < aArray.Length; i++)
            {
                Console.WriteLine($"【{i}】:{aArray[i]}");
            }

            Console.WriteLine($"{aArray[4]} - {aArray[3 - 1]}");
        }
    }
}
