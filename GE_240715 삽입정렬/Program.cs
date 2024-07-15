namespace GE_240715_삽입정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 삽입정렬
            // 데이터를 하나씩 확인하면서 이미 정렬된 부분과 비교하여
            // 자신의 위치를 찾아 삽입하는 방식으로 정렬하는 알고리즘

            // 문제점
            // 시간 복잡도가 높을 수 있음
            // ex 끝에 최소값이 있을 경우
            #endregion

            int[] iArray = new int[] { 8, 5, 6, 2, 4 };
            int key = 0;
            int j = 0;


            for (int i = 1; i < iArray.Length; i++)
            {
                int iKey = iArray[i];

                for (j = i - 1; j >= 0 && iArray[j] > iKey; j--)
                {
                    iArray[j + 1] = iArray[j];
                }

                iArray[j + 1] = iKey;
            }

            Console.WriteLine($"정렬된 값 :");
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($" {iArray[i]}");
            }
        }
    }
}
