using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace Program
{
    #region 시간 복잡도
    // 특정 크기의 입력을 기준으로 필요한 연산 횟수
    #endregion

    #region 상수 시간 0 (1)
    // 입력 크기와 상관없이 일정한 시간 복잡도를 가지는 시간
    // ex) 배열의 인덱스 참조
    #endregion

    #region 선형 시간 0 (n)

    #endregion

    #region 로그 시간 0 (log n)
    // 데이터의 크기에 따라 실행 시간이 로그 함수의 형태로 증가하는 시간 복잡도
    // ex) 이진 탐색 트리
    #endregion

    #region 제곱 시간 0 (n^2)
    // 입력되는 데이터들 기준으로 n^2 만큼의 시간이 증가되는 시간 복잡도
    #endregion

    #region 공간 복잡도
    // 프로그램 실행과 완료에 얼마나 많은 공간이 필요한가 나타내는 척도
    #endregion

    #region 고정 공간
    // 코드가 저장되는 공간으로 알고리즘 실행을 위해 시스템이 필요로 하는 공간
    // ex) 배열
    #endregion

    #region 가변 공간
    // 문제를 해결하기 위해 알고리즘이 필요한 공간.
    // 순환 프로그램일 경우 순환 스택 의미
    #endregion

    #region 브루트 포스(Brute Force)
    // 가능한 모든 경우의 수를 탐색하면서 결과를 도출하는 알고리즘
    #endregion

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
                for (int j = 1; j < iCount.Length + 1; j++)
                {
                    if (iArray[i] == j)
                    {
                        iCount[j - 1]++;
                    }
                }
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
