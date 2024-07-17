namespace GE_240717_분할정복
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 분할 정복 (Divide and Conquer)
            // 주어진 문제를 2개 이상의 부분으로 문제를 나눈 뒤
            // 각 부분문에 대한 답을 재귀 호출을 이용해 계산하여
            // 그 값으로부터 전체 문제의 답을 계산하는 알고리즘

            // 1. 주어진 데이터를 두 개 혹은 그 이상의 형식으로 분할
            // 2. 문제를 더 이상 나눌 수 없을 때까지 재귀로 분할
            // 3. 문제들을 통합해서 원래 문제의 해답을 생성
            #endregion

            // 값 할당
            int[] iArray = new int[] { 5, 1, 6, 4, 8, 3, 7, 2 };

            //DivideConquer(iArray, 0, iArray.Length - 1);

            // 배열 중 최대값이 반환됨.
            int iMax = DivideConquer(iArray, 0, iArray.Length - 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"배열 중 최대값 : {iMax}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n병합된 배열 :");
            Console.ResetColor();
        }

        static public int DivideConquer(int[] aList, int left, int right)
        {
            int iMid;
            int iMaxLeft;
            int iMaxRight;

            // 재귀 종료문
            if (right == left)
            {
                Console.WriteLine($"종료 {aList[left]}");
                return aList[left];
            }
            else
            {
                // 중간 인덱스 지정
                iMid = (left + right) / 2;

                Console.WriteLine($"【】 : {left} + {right} ／ 2 ＝ {iMid} - {aList[iMid]}");

                // 재귀
                iMaxLeft = DivideConquer(aList, left, iMid);
                iMaxRight = DivideConquer(aList, iMid + 1, right);
            }

            if (iMaxLeft < iMaxRight)
            {
                return iMaxRight;
            }
            else
            {
                return iMaxLeft;
            }
        }
    }
}
