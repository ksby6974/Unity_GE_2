namespace GE_240716_투포인터
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터
            // 두 개의 포인터를 두고 값들을 비교하여 문제를 해결하는 알고리즘
            // 시간복잡도 O(N), O(N^2)    

            // 부분합 = M(5)
            // 1. 시작점과 끝점이 첫번째 원소의 인덱스를 가리킴.
            // 2. 현재 부분합이 M과 같다면 카운트
            // 3. 현재 부분합이 M보다 작다면 end를 증가시킴
            // 4. 현재 부분합이 M보다 크다면 start를 증가시킴
            #endregion

            int[] iArray = new int[] { 1, 2, 5, 2, 5 };

            Console.WriteLine($"원 배열 :");
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($"{iArray[i]} ");
            }
            Console.WriteLine($"\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"정렬된 값 :");
            Console.ResetColor();

            for (int i = 0; i < iArray.Length; i++)
            {
                int iTemp = TwoPointerSort(iArray, i);

                Console.WriteLine($"{iTemp} : {iArray[iTemp]}");
            }
        }

        public static int TwoPointerSort(int[] iArray, int iM)
        {
            int iCount = 0;
            int iSum = 0;

            int iStart = 0;
            int iEnd = 0;

            while (iStart <= iEnd)
            {
                if (iSum >= iM)
                {
                    iSum -= iArray[iStart++];
                }
                else if (iEnd >= iArray.Length)
                {
                    break;
                }
                else
                {
                    iSum += iArray[iEnd++];
                }

                if (iSum == iM)
                {
                    iCount++;
                }
            }

            return iCount;
        }
    }
}
