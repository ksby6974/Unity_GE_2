using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Security.Cryptography;

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
            Console.WriteLine($"배열 :");
            Console.ResetColor();

            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($" {iArray[i]}");
            }
        }

        public static void QuickSort(int[] iList, int start, int end)
        {
            // pivot
            int iMid = start;
            int iLeft = start + 1;
            int iRight = end;

            // 반복
            while(iLeft <= iRight)
            {
                Console.WriteLine($"반복 : {iLeft}, {iMid}, {iRight}");

                // left가 end보다 작거나 같음
                while (iLeft <= end && iList[iLeft] <= iList[iMid])
                {
                    iLeft += 1;
                }

                // right가 start보다 크거가 같음
                while (iRight > start && iList[iMid] <= iList[iRight])
                {
                    iRight -= 1;
                }

                if (iLeft < iRight)
                {
                    Swap(ref iList[iLeft], ref iList[iRight]);
                }
            }

            if (start < end)
            {
                Swap(ref iList[iMid], ref iList[iRight - 1]);
                QuickSort(iList, start, iRight - 1);
                QuickSort(iList, iRight + 1, end);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int iTemp = a;
            a = b;
            b = iTemp;
        }
    }
}
