namespace GE_240715_쉘_정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 쉘 정렬
            // 삽입 정렬을 보완한 방법.
            // 먼 거리의 요소들을 먼저 정렬하여 배열을 부분적으로
            // 정렬한 후 점진적으로 더 작은 간격을 사용하는 정렬 알고리즘

            //
            // 1. 먼저 정렬해야할 리스트를 일정한 기준에 따라 분류
            // 2. 연속적이지 않은 여러 개의 부분 리스트를 생성
            // 3. 각 부분 리스트를 삽입 정렬을 이용해서 정렬
            // 4. 모든 부분 리스트가 정렬되면 다시 전체 리스트를
            // 더 적은 개수의 부분 리스트로 만든 후 정렬을 반복
            // 5. 리스트의 개수가 1이 될 때까지 반복
            #endregion

            int[] iArray = new int[] { 8, 5, 6, 2, 4, 1, 3, 7, 9, 10, 15, 13, 14, 12, 11 };
            int iGap = (iArray.Length);

            do
            {
                // Gap 설정
                // 보통 짝수보다는 홀수가 빠르고 N / 3 + 1이 더 빠름
                iGap = (iGap / 3) + 1;
                int j = 0;

                // 삽입 정렬
                for (int i = iGap; i < iArray.Length; i++)
                {
                    int iKey = iArray[i];

                    for (j = i - iGap; j >= 0 && iArray[j] > iKey; j -= iGap)
                    {
                        iArray[j + iGap] = iArray[j];
                    }

                    iArray[j + iGap] = iKey;
                }
            } while (iGap != 1);

            Console.WriteLine($"정렬된 값 :");
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($" {iArray[i]}");
            }
            Console.WriteLine($"");

            HisAnswer();

            void HisAnswer()
            {
                int[] aArray = new int[] { 8, 5, 6, 2, 4, 1, 3, 7, 9, 10, 15, 13, 14, 12, 11 };
                int gap = 0;
                int i = 0;
                int j = 0;
                int key = 0;

                for (gap = aArray.Length / 2; gap > 0; gap /= 2)
                {
                    if (gap % 2 == 0)
                    {
                        gap++;
                    }

                    for (i = gap; i < aArray.Length; i++)
                    {
                        key = aArray[i];

                        for (j = i; j >= gap && aArray[j - gap] > key; j -= gap)
                        {
                            aArray[j] = aArray[j - gap];
                        }

                        aArray[j] = key;
                    }
                }

                Console.WriteLine($"정렬된 값 :");
                for (i = 0; i < aArray.Length; i++)
                {
                    Console.Write($" {aArray[i]}");
                }
            }
        }
    }
}
