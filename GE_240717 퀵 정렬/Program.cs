namespace GE_240717_퀵_정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 퀵 정렬 (Quick Sort)
            // 기준점을 획득한 다음 해당 기준점을 기준으로
            // 배열을 나누고 한쪽에는 기준점보다 작은 값들이 위치
            // 다른 한쪽에는 기준점보다 큰 값들이 위치하도록 정렬하는 알고리즘

            // 나누어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여
            // 모든 배열이 기본 배열이 될 때까지 반복하며 정렬

            // 평균적으로 O(n log n)의 시간 복잡도를 가지며
            // 최악의 경우 O(n^2)의 시간 복잡도를 가짐

            // 1. 기준점 선택
            // 2. 기준점 기준으로 왼쪽보다 큰 값, 오른쪽보다 작은 값 탐색
            // 3. 양 방향에서 찾은 두 원소 교환
            // 4. 왼쪽에서 탐색하는 위치와 오른쪽에서 탐색하는 위치가
            // 엇갈리지 않을 때까지 2번으로 돌아가 반복
            // 5. 엇갈린 기점을 기준으로 두 개의 부분 리스트로 나누어
            // 1번으로 돌아가 해당 부분의 리스트 길이가 1일 될 때까지 반복
            // 6. 인접한 부분 리스트끼리 합하여 수행.
            #endregion

            // 값 할당
            int[] iArray = new int[] { 5, 1, 9, 6, 4, 8, 3, 7, 2 };

            QuickSort(iArray, 0, iArray.Length - 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"재정렬된 배열 :");
            Console.ResetColor();

            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($" {iArray[i]}");
            }
        }

        public static void QuickSort(int[] iList, int start, int end)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"─────────────────────────");
            Console.WriteLine($"시작");
            Console.ResetColor();

            // pivot
            int iMid = start;
            int iLeft = start + 1;
            int iRight = end;

            // 반복
            while (iLeft <= iRight)
            {
                Console.WriteLine($"반복 : {iLeft}, {iMid}, {iRight}");

                // left가 end보다 작거나 같음
                while (iLeft <= end && iList[iLeft] <= iList[iMid])
                {
                    iLeft++;
                }

                // right가 start보다 크거가 같음
                while (iRight > start && iList[iMid] <= iList[iRight])
                {
                    iRight--;
                }

                if (iLeft > iRight)
                {
                    Swap(ref iList[iMid], ref iList[iRight], iList);
                }
                else
                {
                    Swap(ref iList[iLeft], ref iList[iRight], iList);
                }
            }

            if (start < end)
            {
                QuickSort(iList, start, iRight - 1);
                QuickSort(iList, iRight + 1, end);
            }

            Console.WriteLine($"종료 : {iLeft}, {iMid}, {iRight}");
        }

        // 값 교환
        static void Swap(ref int a, ref int b, int[] iList)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"【{a} ↔ {b} 】");
            int iTemp = a;
            a = b;
            b = iTemp;

            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < iList.Length; i++)
            {
                Console.Write($"{iList[i]} ");
            }
            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
