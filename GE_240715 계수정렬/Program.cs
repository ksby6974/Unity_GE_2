namespace GE_240715_계수정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 계수 정렬 Count Sort
            // 데이터의 값을 직접 비교하지 않고
            // 단순히 각 숫자가 몇 개 있는 지 개수를 세어
            // 저장한 다음 정렬하는 알고리즘
            #endregion

            int[] iArray = new int[] { 1, 6, 6, 6, 5, 1, 2, 3, 1, 2, 3, 6, 5, 4 };
            int[] iCount = new int[6];

            for (int i = 0; i < iArray.Length; i++)
            {
                iCount[iArray[i] - 1] += 1;
            }

            Console.WriteLine($"정렬된 값 :");
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($" {iArray[i]}");
            }
            Console.WriteLine($"");

            Console.WriteLine($"수 :");
            for (int i = 0; i < iCount.Length; i++)
            {
                Console.Write($" {iCount[i]}");
            }
        }
    }
}
