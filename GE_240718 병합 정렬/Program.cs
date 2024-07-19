namespace GE_240718_병합_정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 병합 정렬 ( Sort)
            // 하나의 리스트를 두 개의 균등한 크기로 분할하고
            // 분할된 부분 리스트를 정렬한 다음, 두 개의 정렬된 부분 리스트를
            // 합하여 전체가 정렬된 리스트가 되게 하는 방법

            // 1. 리스트의 길이가 0 또는 1이면 이미 정렬된 것으로 간주
            // 2. 그렇지 않은 경우
            // 2 - 1. 정렬되지 않은 리스트를 절반으로 비슷한 크기의 두 부분 리스트로 나눔
            // 2 - 2. 각 부분 리스트를 재귀적으로 병합 정렬을 이용해 정렬
            // 2 - 3. 두 부분 리스트를 다시 하나의 정렬된 리스트로 병합
            // 3.
            #endregion

            // 값 할당
            int[] iArray = new int[] { 5, 1, 9, 6, 4, 8, 3, 7, 2 };

            MergeSort(iArray, 0, iArray.Length - 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"재정렬된 배열 :");
            Console.ResetColor();

            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($" {iArray[i]}");
            }
        }

        static public void MergeSort(int[] aList, int iStart, int iEnd)
        {
            int iMid;

            // 재귀 종료문
            if (iStart < iEnd)
            {
                // 중간 인덱스 지정
                iMid = (iStart + iEnd) / 2;

                Console.Write($"【】 : {iStart} + {iEnd} ／ 2 ＝ {iMid} - ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{aList[iMid]}");
                Console.ResetColor();

                // 재귀
                MergeSort(aList, iStart, iMid);
                MergeSort(aList, iMid + 1, iEnd);

                Console.WriteLine($"【병합】 : {iStart}, {iMid}, {iEnd}");
                // 병합
                Merge(aList, iStart, iMid, iEnd);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"재귀 종료 : {iStart} → {aList[iStart]}");
                Console.ResetColor();
            }
        }

        static public void Merge(int[] iList, int start, int middle, int end)
        {
            int count = 0;
            int left = start;
            int right = middle + 1;
            int[] iTempArray = new int[end - start + 1];
            Console.Write($"『{iTempArray.Length}』, 《{count}》");

            // 값 비교 후 복사
            while (left <= middle && right <= end)
            {
                if (iList[left] <= iList[right])
                {
                    iTempArray[count++] = iList[left++];
                }
                else
                {
                    iTempArray[count++] = iList[right++];
                }
            }

            // 남은 왼쪽 배열의 요소들을 복사
            while (left <= middle)
            {
                iTempArray[count++] = iList[left++];
            }

            // 남은 오른쪽 배열의 요소들을 복사
            while (right <= end)
            {
                iTempArray[count++] = iList[right++];
            }

            // 원본 배열에 정렬된 임시 배열의 값을 복사
            for (int i = 0; i <= iTempArray.Length; i++)
            {
                iList[start + 1] = iTempArray[i];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"『{iTempArray.Length}』, 《{count}》");
            for (int i = 0; i < iTempArray.Length; i++)
            {
                Console.Write($" {iTempArray[i]}");
            }
            Console.WriteLine($"");
            Console.ResetColor();
        }
    }
}
