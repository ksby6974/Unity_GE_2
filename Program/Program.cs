using System;
using System.Collections;
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
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾는 값을 포함한 범위를
            // 좁혀가는 방식으로 동작하는 탐색 알고리즘
            #endregion

            // 값 할당
            int[] iArray = new int[] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79};
            int iSet = 79;

            if (SearchSort(iArray, iSet) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"값 {iSet}을 찾을 수 없었습니다.");
                Console.ResetColor();
            }


            int SearchSort(int[] iArray, int iValue)
            {
                int mid = 0;
                int left = 0;
                int right = iArray.Length - 1;
                int k = 0;
                int iResult = 0;

                while (left <= right)
                {
                    mid = left + (right - left) / 2;

                    Console.WriteLine($"{++k}번째 반복 : {left} <= {right} ∥ {mid}, {iArray[mid]}");

                    if (iArray[mid] == iValue)
                    {
                        iResult = iValue;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"값 찾음 : {iValue}");
                        Console.ResetColor();
                        break;
                    }
                    else if (mid > left)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

                return iResult;
            }
        }
    }
}
