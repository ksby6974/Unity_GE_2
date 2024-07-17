namespace GET_240716_이진탐색
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾는 값을 포함한 범위를
            // 좁혀가는 방식으로 동작하는 탐색 알고리즘
            #endregion

            // 값 할당
            int[] iArray = new int[] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79 };
            int iSet = 11;

            BinarySearch(iArray, iSet);
        }

        static void BinarySearch(int[] iList, int iKey)
        {
            int left = 0;
            int right = iList.Length - 1;
            int k = 0;

            while (left <= right)
            {
                // 배열의 가운데 요소의 인덱스를 pivot으로 결정
                int pivot = (left + right) / 2;

                Console.WriteLine($"{++k}번째 반복 : {left} <= {right} ∥ {pivot}");

                // pivot의 값이 찾고자 하는 요소와 같다면 검색 종료
                if (iList[pivot] == iKey)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{iKey} Key is founded.");
                    Console.ResetColor();
                    return;
                }
                // pivot의 값이 찾는 값보다 크다면 left ~ pivot 사이의 값을 검색
                else if (iList[pivot] > iKey)
                {
                    right = pivot - 1;
                }
                // pivot의 값이 찾는 값보다 작다면 pivot ~ right 사이의 값을 검색
                else
                {
                    left = pivot + 1;
                }
            }

            Console.WriteLine($"{iKey} Not Ket found.");
        }
    }
}
