using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Transactions;

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
            #region 최장 증가 부분 수열
            // 원소가 n개인 배열의 일부 원소를 골라내서 만든 부분 수열 중
            // 각 원소가 이전 원소보다 크다는 조건을 만족하고 그 길이가 최대인 부분 수열 

            // 주어진 배열에서 인덱스를 한칸씩 늘려가며 확인
            // 내부 반복문으로 i보다 작은 인덱스들을 하나씩 살펴보면서
            // aArray[i] > aArray[j]일 경우 count 배열을 업데이트

            // 1. LIS의 첫번째는 항상 1부터 시작
            // 2. 2보다 작은 이전의 인덱스가 없으므로 count 배열의 [i]에 값을 1 저장
            // 3. 4보다 작은 이전 이전 인덱스 array[i] 가장 큰 count 배열의 값은 1이므로 count 배열 [i]에 1+1 = 2로 만듬
            // 4. 1보다 작은 이전 인덱스가 없으므로 count 배열[i]의 값에 1을 저장
            // 5. 6보다 작은 이전 이전 인덱스 array[i] 배열 중 가장 큰 값 count배열 값은 2이므로
            // count[i]의 값에 2 + 1 = 3으로 만들어 줌

            // 업데이트 기준
            // 1. j번째 인덱스에서 끝나는 최장 증가 부분 수열의 마지막에 array[i]를 추가했을 때 LIST 길이
            // 2. 추가하지 않고 기존의 count 배열 [i]의 값


            #endregion

            int[] aArray = new int[] { 3, 2, 4, 1, 6 };
            int[] iCount = new int[aArray.Length];

            iCount[0] = 1;

            for (int i = 1; i < aArray.Length; i++)
            {
                // 첫 원소부터 i 원소 전까지 비교합니다.
                for (int j = 0; j < i; j++)
                {
                    if (aArray[i] > aArray[j])
                    {
                        iCount[i] = Math.Max(iCount[i], iCount[j] + 1);
                    }

                    // 증가 부분 수열의 길이는 1부터 시작하므로 0인 값을 1로 저장합니다.
                    if (iCount[i] == 0)
                    {
                        iCount[i] = 1;
                    }
                }
            }

            Console.WriteLine($"결과 :");
            for (int i = 0; i < iCount.Length; i++)
            {
                Console.Write($"{iCount[i]} ");
            }
        }
    }
}
