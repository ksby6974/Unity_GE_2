using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
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
                //Console.Write($" {iArray[i]}");
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

                Console.WriteLine($"【병합】 : {iStart}, {iEnd} ※ {aList[iStart]}, {aList[iEnd]}");
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
            int[] iTempArray = new int[right - left + 1];

            for (int k = 0; k < iTempArray.Length; k++)
            {
                if (iTempArray[left] < iTempArray[right])
                {
                    iTempArray[k] = iList[left];
                    left++;
                }
                else
                {
                    iTempArray[k] = iList[right];
                    right--;
                }

                if (left > right)
                {
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < iTempArray.Length; i++)
            {
                Console.Write($" {iTempArray[i]}");
            }
            Console.WriteLine($"");
            Console.ResetColor();
        }
    }
}
